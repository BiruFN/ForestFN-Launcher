using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForestFN_Launcher
{
    public class Forest
    {
        public static void ThreadStart(ThreadStart threadStart)
        {
            Thread thread = new Thread(new ThreadStart(threadStart));
            thread.Start();
        }

        public static bool ExistsPort(int port)
        {
            try
            {
                new TcpClient("127.0.0.1", port);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetCharacter(string AccountId, string AccessToken)
        {
            var client = new RestClient("https://forestbackendv2.birufn.repl.co");
            var request = new RestRequest($"/loadout/{AccountId}/character", Method.Get);
            request.AddHeader("Authorization", $"Bearer {AccessToken}");

            var response = client.Execute(request).Content;

            return response;
        }
    }
}
