namespace Medical_Centre
{
    partial class Prescriptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            this.label12 = new System.Windows.Forms.Label();
            this.AdmPanBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.MedTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.DocIdCb = new System.Windows.Forms.ComboBox();
            this.DocNameTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PatIdCb = new System.Windows.Forms.ComboBox();
            this.TestIdCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TestNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.PrescSumTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrescriptionDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PrintBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.AdmPanPb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPanPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(69, 629);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 46);
            this.label12.TabIndex = 13;
            this.label12.Text = "Выйти\r\nс аккаунта\r\n";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // AdmPanBtn
            // 
            this.AdmPanBtn.AutoSize = true;
            this.AdmPanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdmPanBtn.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmPanBtn.ForeColor = System.Drawing.Color.Black;
            this.AdmPanBtn.Location = new System.Drawing.Point(70, 585);
            this.AdmPanBtn.Name = "AdmPanBtn";
            this.AdmPanBtn.Size = new System.Drawing.Size(113, 34);
            this.AdmPanBtn.TabIndex = 11;
            this.AdmPanBtn.Text = "Выйти в \r\nАдмин панель";
            this.AdmPanBtn.Click += new System.EventHandler(this.AdmPanBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.AdmPanPb);
            this.panel1.Controls.Add(this.AdmPanBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 694);
            this.panel1.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label17.Location = new System.Drawing.Point(248, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 21);
            this.label17.TabIndex = 66;
            this.label17.Text = "Медикоменты";
            // 
            // MedTb
            // 
            this.MedTb.Location = new System.Drawing.Point(252, 284);
            this.MedTb.Multiline = true;
            this.MedTb.Name = "MedTb";
            this.MedTb.Size = new System.Drawing.Size(190, 67);
            this.MedTb.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label16.Location = new System.Drawing.Point(338, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 21);
            this.label16.TabIndex = 64;
            this.label16.Text = "Имя Пациента";
            // 
            // PatNameTb
            // 
            this.PatNameTb.Enabled = false;
            this.PatNameTb.Location = new System.Drawing.Point(342, 170);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(190, 27);
            this.PatNameTb.TabIndex = 63;
            // 
            // DocIdCb
            // 
            this.DocIdCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocIdCb.FormattingEnabled = true;
            this.DocIdCb.Location = new System.Drawing.Point(252, 115);
            this.DocIdCb.Name = "DocIdCb";
            this.DocIdCb.Size = new System.Drawing.Size(84, 28);
            this.DocIdCb.TabIndex = 58;
            this.DocIdCb.Text = "Doctor Id";
            this.DocIdCb.SelectionChangeCommitted += new System.EventHandler(this.DocIdCb_SelectionChangeCommitted);
            // 
            // DocNameTb
            // 
            this.DocNameTb.Enabled = false;
            this.DocNameTb.Location = new System.Drawing.Point(342, 118);
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(190, 27);
            this.DocNameTb.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label13.Location = new System.Drawing.Point(338, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 21);
            this.label13.TabIndex = 52;
            this.label13.Text = "Имя Доктора";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(199, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 10);
            this.panel2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Averia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(570, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 55;
            this.label1.Text = "HealthHorizon";
            // 
            // PatIdCb
            // 
            this.PatIdCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatIdCb.FormattingEnabled = true;
            this.PatIdCb.Location = new System.Drawing.Point(252, 168);
            this.PatIdCb.Name = "PatIdCb";
            this.PatIdCb.Size = new System.Drawing.Size(84, 28);
            this.PatIdCb.TabIndex = 74;
            this.PatIdCb.Text = "Patient Id";
            this.PatIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatIdCb_SelectionChangeCommitted);
            // 
            // TestIdCb
            // 
            this.TestIdCb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestIdCb.FormattingEnabled = true;
            this.TestIdCb.Location = new System.Drawing.Point(252, 220);
            this.TestIdCb.Name = "TestIdCb";
            this.TestIdCb.Size = new System.Drawing.Size(84, 28);
            this.TestIdCb.TabIndex = 75;
            this.TestIdCb.Text = "Test Id";
            this.TestIdCb.SelectionChangeCommitted += new System.EventHandler(this.TestIdCb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(342, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "Тест";
            // 
            // TestNameTb
            // 
            this.TestNameTb.Enabled = false;
            this.TestNameTb.Location = new System.Drawing.Point(342, 222);
            this.TestNameTb.Name = "TestNameTb";
            this.TestNameTb.Size = new System.Drawing.Size(190, 27);
            this.TestNameTb.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(448, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 79;
            this.label4.Text = "Стоимость";
            // 
            // CostTb
            // 
            this.CostTb.Enabled = false;
            this.CostTb.Location = new System.Drawing.Point(452, 284);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(114, 27);
            this.CostTb.TabIndex = 78;
            // 
            // PrescSumTxt
            // 
            this.PrescSumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrescSumTxt.Enabled = false;
            this.PrescSumTxt.Location = new System.Drawing.Point(635, 115);
            this.PrescSumTxt.Name = "PrescSumTxt";
            this.PrescSumTxt.Size = new System.Drawing.Size(500, 300);
            this.PrescSumTxt.TabIndex = 80;
            this.PrescSumTxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(799, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Назначения Доктора";
            // 
            // PrescriptionDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PrescriptionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PrescriptionDGV.BackgroundColor = System.Drawing.Color.White;
            this.PrescriptionDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrescriptionDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PrescriptionDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrescriptionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PrescriptionDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrescriptionDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrescriptionDGV.EnableHeadersVisualStyles = false;
            this.PrescriptionDGV.GridColor = System.Drawing.Color.Black;
            this.PrescriptionDGV.Location = new System.Drawing.Point(209, 466);
            this.PrescriptionDGV.Name = "PrescriptionDGV";
            this.PrescriptionDGV.RowHeadersVisible = false;
            this.PrescriptionDGV.RowTemplate.Height = 24;
            this.PrescriptionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrescriptionDGV.Size = new System.Drawing.Size(938, 216);
            this.PrescriptionDGV.TabIndex = 83;
            this.PrescriptionDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PrescriptionDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PrescriptionDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.PrescriptionDGV.ThemeStyle.ReadOnly = false;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Green;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.Height = 24;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.PrescriptionDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PrescriptionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrescriptionDGV_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(248, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 32);
            this.panel3.TabIndex = 89;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 32);
            this.panel4.TabIndex = 90;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Medical_Centre.Properties.Resources.reject11;
            this.button1.Location = new System.Drawing.Point(925, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 86;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Image = global::Medical_Centre.Properties.Resources.free_icon_refresh_2805355;
            this.ClearBtn.Location = new System.Drawing.Point(527, 362);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(32, 32);
            this.ClearBtn.TabIndex = 88;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.ActiveBorderThickness = 1;
            this.DelBtn.ActiveCornerRadius = 20;
            this.DelBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DelBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.BackColor = System.Drawing.Color.White;
            this.DelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelBtn.BackgroundImage")));
            this.DelBtn.ButtonText = "Удалить";
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DelBtn.IdleBorderThickness = 1;
            this.DelBtn.IdleCornerRadius = 20;
            this.DelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.DelBtn.IdleForecolor = System.Drawing.Color.White;
            this.DelBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.DelBtn.Location = new System.Drawing.Point(410, 358);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(113, 44);
            this.DelBtn.TabIndex = 87;
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.ActiveBorderThickness = 1;
            this.PrintBtn.ActiveCornerRadius = 20;
            this.PrintBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrintBtn.ActiveForecolor = System.Drawing.Color.White;
            this.PrintBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrintBtn.BackColor = System.Drawing.Color.White;
            this.PrintBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintBtn.BackgroundImage")));
            this.PrintBtn.ButtonText = "Распечатать";
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.PrintBtn.IdleBorderThickness = 1;
            this.PrintBtn.IdleCornerRadius = 20;
            this.PrintBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.PrintBtn.IdleForecolor = System.Drawing.Color.White;
            this.PrintBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.PrintBtn.Location = new System.Drawing.Point(841, 415);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(113, 44);
            this.PrintBtn.TabIndex = 84;
            this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Добавить";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.Black;
            this.AddBtn.IdleForecolor = System.Drawing.Color.White;
            this.AddBtn.IdleLineColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(289, 358);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(113, 44);
            this.AddBtn.TabIndex = 69;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Medical_Centre.Properties.Resources.logout;
            this.pictureBox11.Location = new System.Drawing.Point(26, 634);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(39, 41);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            // 
            // AdmPanPb
            // 
            this.AdmPanPb.Image = global::Medical_Centre.Properties.Resources.logout;
            this.AdmPanPb.Location = new System.Drawing.Point(26, 579);
            this.AdmPanPb.Name = "AdmPanPb";
            this.AdmPanPb.Size = new System.Drawing.Size(39, 44);
            this.AdmPanPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdmPanPb.TabIndex = 12;
            this.AdmPanPb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Centre.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(56, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Medical_Centre.Properties.Resources._112;
            this.button2.Location = new System.Drawing.Point(892, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 90;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.PrescriptionDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrescSumTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestNameTb);
            this.Controls.Add(this.TestIdCb);
            this.Controls.Add(this.PatIdCb);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MedTb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.DocIdCb);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescriptions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPanPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox AdmPanPb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label AdmPanBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MedTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.ComboBox DocIdCb;
        private System.Windows.Forms.TextBox DocNameTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PatIdCb;
        private System.Windows.Forms.ComboBox TestIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TestNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostTb;
        private System.Windows.Forms.RichTextBox PrescSumTxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView PrescriptionDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 DelBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}