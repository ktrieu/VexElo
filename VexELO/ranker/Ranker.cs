using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VexELO.ranker
{
    class Ranker
    {

        Dictionary<string, double> teamElos;

        const int K_FACTOR = 16;

        public Ranker()
        {
            teamElos = new Dictionary<string, double>();
        }

        public void RankMatches(IList<Match> matches)
        {
            if (matches == null)
            {
                return;
            }
            teamElos.Clear();
            foreach (Match match in matches)
            {
                if (match.Complete)
                {
                    RankMatch(match);
                }
            }
        }

        public IList<KeyValuePair<string, double>> GetEloRankings()
        {
            List<KeyValuePair<string, double>> rankings = teamElos.ToList();
            rankings.Sort((pair1, pair2) =>
            {
                return pair2.Value.CompareTo(pair1.Value);
            });
            return rankings;
        }

        public void RankMatch(Match match)
        {
            //add any teams in the match if they're not present
            AddTeamIfNotPresent(match.AllianceRed.TeamCode1);
            AddTeamIfNotPresent(match.AllianceRed.TeamCode2);
            AddTeamIfNotPresent(match.AllianceBlue.TeamCode1);
            AddTeamIfNotPresent(match.AllianceBlue.TeamCode2);
            //get elos for both alliances
            double redElo = CalcAllianceElo(match.AllianceRed);
            double blueElo = CalcAllianceElo(match.AllianceBlue);
            double redEloTransformed = Math.Pow(10, redElo / 400);
            double blueEloTransformed = Math.Pow(10, blueElo / 400);
            //get expected points
            double redExpected = redEloTransformed / (redEloTransformed + blueEloTransformed);
            double blueExpected = blueEloTransformed / (redEloTransformed + blueEloTransformed);
            //get actual points
            double redActual;
            double blueActual;
            if (match.ScoreRed > match.ScoreBlue)
            {
                //red wins
                redActual = 1;
                blueActual = 0;
            }
            else
            {
                //blue wins
                redActual = 0;
                blueActual = 1;
            }
            //calculate adjustment factor based on win margin
            double winMarginAdjust = CalcWinMarginAdjust(match.ScoreRed, match.ScoreBlue);
            //calculate changes in elo
            double redEloChange = winMarginAdjust * K_FACTOR * (redActual - redExpected);
            double blueEloChange = winMarginAdjust * K_FACTOR * (blueActual- blueExpected);
            //apply to each alliance
            ApplyEloChange(match.AllianceRed, redEloChange);
            ApplyEloChange(match.AllianceBlue, blueEloChange);
        }

        public Tuple<double, double> CalcWinChances(Alliance red, Alliance blue)
        {
            //get elos for both alliances
            double redElo = CalcAllianceElo(red);
            double blueElo = CalcAllianceElo(blue);
            double redEloTransformed = Math.Pow(10, redElo / 400);
            double blueEloTransformed = Math.Pow(10, blueElo / 400);
            //get expected points
            double redExpected = redEloTransformed / (redEloTransformed + blueEloTransformed);
            double blueExpected = blueEloTransformed / (redEloTransformed + blueEloTransformed);
            return new Tuple<double, double>(redExpected * 100, blueExpected * 100);
        }

        public bool HasRanking(string teamCode)
        {
            return teamElos.ContainsKey(teamCode);
        }

        private double CalcAllianceElo(Alliance alliance)
        {
            return teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2];
        }

        private void ApplyEloChange(Alliance alliance, double change)
        {
            //apply changes based on percentage of total alliance elo
            double eloPercent1 = teamElos[alliance.TeamCode1] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
            double eloPercent2 = teamElos[alliance.TeamCode2] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
            teamElos[alliance.TeamCode1] += change * eloPercent1;
            teamElos[alliance.TeamCode2] += change * eloPercent2;
        }

        private double CalcWinMarginAdjust(int redScore, int blueScore)
        {
            int margin = Math.Abs(redScore - blueScore);
            return Math.Log(margin + 1);    
        }

        private void AddTeamIfNotPresent(string teamCode)
        {
            if (!teamElos.ContainsKey(teamCode))
            {
                //1500 is the default starting elo value
                teamElos.Add(teamCode, 1500);
            }
        }



    }
}
