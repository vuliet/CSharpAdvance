using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample
{
    class Program
    {
        public static void ShowHeader(HttpResponseHeaders headers)
        {
            Console.WriteLine("Các Header");
            foreach(var header in headers)
            {
                Console.WriteLine($"{header.Key} : {header.Value}");
            }
        }

        public static async Task<string> GetWebContent(string url)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.DefaultRequestHeaders.Add("Custom header", "Value custom header"); // thêm header

                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                ShowHeader(httpResponseMessage.Headers);

                var html = await httpResponseMessage.Content.ReadAsStringAsync();

                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "error";
            }
        }

        public static async Task<byte[]> DownloadDataBytes(string url)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0"); // thêm header

                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                ShowHeader(httpResponseMessage.Headers);

                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();

                return bytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        static async Task Main(string[] args)
        {
            //var url = "https://google.com.vn";
            //var html = await GetWebContent(url);
            //Console.WriteLine(html);

            //var url = "https://www.google.com.vn/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png";

            //var bytes = await DownloadDataBytes(url);

            //string rootPath = "D:/Tai-lieu-hoc-tap/Tai-lieu-lap-trinh/C#/Source/CSharpAdvance/HttpClient";
            //string fileName = rootPath + "/1.png";

            //var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            //stream.Write(bytes, 0, bytes.Length);


            var httpClient = new HttpClient();

            var httpMessageRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://postman-echo.com/post")
            };
            httpMessageRequest.Headers.Add("User-Agent", "Mozilla/5.0");

            // POST
            //var parameters = new List<KeyValuePair<string, string>>();
            //parameters.Add(new KeyValuePair<string, string>("key1","value1"));
            //parameters.Add(new KeyValuePair<string, string>("key2","value2-1"));
            //parameters.Add(new KeyValuePair<string, string>("key2","value2-2"));
            //parameters.Add(new KeyValuePair<string, string>("key3","value3"));

            string data = @"{
                ""key1"": ""giatri1"",
                ""key2"": ""giatri2""
            }";

            Console.WriteLine(data);

            //var content = new FormUrlEncodedContent(parameters);

            var content = new StringContent(data, Encoding.UTF8, "application/json");
            httpMessageRequest.Content = content;
            // POST

            var httpResponseMessage = await httpClient.SendAsync(httpMessageRequest);

            ShowHeader(httpResponseMessage.Headers);

            var html = await httpResponseMessage.Content.ReadAsStringAsync();

            Console.WriteLine(html);

            Console.ReadLine();
        }
    }
}
