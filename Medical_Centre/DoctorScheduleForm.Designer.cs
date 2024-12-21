namespace Medical_Centre
{
    partial class DoctorScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorScheduleForm));
            this.DelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTimeTb = new System.Windows.Forms.TextBox();
            this.MondayCheckBox = new System.Windows.Forms.CheckBox();
            this.EndTimeTb = new System.Windows.Forms.TextBox();
            this.TuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.ThursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.WednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.FridayCheckBox = new System.Windows.Forms.CheckBox();
            this.SaturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.SundayCheckBox = new System.Windows.Forms.CheckBox();
            this.Shift2CheckBox = new System.Windows.Forms.CheckBox();
            this.Shift1CheckBox = new System.Windows.Forms.CheckBox();
            this.DoctorIdTb = new System.Windows.Forms.TextBox();
            this.AdBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EdBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.ActiveBorderThickness = 1;
            this.DelBtn.ActiveCornerRadius = 20;
            this.DelBtn.ActiveFillColor = System.Drawing.Color.Maroon;
            this.DelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DelBtn.ActiveLineColor = System.Drawing.Color.Maroon;
            this.DelBtn.BackColor = System.Drawing.Color.White;
            this.DelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelBtn.BackgroundImage")));
            this.DelBtn.ButtonText = "Удалить";
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DelBtn.IdleBorderThickness = 1;
            this.DelBtn.IdleCornerRadius = 20;
            this.DelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.IdleForecolor = System.Drawing.Color.White;
            this.DelBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.Location = new System.Drawing.Point(119, 384);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(105, 44);
            this.DelBtn.TabIndex = 74;
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Id Доктора";
            // 
            // StartTimeTb
            // 
            this.StartTimeTb.Location = new System.Drawing.Point(14, 317);
            this.StartTimeTb.Name = "StartTimeTb";
            this.StartTimeTb.Size = new System.Drawing.Size(190, 27);
            this.StartTimeTb.TabIndex = 75;
            // 
            // MondayCheckBox
            // 
            this.MondayCheckBox.AutoSize = true;
            this.MondayCheckBox.Location = new System.Drawing.Point(14, 137);
            this.MondayCheckBox.Name = "MondayCheckBox";
            this.MondayCheckBox.Size = new System.Drawing.Size(47, 21);
            this.MondayCheckBox.TabIndex = 77;
            this.MondayCheckBox.Text = "Пн";
            this.MondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndTimeTb
            // 
            this.EndTimeTb.Location = new System.Drawing.Point(14, 350);
            this.EndTimeTb.Name = "EndTimeTb";
            this.EndTimeTb.Size = new System.Drawing.Size(190, 27);
            this.EndTimeTb.TabIndex = 78;
            // 
            // TuesdayCheckBox
            // 
            this.TuesdayCheckBox.AutoSize = true;
            this.TuesdayCheckBox.Location = new System.Drawing.Point(14, 164);
            this.TuesdayCheckBox.Name = "TuesdayCheckBox";
            this.TuesdayCheckBox.Size = new System.Drawing.Size(45, 21);
            this.TuesdayCheckBox.TabIndex = 79;
            this.TuesdayCheckBox.Text = "Вт";
            this.TuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheckBox
            // 
            this.ThursdayCheckBox.AutoSize = true;
            this.ThursdayCheckBox.Location = new System.Drawing.Point(66, 137);
            this.ThursdayCheckBox.Name = "ThursdayCheckBox";
            this.ThursdayCheckBox.Size = new System.Drawing.Size(45, 21);
            this.ThursdayCheckBox.TabIndex = 80;
            this.ThursdayCheckBox.Text = "Чт";
            this.ThursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheckBox
            // 
            this.WednesdayCheckBox.AutoSize = true;
            this.WednesdayCheckBox.Location = new System.Drawing.Point(14, 191);
            this.WednesdayCheckBox.Name = "WednesdayCheckBox";
            this.WednesdayCheckBox.Size = new System.Drawing.Size(46, 21);
            this.WednesdayCheckBox.TabIndex = 81;
            this.WednesdayCheckBox.Text = "Ср";
            this.WednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FridayCheckBox
            // 
            this.FridayCheckBox.AutoSize = true;
            this.FridayCheckBox.Location = new System.Drawing.Point(66, 164);
            this.FridayCheckBox.Name = "FridayCheckBox";
            this.FridayCheckBox.Size = new System.Drawing.Size(46, 21);
            this.FridayCheckBox.TabIndex = 82;
            this.FridayCheckBox.Text = "Пт";
            this.FridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaturdayCheckBox
            // 
            this.SaturdayCheckBox.AutoSize = true;
            this.SaturdayCheckBox.Location = new System.Drawing.Point(66, 191);
            this.SaturdayCheckBox.Name = "SaturdayCheckBox";
            this.SaturdayCheckBox.Size = new System.Drawing.Size(46, 21);
            this.SaturdayCheckBox.TabIndex = 83;
            this.SaturdayCheckBox.Text = "Сб";
            this.SaturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SundayCheckBox
            // 
            this.SundayCheckBox.AutoSize = true;
            this.SundayCheckBox.Location = new System.Drawing.Point(117, 137);
            this.SundayCheckBox.Name = "SundayCheckBox";
            this.SundayCheckBox.Size = new System.Drawing.Size(45, 21);
            this.SundayCheckBox.TabIndex = 84;
            this.SundayCheckBox.Text = "Вс";
            this.SundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // Shift2CheckBox
            // 
            this.Shift2CheckBox.AutoSize = true;
            this.Shift2CheckBox.Location = new System.Drawing.Point(14, 268);
            this.Shift2CheckBox.Name = "Shift2CheckBox";
            this.Shift2CheckBox.Size = new System.Drawing.Size(88, 21);
            this.Shift2CheckBox.TabIndex = 85;
            this.Shift2CheckBox.Text = "2 Смена";
            this.Shift2CheckBox.UseVisualStyleBackColor = true;
            this.Shift2CheckBox.CheckedChanged += new System.EventHandler(this.Shift2CheckBox_CheckedChanged_1);
            // 
            // Shift1CheckBox
            // 
            this.Shift1CheckBox.AutoSize = true;
            this.Shift1CheckBox.Location = new System.Drawing.Point(14, 241);
            this.Shift1CheckBox.Name = "Shift1CheckBox";
            this.Shift1CheckBox.Size = new System.Drawing.Size(88, 21);
            this.Shift1CheckBox.TabIndex = 86;
            this.Shift1CheckBox.Text = "1 Смена";
            this.Shift1CheckBox.UseVisualStyleBackColor = true;
            this.Shift1CheckBox.CheckedChanged += new System.EventHandler(this.Shift1CheckBox_CheckedChanged_1);
            // 
            // DoctorIdTb
            // 
            this.DoctorIdTb.Location = new System.Drawing.Point(14, 85);
            this.DoctorIdTb.Name = "DoctorIdTb";
            this.DoctorIdTb.Size = new System.Drawing.Size(190, 27);
            this.DoctorIdTb.TabIndex = 87;
            // 
            // AdBtn
            // 
            this.AdBtn.ActiveBorderThickness = 1;
            this.AdBtn.ActiveCornerRadius = 20;
            this.AdBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AdBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AdBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AdBtn.BackColor = System.Drawing.Color.White;
            this.AdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdBtn.BackgroundImage")));
            this.AdBtn.ButtonText = "Добавить";
            this.AdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AdBtn.IdleBorderThickness = 1;
            this.AdBtn.IdleCornerRadius = 20;
            this.AdBtn.IdleFillColor = System.Drawing.Color.Green;
            this.AdBtn.IdleForecolor = System.Drawing.Color.White;
            this.AdBtn.IdleLineColor = System.Drawing.Color.Green;
            this.AdBtn.Location = new System.Drawing.Point(11, 384);
            this.AdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(100, 44);
            this.AdBtn.TabIndex = 88;
            this.AdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // EdBtn
            // 
            this.EdBtn.ActiveBorderThickness = 1;
            this.EdBtn.ActiveCornerRadius = 20;
            this.EdBtn.ActiveFillColor = System.Drawing.Color.Navy;
            this.EdBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EdBtn.ActiveLineColor = System.Drawing.Color.Navy;
            this.EdBtn.BackColor = System.Drawing.Color.White;
            this.EdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EdBtn.BackgroundImage")));
            this.EdBtn.ButtonText = "Изменить";
            this.EdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdBtn.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EdBtn.IdleBorderThickness = 1;
            this.EdBtn.IdleCornerRadius = 20;
            this.EdBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EdBtn.IdleForecolor = System.Drawing.Color.White;
            this.EdBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EdBtn.Location = new System.Drawing.Point(36, 425);
            this.EdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EdBtn.Name = "EdBtn";
            this.EdBtn.Size = new System.Drawing.Size(150, 44);
            this.EdBtn.TabIndex = 89;
            this.EdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EdBtn.Click += new System.EventHandler(this.EdBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 32);
            this.panel2.TabIndex = 90;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Medical_Centre.Properties.Resources._112;
            this.button2.Location = new System.Drawing.Point(165, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 79;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Medical_Centre.Properties.Resources.reject11;
            this.button1.Location = new System.Drawing.Point(198, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 70;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(10, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Время работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(10, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 92;
            this.label3.Text = "Смена работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Averia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 93;
            this.label4.Text = "Рабочие Дни";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DoctorScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(231, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EdBtn);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.DoctorIdTb);
            this.Controls.Add(this.Shift1CheckBox);
            this.Controls.Add(this.Shift2CheckBox);
            this.Controls.Add(this.SundayCheckBox);
            this.Controls.Add(this.SaturdayCheckBox);
            this.Controls.Add(this.FridayCheckBox);
            this.Controls.Add(this.WednesdayCheckBox);
            this.Controls.Add(this.ThursdayCheckBox);
            this.Controls.Add(this.TuesdayCheckBox);
            this.Controls.Add(this.EndTimeTb);
            this.Controls.Add(this.MondayCheckBox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartTimeTb);
            this.Font = new System.Drawing.Font("Averia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorScheduleForm";
            this.Text = "DoctorScheduleForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 DelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartTimeTb;
        private System.Windows.Forms.CheckBox MondayCheckBox;
        private System.Windows.Forms.TextBox EndTimeTb;
        private System.Windows.Forms.CheckBox TuesdayCheckBox;
        private System.Windows.Forms.CheckBox ThursdayCheckBox;
        private System.Windows.Forms.CheckBox WednesdayCheckBox;
        private System.Windows.Forms.CheckBox FridayCheckBox;
        private System.Windows.Forms.CheckBox SaturdayCheckBox;
        private System.Windows.Forms.CheckBox SundayCheckBox;
        private System.Windows.Forms.CheckBox Shift2CheckBox;
        private System.Windows.Forms.CheckBox Shift1CheckBox;
        private System.Windows.Forms.TextBox DoctorIdTb;
        private Bunifu.Framework.UI.BunifuThinButton2 AdBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EdBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}