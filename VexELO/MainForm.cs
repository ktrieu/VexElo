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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ranker.RankMatches(vexDbApi.GetMatchesBySku("RE-VRC-16-1264"));
            var rankings = ranker.GetEloRankings();
        }
    }
}
