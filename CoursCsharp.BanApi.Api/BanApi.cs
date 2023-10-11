using CoursCsharp.BanApi.Api.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CoursCsharp.BanApi.Api
{
    /// <summary>
    /// Classe d'appel à l'API ba
    /// </summary>
    public class BanApi
    {
        public BanResult Search(string query)
        {
            BanResult result = null;

            try
            {
                // Encode la requête de l'utilisateur pour la requête HTTP
                string queryParams = HttpUtility.UrlEncode(query);

                // Url de l'api
                string url = $"https://api-adresse.data.gouv.fr/search/?q={queryParams}";

                // On prépare la requête
                HttpWebRequest request = WebRequest.CreateHttp(url);
                request.Method = "GET";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    string resultText = null;
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        resultText = reader.ReadToEnd();
                    }

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        result = JToken.Parse(resultText).ToObject<BanResult>();
                    }
                    else
                    {
                        throw new Exception(resultText + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

    }
}
