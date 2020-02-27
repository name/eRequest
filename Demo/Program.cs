using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

using eRequest;

namespace Demo {

    class Program {
        static void Main(string[] args) {

            /* Setup eRequest */
            eRequest.eRequest ERequest = new eRequest.eRequest("EncryptionKey");
            ERequest.NullifyProxy = true;
            NameValueCollection test = new NameValueCollection();

            /* Set POST Data & Request */
            test["key"] = "value";
            Response response = ERequest.Request("https://maddex.co/demo.php", test);

            /* Display Reponse Data */
            Console.WriteLine($"Raw: {response.raw}");
            Console.WriteLine($"Status: {response.status}");
            Console.WriteLine($"Message: {response.message}");
            Console.WriteLine($"Extra: {response.GetData<string>("charlie")}");
            Console.WriteLine($"POST Data: {response.GetData<string>("key")}");

            Console.ReadLine();
        }
    }

}