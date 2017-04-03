using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    static class Recherche
    {
        const String API_KEY = "13A9BB28EB38235A15B9FA641B348200";

         static public dynamic RequestFriends(String SteamID) //retrn a json of the list of friends of an id given
        {
            string str = "http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key=" + API_KEY + "&steamid=" + SteamID + "&relationship=friend&format=json";
            WebRequest request = WebRequest.Create(str);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            
            string reponse = reader.ReadToEnd();
            string json = Regex.Replace(reponse, @"\t|\n|\r", "");

            //IEnumerable<RootObject> items =  JsonConvert.DeserializeObject<IEnumerable<RootObject>>(json);

            dynamic j = JsonConvert.DeserializeObject(json);

            reader.Close();
            response.Close();
            

            return j;

        }
        static public string RequestInformation(String SteamID) //retrn a json of the inbformation of the Steam id
        {
            String str = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + API_KEY + "&steamids=" + SteamID;

            WebRequest request = WebRequest.Create(str);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string reponse = reader.ReadToEnd();
            

            reader.Close();
            response.Close();
            

            return reponse;
        }
    }
}
