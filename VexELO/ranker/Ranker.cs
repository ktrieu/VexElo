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
            foreach (Match match in matches)
            {
                RankMatch(match);
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
            CheckTeamExists(match.AllianceRed.TeamCode1);
            CheckTeamExists(match.AllianceRed.TeamCode2);
            CheckTeamExists(match.AllianceBlue.TeamCode1);
            CheckTeamExists(match.AllianceBlue.TeamCode2);
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
            bool redWins;
            if (match.ScoreRed > match.ScoreBlue)
            {
                //red wins
                redWins = true;
                redActual = 1;
                blueActual = 0;
            }
            else
            {
                //blue wins
                redWins = false;
                redActual = 0;
                blueActual = 1;
            }
            //calculate adjustment factor based on win margin
            double winMarginAdjust = CalcWinMarginAdjust(match.ScoreRed, match.ScoreBlue);
            //calculate changes in elo
            double redEloChange = winMarginAdjust * K_FACTOR * (redActual - redExpected);
            double blueEloChange = winMarginAdjust * K_FACTOR * (blueActual- blueExpected);
            //apply to each alliance
            ApplyEloChange(match.AllianceRed, redEloChange, redWins);
            ApplyEloChange(match.AllianceBlue, blueEloChange, !redWins);
        }

        private double CalcAllianceElo(Alliance alliance)
        {
            return teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2];
        }

        private void ApplyEloChange(Alliance alliance, double change, bool winningAlliance)
        {
            double eloPercent1 = 0;
            double eloPercent2 = 0;
            if (winningAlliance)
            {
                //apply changes based on percentage of total alliance elo
                eloPercent1 = teamElos[alliance.TeamCode1] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
                eloPercent2 = teamElos[alliance.TeamCode2] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
            }
            else
            {
                //invert percentages in a loss to punish bad performers
                eloPercent2 = teamElos[alliance.TeamCode1] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
                eloPercent1 = teamElos[alliance.TeamCode2] / (teamElos[alliance.TeamCode1] + teamElos[alliance.TeamCode2]);
            }
            teamElos[alliance.TeamCode1] += change * eloPercent1;
            teamElos[alliance.TeamCode2] += change * eloPercent2;
        }

        private double CalcWinMarginAdjust(int redScore, int blueScore)
        {
            int margin = Math.Abs(redScore - blueScore);
            return Math.Log(margin + 1);    
        }

        private void CheckTeamExists(string teamCode)
        {
            if (!teamElos.ContainsKey(teamCode))
            {
                //1500 is the default starting elo value
                teamElos.Add(teamCode, 1500);
            }
        }



    }
}
