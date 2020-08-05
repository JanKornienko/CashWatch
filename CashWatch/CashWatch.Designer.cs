namespace Financial_App
{
    partial class CashWatch
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashWatch));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plusButt = new System.Windows.Forms.PictureBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.listTxt = new System.Windows.Forms.TextBox();
            this.incomeButt = new System.Windows.Forms.RadioButton();
            this.outcomeButt = new System.Windows.Forms.RadioButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.catLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plusButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plusButt
            // 
            this.plusButt.BackColor = System.Drawing.Color.Transparent;
            this.plusButt.Image = ((System.Drawing.Image)(resources.GetObject("plusButt.Image")));
            this.plusButt.Location = new System.Drawing.Point(316, 409);
            this.plusButt.Name = "plusButt";
            this.plusButt.Size = new System.Drawing.Size(40, 40);
            this.plusButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plusButt.TabIndex = 1;
            this.plusButt.TabStop = false;
            this.plusButt.Click += new System.EventHandler(this.PlusButt_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumLabel.Location = new System.Drawing.Point(12, 9);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(360, 33);
            this.sumLabel.TabIndex = 0;
            this.sumLabel.Text = "0";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listTxt
            // 
            this.listTxt.BackColor = System.Drawing.Color.White;
            this.listTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.listTxt.Location = new System.Drawing.Point(18, 62);
            this.listTxt.Multiline = true;
            this.listTxt.Name = "listTxt";
            this.listTxt.ReadOnly = true;
            this.listTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listTxt.Size = new System.Drawing.Size(354, 149);
            this.listTxt.TabIndex = 1;
            // 
            // incomeButt
            // 
            this.incomeButt.AutoSize = true;
            this.incomeButt.Checked = true;
            this.incomeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incomeButt.ForeColor = System.Drawing.Color.Green;
            this.incomeButt.Location = new System.Drawing.Point(31, 409);
            this.incomeButt.Name = "incomeButt";
            this.incomeButt.Size = new System.Drawing.Size(97, 32);
            this.incomeButt.TabIndex = 3;
            this.incomeButt.TabStop = true;
            this.incomeButt.Text = "Příjem";
            this.incomeButt.UseVisualStyleBackColor = true;
            this.incomeButt.CheckedChanged += new System.EventHandler(this.IncomeButt_CheckedChanged);
            // 
            // outcomeButt
            // 
            this.outcomeButt.AutoSize = true;
            this.outcomeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outcomeButt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outcomeButt.ForeColor = System.Drawing.Color.Red;
            this.outcomeButt.Location = new System.Drawing.Point(134, 409);
            this.outcomeButt.Name = "outcomeButt";
            this.outcomeButt.Size = new System.Drawing.Size(88, 32);
            this.outcomeButt.TabIndex = 4;
            this.outcomeButt.Text = "Výdaj";
            this.outcomeButt.UseVisualStyleBackColor = true;
            this.outcomeButt.CheckedChanged += new System.EventHandler(this.OutcomeButt_CheckedChanged);
            // 
            // chart
            // 
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            this.chart.Location = new System.Drawing.Point(-1, 217);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Green;
            series11.Name = "Income";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.Red;
            series12.Name = "Outcome";
            series12.YValuesPerPoint = 6;
            this.chart.Series.Add(series11);
            this.chart.Series.Add(series12);
            this.chart.Size = new System.Drawing.Size(373, 186);
            this.chart.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(258, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(15, 46);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 11;
            this.nameLbl.Text = "Jméno";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(106, 46);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(40, 13);
            this.priceLbl.TabIndex = 12;
            this.priceLbl.Text = "Částka";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(292, 46);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(38, 13);
            this.dateLbl.TabIndex = 13;
            this.dateLbl.Text = "Datum";
            // 
            // catLbl
            // 
            this.catLbl.AutoSize = true;
            this.catLbl.Location = new System.Drawing.Point(195, 46);
            this.catLbl.Name = "catLbl";
            this.catLbl.Size = new System.Drawing.Size(52, 13);
            this.catLbl.TabIndex = 14;
            this.catLbl.Text = "Kategorie";
            // 
            // CashWatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.catLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.outcomeButt);
            this.Controls.Add(this.incomeButt);
            this.Controls.Add(this.listTxt);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.plusButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashWatch";
            ((System.ComponentModel.ISupportInitialize)(this.plusButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox plusButt;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox listTxt;
        private System.Windows.Forms.RadioButton incomeButt;
        private System.Windows.Forms.RadioButton outcomeButt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label catLbl;
    }
}

