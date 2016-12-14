using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace VexELO.api
{
    class VexDbApi
    {
        WebClient client;

        const string MATCH_API_URL = "https://api.vexdb.io/v1/get_matches";

        public VexDbApi()
        {
            client = new WebClient();
        }

        public IList<Match> GetMatchesBySku(string sku)
        {
            List<Match> matches = new List<Match>();
            string response = Encoding.UTF8.GetString(client.DownloadData(MATCH_API_URL + string.Format("?sku={0}&round=2", sku)));
            JObject o = JObject.Parse(response);
            if (!(bool)o["status"])
            {
                return null;
            }
            JArray matchArray = (JArray)o["result"];
            foreach (JObject match in matchArray)
            {
                matches.Add(ParseMatchJson(match));
            }
            return matches;
        }

        private Match ParseMatchJson(JObject json)
        {
            Match match = new Match();
            if ((int)json["scored"] == 0)
            {
                match.Complete = false;
                return match;
            }
            else
            {
                match.Complete = true;
                match.ScoreRed = (int)json["redscore"];
                match.ScoreBlue = (int)json["bluescore"];
                Alliance allianceRed = new Alliance();
                //get red teams
                List<string> redTeams = new List<string>{ (string)json["red1"], (string)json["red2"], (string)json["red3"] };
                //remove whoever's sitting out
                redTeams.Remove((string)json["redsit"]);
                //assign to the alliance
                allianceRed.TeamCode1 = redTeams[0];
                allianceRed.TeamCode2 = redTeams[1];
                match.AllianceRed = allianceRed;
                //repeat for blue
                Alliance allianceBlue = new Alliance();
                List<string> blueTeams = new List<string> { (string)json["blue1"], (string)json["blue2"], (string)json["blue3"] };
                redTeams.Remove((string)json["bluesit"]);
                allianceBlue.TeamCode1 = blueTeams[0];
                allianceBlue.TeamCode2 = blueTeams[1];
                match.AllianceBlue = allianceBlue;
                return match;
            }
        }
    }
}
