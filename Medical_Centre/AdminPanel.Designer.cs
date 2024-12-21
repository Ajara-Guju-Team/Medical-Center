namespace Medical_Centre
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecepLbl = new System.Windows.Forms.Label();
            this.LabLbl = new System.Windows.Forms.Label();
            this.DoctorsLbl = new System.Windows.Forms.Label();
            this.PatLbl = new System.Windows.Forms.Label();
            this.PrescLbl = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 75);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "HealthHorizon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(104, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Админская Панель";
            // 
            // RecepLbl
            // 
            this.RecepLbl.AutoSize = true;
            this.RecepLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecepLbl.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecepLbl.ForeColor = System.Drawing.Color.Black;
            this.RecepLbl.Location = new System.Drawing.Point(161, 387);
            this.RecepLbl.Name = "RecepLbl";
            this.RecepLbl.Size = new System.Drawing.Size(103, 23);
            this.RecepLbl.TabIndex = 19;
            this.RecepLbl.Text = "Ресепшен";
            this.RecepLbl.Click += new System.EventHandler(this.RecepLbl_Click);
            // 
            // LabLbl
            // 
            this.LabLbl.AutoSize = true;
            this.LabLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabLbl.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLbl.ForeColor = System.Drawing.Color.Black;
            this.LabLbl.Location = new System.Drawing.Point(161, 326);
            this.LabLbl.Name = "LabLbl";
            this.LabLbl.Size = new System.Drawing.Size(132, 23);
            this.LabLbl.TabIndex = 17;
            this.LabLbl.Text = "Лабаротория";
            this.LabLbl.Click += new System.EventHandler(this.LabLbl_Click);
            // 
            // DoctorsLbl
            // 
            this.DoctorsLbl.AutoSize = true;
            this.DoctorsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorsLbl.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsLbl.ForeColor = System.Drawing.Color.Black;
            this.DoctorsLbl.Location = new System.Drawing.Point(161, 262);
            this.DoctorsLbl.Name = "DoctorsLbl";
            this.DoctorsLbl.Size = new System.Drawing.Size(88, 23);
            this.DoctorsLbl.TabIndex = 15;
            this.DoctorsLbl.Text = "Доктора";
            this.DoctorsLbl.Click += new System.EventHandler(this.DoctorsLbl_Click);
            // 
            // PatLbl
            // 
            this.PatLbl.AutoSize = true;
            this.PatLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatLbl.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatLbl.ForeColor = System.Drawing.Color.Black;
            this.PatLbl.Location = new System.Drawing.Point(161, 208);
            this.PatLbl.Name = "PatLbl";
            this.PatLbl.Size = new System.Drawing.Size(103, 23);
            this.PatLbl.TabIndex = 13;
            this.PatLbl.Text = "Пациенты";
            this.PatLbl.Click += new System.EventHandler(this.PatLbl_Click);
            // 
            // PrescLbl
            // 
            this.PrescLbl.AutoSize = true;
            this.PrescLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrescLbl.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescLbl.ForeColor = System.Drawing.Color.Black;
            this.PrescLbl.Location = new System.Drawing.Point(161, 440);
            this.PrescLbl.Name = "PrescLbl";
            this.PrescLbl.Size = new System.Drawing.Size(129, 46);
            this.PrescLbl.TabIndex = 21;
            this.PrescLbl.Text = "Назначения \r\nДоктора";
            this.PrescLbl.Click += new System.EventHandler(this.PrescLbl_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.AutoSize = true;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.Font = new System.Drawing.Font("Averia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogOutBtn.Location = new System.Drawing.Point(161, 515);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(110, 46);
            this.LogOutBtn.TabIndex = 23;
            this.LogOutBtn.Text = "Выйти\r\nс аккаунта";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Medical_Centre.Properties.Resources.logout;
            this.pictureBox11.Location = new System.Drawing.Point(116, 515);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(39, 41);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Medical_Centre.Properties.Resources.free_icon_appointment_book_9661715;
            this.pictureBox3.Location = new System.Drawing.Point(108, 437);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Medical_Centre.Properties.Resources.reception__1_;
            this.pictureBox10.Location = new System.Drawing.Point(108, 376);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 55);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 20;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Medical_Centre.Properties.Resources.chemistry;
            this.pictureBox9.Location = new System.Drawing.Point(108, 314);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 55);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Medical_Centre.Properties.Resources.free_icon_doctor_2008102;
            this.pictureBox8.Location = new System.Drawing.Point(108, 252);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Medical_Centre.Properties.Resources.free_icon_hospital_bed_11056438__1_;
            this.pictureBox7.Location = new System.Drawing.Point(108, 194);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Centre.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(158, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Medical_Centre.Properties.Resources.reject2;
            this.button1.Location = new System.Drawing.Point(355, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 38);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Medical_Centre.Properties.Resources._123;
            this.button2.Location = new System.Drawing.Point(322, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 38);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 583);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PrescLbl);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.RecepLbl);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.LabLbl);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.DoctorsLbl);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.PatLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PrescLbl;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label RecepLbl;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label LabLbl;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label DoctorsLbl;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label PatLbl;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label LogOutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}