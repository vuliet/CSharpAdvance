using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace TestSomeThing
{
    class Program
    {
        public class NftWalletResponse<T>
        {
            public bool Status { get; set; }

            public T Result { get; set; }

            public NftWalletError Error { get; set; }
        }

        public class NftWalletError
        {
            public int Code { get; set; }

            public string Message { get; set; }

            public string CustomMessage { get; set; }
        }

        public class TestData
        {
            [JsonPropertyName("nftContract")]
            public string NftContract { get; set; }
        }

        public static (bool, T, NftWalletError) TestSomeThingS<T>()
        {
            var objData = new
            {
                status = true,
                result = new { nftContract = "xssad000" }
            };

            var responseBody = JsonConvert.SerializeObject(objData);

            var walletResponse = JsonConvert.DeserializeObject<NftWalletResponse<T>>(responseBody);

            if (walletResponse != null && !walletResponse.Status)
                return (false, default, walletResponse.Error);

            if (walletResponse != null)
            {
                if (typeof(T) == typeof(string))
                    return (true, (T)Convert.ChangeType(walletResponse.Result, typeof(T)), default);

                return (true, walletResponse.Result, default);
            }

            try
            {
                return (true, JsonConvert.DeserializeObject<T>(responseBody), default);
            }
            catch (Exception)
            {
                return (false, default, default);
            }
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //var (success, data, error) = TestSomeThingS<TestData>();

            //Console.WriteLine(data.NftContract);

            Console.WriteLine(Factorial(4) == 24);

            Console.ReadLine();
        }
    }
}
