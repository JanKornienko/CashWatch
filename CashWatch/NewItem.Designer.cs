namespace Financial_App
{
    partial class NewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            this.incomeButt = new System.Windows.Forms.RadioButton();
            this.outcomeButt = new System.Windows.Forms.RadioButton();
            this.sumTxt = new System.Windows.Forms.TextBox();
            this.plusButt = new System.Windows.Forms.PictureBox();
            this.minusButt = new System.Windows.Forms.PictureBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cattLabel = new System.Windows.Forms.Label();
            this.addButt = new System.Windows.Forms.PictureBox();
            this.backButt = new System.Windows.Forms.PictureBox();
            this.catButt = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.plusButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catButt)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeButt
            // 
            this.incomeButt.AutoSize = true;
            this.incomeButt.BackColor = System.Drawing.Color.Transparent;
            this.incomeButt.Checked = true;
            this.incomeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incomeButt.ForeColor = System.Drawing.Color.Green;
            this.incomeButt.Location = new System.Drawing.Point(31, 409);
            this.incomeButt.Name = "incomeButt";
            this.incomeButt.Size = new System.Drawing.Size(97, 32);
            this.incomeButt.TabIndex = 0;
            this.incomeButt.TabStop = true;
            this.incomeButt.Text = "Příjem";
            this.incomeButt.UseVisualStyleBackColor = false;
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
            this.outcomeButt.TabIndex = 1;
            this.outcomeButt.Text = "Výdaj";
            this.outcomeButt.UseVisualStyleBackColor = true;
            // 
            // sumTxt
            // 
            this.sumTxt.BackColor = System.Drawing.Color.White;
            this.sumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sumTxt.Location = new System.Drawing.Point(153, 154);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.Size = new System.Drawing.Size(203, 27);
            this.sumTxt.TabIndex = 2;
            this.sumTxt.Text = "0";
            this.sumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusButt
            // 
            this.plusButt.Image = ((System.Drawing.Image)(resources.GetObject("plusButt.Image")));
            this.plusButt.Location = new System.Drawing.Point(306, 211);
            this.plusButt.Name = "plusButt";
            this.plusButt.Size = new System.Drawing.Size(50, 50);
            this.plusButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plusButt.TabIndex = 3;
            this.plusButt.TabStop = false;
            this.plusButt.Click += new System.EventHandler(this.plusButt_Click);
            // 
            // minusButt
            // 
            this.minusButt.Image = ((System.Drawing.Image)(resources.GetObject("minusButt.Image")));
            this.minusButt.Location = new System.Drawing.Point(153, 211);
            this.minusButt.Name = "minusButt";
            this.minusButt.Size = new System.Drawing.Size(50, 50);
            this.minusButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minusButt.TabIndex = 4;
            this.minusButt.TabStop = false;
            this.minusButt.Click += new System.EventHandler(this.minusButt_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryBox.ItemHeight = 21;
            this.categoryBox.Location = new System.Drawing.Point(153, 302);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(203, 29);
            this.categoryBox.TabIndex = 5;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTxt.Location = new System.Drawing.Point(153, 64);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(203, 27);
            this.nameTxt.TabIndex = 8;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(26, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 28);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Název:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(26, 154);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 28);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Cena:";
            // 
            // cattLabel
            // 
            this.cattLabel.AutoSize = true;
            this.cattLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cattLabel.Location = new System.Drawing.Point(26, 300);
            this.cattLabel.Name = "cattLabel";
            this.cattLabel.Size = new System.Drawing.Size(121, 28);
            this.cattLabel.TabIndex = 11;
            this.cattLabel.Text = "Kategorie:";
            // 
            // addButt
            // 
            this.addButt.BackColor = System.Drawing.Color.Transparent;
            this.addButt.Image = ((System.Drawing.Image)(resources.GetObject("addButt.Image")));
            this.addButt.Location = new System.Drawing.Point(316, 409);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(40, 40);
            this.addButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButt.TabIndex = 12;
            this.addButt.TabStop = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // backButt
            // 
            this.backButt.BackColor = System.Drawing.Color.Transparent;
            this.backButt.Image = ((System.Drawing.Image)(resources.GetObject("backButt.Image")));
            this.backButt.Location = new System.Drawing.Point(258, 409);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(40, 40);
            this.backButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButt.TabIndex = 13;
            this.backButt.TabStop = false;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // catButt
            // 
            this.catButt.BackColor = System.Drawing.Color.Transparent;
            this.catButt.Image = ((System.Drawing.Image)(resources.GetObject("catButt.Image")));
            this.catButt.Location = new System.Drawing.Point(316, 337);
            this.catButt.Name = "catButt";
            this.catButt.Size = new System.Drawing.Size(40, 40);
            this.catButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catButt.TabIndex = 14;
            this.catButt.TabStop = false;
            this.catButt.Click += new System.EventHandler(this.catButt_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 461);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // NewItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.catButt);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.cattLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.minusButt);
            this.Controls.Add(this.plusButt);
            this.Controls.Add(this.sumTxt);
            this.Controls.Add(this.outcomeButt);
            this.Controls.Add(this.incomeButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CashWatch";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NewItem_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.plusButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton incomeButt;
        private System.Windows.Forms.RadioButton outcomeButt;
        private System.Windows.Forms.TextBox sumTxt;
        private System.Windows.Forms.PictureBox plusButt;
        private System.Windows.Forms.PictureBox minusButt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label cattLabel;
        private System.Windows.Forms.PictureBox addButt;
        private System.Windows.Forms.PictureBox backButt;
        private System.Windows.Forms.PictureBox catButt;
        private System.Windows.Forms.Splitter splitter1;
    }
}