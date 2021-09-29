using System;

using System.Net.Http;
using System.Collections.Generic;
//add ref to Newtonsoft.Json.dll found in epicor folder
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.IO;
//using System.Web;
using System.Net;
using System.Text.Json;
using System.Text;
//using Newtonsoft;
//using Newtonsoft.Json.Bson;
using System.Json;

using System.Threading.Tasks;

using RestSharp;
using RestSharp.Authenticators;



namespace imc_code_test
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //https://restsharp.dev/getting-started/getting-started.html#basic-usage
            //var client = new RestClient("https://api.taxjar.com/v2/rates/90404");
            var client = new RestClient("https://api.taxjar.com/v2/rates/V5K0A1?country=CA&city=Vancouver");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Token token=5da2f821eee4035db4771edab942a4cc");
            request.AddHeader("api_key", "");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);






        }
    }

}
