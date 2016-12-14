namespace VexELO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skuFieldLabel = new System.Windows.Forms.Label();
            this.skuField = new System.Windows.Forms.TextBox();
            this.rankButton = new System.Windows.Forms.Button();
            this.rankingDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.redTeam1 = new System.Windows.Forms.TextBox();
            this.redTeam2 = new System.Windows.Forms.TextBox();
            this.blueTeam2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.blueTeam1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.predictButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.redWinChance = new System.Windows.Forms.Label();
            this.blueWinChance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skuFieldLabel
            // 
            this.skuFieldLabel.AutoSize = true;
            this.skuFieldLabel.Location = new System.Drawing.Point(13, 13);
            this.skuFieldLabel.Name = "skuFieldLabel";
            this.skuFieldLabel.Size = new System.Drawing.Size(93, 13);
            this.skuFieldLabel.TabIndex = 0;
            this.skuFieldLabel.Text = "Competition SKU: ";
            // 
            // skuField
            // 
            this.skuField.Location = new System.Drawing.Point(112, 10);
            this.skuField.Name = "skuField";
            this.skuField.Size = new System.Drawing.Size(364, 20);
            this.skuField.TabIndex = 1;
            // 
            // rankButton
            // 
            this.rankButton.Location = new System.Drawing.Point(482, 8);
            this.rankButton.Name = "rankButton";
            this.rankButton.Size = new System.Drawing.Size(99, 23);
            this.rankButton.TabIndex = 2;
            this.rankButton.Text = "Rank";
            this.rankButton.UseVisualStyleBackColor = true;
            this.rankButton.Click += new System.EventHandler(this.rankButton_Click);
            // 
            // rankingDataGrid
            // 
            this.rankingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.rankingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankingDataGrid.Location = new System.Drawing.Point(16, 36);
            this.rankingDataGrid.Name = "rankingDataGrid";
            this.rankingDataGrid.RowHeadersVisible = false;
            this.rankingDataGrid.Size = new System.Drawing.Size(565, 443);
            this.rankingDataGrid.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blueWinChance);
            this.panel1.Controls.Add(this.redWinChance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.predictButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.blueTeam1);
            this.panel1.Controls.Add(this.blueTeam2);
            this.panel1.Controls.Add(this.redTeam2);
            this.panel1.Controls.Add(this.redTeam1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 119);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blue Alliance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red Alliance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team 2";
            // 
            // redTeam1
            // 
            this.redTeam1.Location = new System.Drawing.Point(3, 50);
            this.redTeam1.Name = "redTeam1";
            this.redTeam1.Size = new System.Drawing.Size(100, 20);
            this.redTeam1.TabIndex = 4;
            // 
            // redTeam2
            // 
            this.redTeam2.Location = new System.Drawing.Point(109, 50);
            this.redTeam2.Name = "redTeam2";
            this.redTeam2.Size = new System.Drawing.Size(100, 20);
            this.redTeam2.TabIndex = 5;
            // 
            // blueTeam2
            // 
            this.blueTeam2.Location = new System.Drawing.Point(460, 50);
            this.blueTeam2.Name = "blueTeam2";
            this.blueTeam2.Size = new System.Drawing.Size(100, 20);
            this.blueTeam2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team 2";
            // 
            // blueTeam1
            // 
            this.blueTeam1.Location = new System.Drawing.Point(354, 50);
            this.blueTeam1.Name = "blueTeam1";
            this.blueTeam1.Size = new System.Drawing.Size(100, 20);
            this.blueTeam1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team 1";
            // 
            // predictButton
            // 
            this.predictButton.Location = new System.Drawing.Point(215, 48);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(132, 23);
            this.predictButton.TabIndex = 10;
            this.predictButton.Text = "Predict";
            this.predictButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Win Probability Prediction";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redWinChance
            // 
            this.redWinChance.AutoSize = true;
            this.redWinChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redWinChance.ForeColor = System.Drawing.Color.Red;
            this.redWinChance.Location = new System.Drawing.Point(3, 73);
            this.redWinChance.Name = "redWinChance";
            this.redWinChance.Size = new System.Drawing.Size(63, 37);
            this.redWinChance.TabIndex = 12;
            this.redWinChance.Text = "0%";
            // 
            // blueWinChance
            // 
            this.blueWinChance.AutoSize = true;
            this.blueWinChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueWinChance.ForeColor = System.Drawing.Color.Blue;
            this.blueWinChance.Location = new System.Drawing.Point(499, 73);
            this.blueWinChance.Name = "blueWinChance";
            this.blueWinChance.Size = new System.Drawing.Size(63, 37);
            this.blueWinChance.TabIndex = 13;
            this.blueWinChance.Text = "0%";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(593, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rankingDataGrid);
            this.Controls.Add(this.rankButton);
            this.Controls.Add(this.skuField);
            this.Controls.Add(this.skuFieldLabel);
            this.Name = "MainForm";
            this.Text = "VexELO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skuFieldLabel;
        private System.Windows.Forms.TextBox skuField;
        private System.Windows.Forms.Button rankButton;
        private System.Windows.Forms.DataGridView rankingDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox blueTeam1;
        private System.Windows.Forms.TextBox blueTeam2;
        private System.Windows.Forms.TextBox redTeam2;
        private System.Windows.Forms.TextBox redTeam1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blueWinChance;
        private System.Windows.Forms.Label redWinChance;
    }
}

