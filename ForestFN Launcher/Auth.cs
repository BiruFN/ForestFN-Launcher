using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestFN_Launcher
{
    public class Auth
    {
        public static string GetCredentials()
        {
            var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
            var request = new RestRequest("/account/api/oauth/token", Method.Post);
            request.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
            request.AddParameter("grant_type", "client_credentials");

            var response = client.Execute(request).Content;

            return response;
        }
        public static string GetDeviceAuthorization(string CredentialsToken)
        {
            var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
            var request = new RestRequest("/account/api/oauth/deviceAuthorization", Method.Post);
            request.AddHeader("Authorization", $"Bearer {CredentialsToken}");

            var response = client.Execute(request).Content;

            return response;
        }
        public static string GetAccessWithDeviceCode(string DeviceCode)
        {
            for (; ; )
            {
                var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
                var request = new RestRequest("/account/api/oauth/token", Method.Post);
                request.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
                request.AddParameter("grant_type", "device_code");
                request.AddParameter("device_code", DeviceCode);

                var response = client.Execute(request).Content;

                if (response.Contains("access_token"))
                {
                    return response;
                }
                if (response.Contains("errors.com.epicgames.account.oauth.authorization_pending"))
                {
                    Thread.Sleep(1000);
                }
                if (response.Contains("errors.com.epicgames.not_found"))
                {
                    return "authorization_canceled";
                }
            }
        }
        public static string GetAccessWithDeviceAuth(string DeviceId, string AccountId, string Secret)
        {
            var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
            var request = new RestRequest("/account/api/oauth/token", Method.Post);
            request.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
            request.AddParameter("grant_type", "device_auth");
            request.AddParameter("account_id", AccountId);
            request.AddParameter("device_id", DeviceId);
            request.AddParameter("secret", Secret);

            var response = client.Execute(request).Content;

            return response;
        }
        public static string GetDeviceAuth(string AccountId, string AccessToken)
        {
            var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
            var request = new RestRequest($"/account/api/public/account/{AccountId}/deviceAuth", Method.Post);
            request.AddHeader("Authorization", $"Bearer {AccessToken}");

            var response = client.Execute(request).Content;

            return response;
        }
        public static string GetExchange(string AccessToken)
        {
            var client = new RestClient("https://account-public-service-prod03.ol.epicgames.com");
            var request = new RestRequest("/account/api/oauth/exchange", Method.Get);
            request.AddHeader("Authorization", $"Bearer {AccessToken}");

            var response = client.Execute(request).Content;

            return response;
        }
    }
}
