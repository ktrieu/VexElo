using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VexELO.api;
using VexELO.ranker;

namespace VexELO_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            double brierScore = 0;
            Console.Write("Enter SKU: ");
            string sku = Console.ReadLine();
            VexDbApi vexDbApi = new VexDbApi();
            Ranker ranker = new Ranker();
            IList<Match> matches = vexDbApi.GetMatchesBySku(sku);
            foreach (var match in matches)
            {
                ranker.RankMatch(match);
                var winChance = ranker.CalcWinChances(match.AllianceRed, match.AllianceBlue);
                //calculate brier score
                int actual = match.ScoreRed > match.ScoreBlue ? 1 : 0;
                brierScore += Math.Pow((winChance.Item1 / 100) - actual, 2);
            }
            brierScore /= matches.Count;
            Console.WriteLine("Brier score is: {0}", brierScore);
            Console.ReadKey(true);
        }
    }
}
