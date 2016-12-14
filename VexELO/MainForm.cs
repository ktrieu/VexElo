using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VexELO.api;
using VexELO.ranker;

namespace VexELO
{
    public partial class MainForm : Form
    {

        VexDbApi vexDbApi;
        Ranker ranker;

        const string TEST_SKU = "RE-VRC-16-1264";

        public MainForm()
        {
            InitializeComponent();
            vexDbApi = new VexDbApi();
            ranker = new Ranker();
            //init the table
            InitRankingsTable();

        }

        private void InitRankingsTable()
        {
            rankingDataGrid.ColumnCount = 3;
            rankingDataGrid.ReadOnly = true;
            rankingDataGrid.Font = new Font(FontFamily.GenericMonospace, 24);
            rankingDataGrid.Columns[0].Name = "Rank";
            rankingDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rankingDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            rankingDataGrid.Columns[1].Name = "Team Name";
            rankingDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rankingDataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            rankingDataGrid.Columns[2].Name = "Elo";
            rankingDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rankingDataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PopulateRankingTable(string sku)
        {
            ranker.RankMatches(vexDbApi.GetMatchesBySku(sku));
            var rankings = ranker.GetEloRankings();
            if (rankings.Count == 0)
            {
                return;
            }
            rankingDataGrid.Rows.Clear();
            int index = 1;
            foreach (var ranking in rankings)
            {
                rankingDataGrid.Rows.Add(new object[] { index, ranking.Key, (int)ranking.Value });
                index++;
            }
            rankingDataGrid.AutoResizeRows();
        }

        private void rankButton_Click(object sender, EventArgs e)
        {
            if (skuField.Text != null)
            {
                PopulateRankingTable(skuField.Text);
            }
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            //validate teams
            if (ranker.HasRanking(redTeam1.Text) && ranker.HasRanking(redTeam2.Text) &&
                ranker.HasRanking(blueTeam1.Text) && ranker.HasRanking(blueTeam2.Text))
            {
                Tuple<double, double> winChances = ranker.CalcWinChances(new Alliance(redTeam1.Text, redTeam2.Text),
                    new Alliance(blueTeam1.Text, blueTeam2.Text));
                redWinChance.Text = winChances.Item1.ToString("F2") + "%";
                blueWinChance.Text = winChances.Item2.ToString("F2") + "%";
            }
        }
    }
}
