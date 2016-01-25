using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign.OAuth
{
    public static class EchoSignOAuth
    {
        public static string GenerateScope(Scope scope, Modifier modifier)
        {
            return string.Format("{0}:{1}", scope.ToString(), modifier.ToString());
        }
        public static string GenerateAuthorizationRequest(string clientID, string callBackUrl, string state, params string[] scopes)
        {
            if(scopes == null) { scopes = new string[0]; }
            return string.Format("https://secure.na1.echosign.com/public/oauth?client_id={0}&scope={1}&redirect_uri={2}&response_type=code&state={3}", clientID, string.Join("+", scopes), callBackUrl, state);
        }

        /// <summary>
        /// Gets an access token using the code provided via the redirect
        /// </summary>
        public static AuthorizationInfo GetAccessToken(string clientID, string clientSecret, string callBackUrl, string api_access_point, string code, string state)
        {
            WebClient webClient = new WebClient();
            byte[] response = webClient.UploadValues(api_access_point.TrimEnd('/') + "/oauth/token",
                                new NameValueCollection() {
                                                { "client_id", clientID },
                                                { "client_secret", clientSecret },
                                                { "grant_type", "authorization_code"},
                                                { "redirect_uri", callBackUrl},
                                                { "code", code}
                                });
            string json = webClient.Encoding.GetString(response);

            AuthorizationInfo result = JsonConvert.DeserializeObject<AuthorizationInfo>(json);
            result.api_endpoint = api_access_point;
            result.state = state;
            result.expiration_date = DateTime.UtcNow.AddSeconds(result.expires_in);
            result.raw_response = json;
            return result;
        }
        /// <summary>
        /// Gets an access token using the code provided via the redirect
        /// </summary>
        public static async Task<AuthorizationInfo> GetAccessTokenAsync(string clientID, string clientSecret, string callBackUrl, string api_access_point, string code, string state)
        {
            WebClient webClient = new WebClient();
            byte[] response = await webClient.UploadValuesTaskAsync(api_access_point.TrimEnd('/') + "/oauth/token",
                                new NameValueCollection() {
                                                { "client_id", clientID },
                                                { "client_secret", clientSecret },
                                                { "grant_type", "authorization_code"},
                                                { "redirect_uri", callBackUrl},
                                                { "code", code}
                                });
            string json = webClient.Encoding.GetString(response);

            AuthorizationInfo result = JsonConvert.DeserializeObject<AuthorizationInfo>(json);
            result.api_endpoint = api_access_point;
            result.state = state;
            result.expiration_date = DateTime.UtcNow.AddSeconds(result.expires_in);
            result.raw_response = json;
            return result;
        }

        /// <summary>
        /// Gets an access token using a refresh token
        /// </summary>
        public static TokenInfo RefreshAccessToken(string clientID, string clientSecret, string api_access_point, string refresh_token)
        {
            WebClient webClient = new WebClient();
            byte[] response = webClient.UploadValues(api_access_point.TrimEnd('/') + "/oauth/refresh",
                                new NameValueCollection() {
                                                { "client_id", clientID },
                                                { "client_secret", clientSecret },
                                                { "grant_type", "refresh_token"},
                                                { "refresh_token", refresh_token}
                                });
            string json = webClient.Encoding.GetString(response);

            TokenInfo result = JsonConvert.DeserializeObject<TokenInfo>(json);
            result.expiration_date = DateTime.UtcNow.AddSeconds(result.expires_in);
            result.raw_response = json;
            return result;
        }

        /// <summary>
        /// Gets an access token using a refresh token
        /// </summary>
        public static async Task<TokenInfo> RefreshAccessTokenAsync(string clientID, string clientSecret, string api_access_point, string refresh_token)
        {
            WebClient webClient = new WebClient();
            byte[] response = await webClient.UploadValuesTaskAsync(api_access_point.TrimEnd('/') + "/oauth/refresh",
                                new NameValueCollection() {
                                                { "client_id", clientID },
                                                { "client_secret", clientSecret },
                                                { "grant_type", "refresh_token"},
                                                { "refresh_token", refresh_token}
                                });
            string json = webClient.Encoding.GetString(response);

            TokenInfo result = JsonConvert.DeserializeObject<TokenInfo>(json);
            result.expiration_date = DateTime.UtcNow.AddSeconds(result.expires_in);
            result.raw_response = json;
            return result;
        }
    }
}
