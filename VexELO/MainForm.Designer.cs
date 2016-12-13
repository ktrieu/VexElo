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
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGrid)).BeginInit();
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
            // 
            // rankingDataGrid
            // 
            this.rankingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.rankingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankingDataGrid.Location = new System.Drawing.Point(16, 36);
            this.rankingDataGrid.Name = "rankingDataGrid";
            this.rankingDataGrid.Size = new System.Drawing.Size(565, 443);
            this.rankingDataGrid.TabIndex = 3;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(593, 491);
            this.Controls.Add(this.rankingDataGrid);
            this.Controls.Add(this.rankButton);
            this.Controls.Add(this.skuField);
            this.Controls.Add(this.skuFieldLabel);
            this.Name = "MainForm";
            this.Text = "VexELO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skuFieldLabel;
        private System.Windows.Forms.TextBox skuField;
        private System.Windows.Forms.Button rankButton;
        private System.Windows.Forms.DataGridView rankingDataGrid;
    }
}

