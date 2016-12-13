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
            rankingDataGrid.ColumnCount = 2;
            rankingDataGrid.ReadOnly = true;
            rankingDataGrid.Font = new Font(FontFamily.GenericMonospace, 32);
            rankingDataGrid.Columns[0].Name = "Team Name";
            rankingDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rankingDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            rankingDataGrid.Columns[1].Name = "Elo Rating";
            rankingDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rankingDataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            foreach (var ranking in rankings)
            {
                rankingDataGrid.Rows.Add(new object[] { ranking.Key, (int)ranking.Value });
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
    }
}
