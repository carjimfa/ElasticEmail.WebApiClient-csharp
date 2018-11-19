using ElasticEmail.WebApiClient.ApiTypes;
using ElasticEmail.WebApiClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient
{
    public static class ApiUtilities
    {
        public static byte[] HttpPostFile(string url, List<FileData> fileData, NameValueCollection parameters)
        {
            try
            {
                string boundary = DateTime.Now.Ticks.ToString("x");
                byte[] boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

                HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
                wr.ContentType = "multipart/form-data; boundary=" + boundary;
                wr.Method = "POST";
                wr.KeepAlive = true;
                wr.Credentials = CredentialCache.DefaultCredentials;
                wr.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                wr.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                Stream rs = wr.GetRequestStream();

                string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                foreach (string key in parameters.Keys)
                {
                    rs.Write(boundarybytes, 0, boundarybytes.Length);
                    string formitem = string.Format(formdataTemplate, key, parameters[key]);
                    byte[] formitembytes = Encoding.UTF8.GetBytes(formitem);
                    rs.Write(formitembytes, 0, formitembytes.Length);
                }

                if (fileData != null)
                {
                    foreach (var file in fileData)
                    {
                        rs.Write(boundarybytes, 0, boundarybytes.Length);
                        string headerTemplate = "Content-Disposition: form-data; name=\"filefoobarname\"; filename=\"{0}\"\r\nContent-Type: {1}\r\n\r\n";
                        string header = string.Format(headerTemplate, file.FileName, file.ContentType);
                        byte[] headerbytes = Encoding.UTF8.GetBytes(header);
                        rs.Write(headerbytes, 0, headerbytes.Length);
                        rs.Write(file.Content, 0, file.Content.Length);
                    }
                }
                byte[] trailer = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                rs.Write(trailer, 0, trailer.Length);
                rs.Close();

                using (WebResponse wresp = wr.GetResponse())
                {
                    MemoryStream response = new MemoryStream();
                    wresp.GetResponseStream().CopyTo(response);
                    return response.ToArray();
                }
            }
            catch (WebException webError)
            {
                // Throw exception with actual error message from response
                throw new WebException(((HttpWebResponse)webError.Response).StatusDescription, webError, webError.Status, webError.Response);
            }
        }

        public static byte[] HttpPutFile(string url, FileData fileData, NameValueCollection parameters)
        {
            try
            {
                string queryString = BuildQueryString(parameters);

                if (queryString.Length > 0) url += "?" + queryString.ToString();

                HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
                wr.ContentType = fileData.ContentType ?? "application/octet-stream";
                wr.Method = "PUT";
                wr.KeepAlive = true;
                wr.Credentials = CredentialCache.DefaultCredentials;
                wr.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                wr.Headers.Add("Content-Disposition: attachment; filename=\"" + fileData.FileName + "\"; size=" + fileData.Content.Length);
                wr.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                Stream rs = wr.GetRequestStream();
                rs.Write(fileData.Content, 0, fileData.Content.Length);

                using (WebResponse wresp = wr.GetResponse())
                {
                    MemoryStream response = new MemoryStream();
                    wresp.GetResponseStream().CopyTo(response);
                    return response.ToArray();
                }
            }
            catch (WebException webError)
            {
                // Throw exception with actual error message from response
                throw new WebException(((HttpWebResponse)webError.Response).StatusDescription, webError, webError.Status, webError.Response);
            }
        }

        public static FileData HttpGetFile(string url, NameValueCollection parameters)
        {
            try
            {
                string queryString = BuildQueryString(parameters);

                if (queryString.Length > 0) url += "?" + queryString.ToString();

                HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
                wr.Method = "GET";
                wr.KeepAlive = true;
                wr.Credentials = CredentialCache.DefaultCredentials;
                wr.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                wr.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (WebResponse wresp = wr.GetResponse())
                {
                    MemoryStream response = new MemoryStream();
                    wresp.GetResponseStream().CopyTo(response);
                    if (response.Length == 0) throw new FileNotFoundException();
                    string cds = wresp.Headers["Content-Disposition"];
                    if (cds == null)
                    {
                        // This is a special case for critical exceptions
                        ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(response.ToArray()));
                        if (!apiRet.success) throw new ApplicationException(apiRet.error);
                        return null;
                    }
                    else
                    {
                        ContentDisposition cd = new ContentDisposition(cds);
                        FileData fileData = new FileData();
                        fileData.Content = response.ToArray();
                        fileData.ContentType = wresp.ContentType;
                        fileData.FileName = cd.FileName;
                        return fileData;
                    }
                }
            }
            catch (WebException webError)
            {
                // Throw exception with actual error message from response
                throw new WebException(((HttpWebResponse)webError.Response).StatusDescription, webError, webError.Status, webError.Response);
            }
        }

        static string BuildQueryString(NameValueCollection parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return null;

            StringBuilder query = new StringBuilder();
            string amp = string.Empty;
            foreach (string key in parameters.AllKeys)
            {
                foreach (string value in parameters.GetValues(key))
                {
                    query.Append(amp);
                    query.Append(WebUtility.UrlEncode(key));
                    query.Append("=");
                    query.Append(WebUtility.UrlEncode(value));
                    amp = "&";
                }
            }

            return query.ToString();
        }

    }
}
