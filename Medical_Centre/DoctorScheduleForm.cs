using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Centre
{
    public partial class DoctorScheduleForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public DoctorScheduleForm()
        {
            InitializeComponent();
        }


        private void AdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "INSERT INTO DoctorScheduleTbl (DocId, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Shift1, Shift2, StartTime, EndTime) VALUES (@DocId, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday, @Saturday, @Sunday, @Shift1, @Shift2, @StartTime, @EndTime)";
                SqlCommand cmd = new SqlCommand(Query, Con);

                cmd.Parameters.AddWithValue("@DocId", int.Parse(DoctorIdTb.Text));
                cmd.Parameters.AddWithValue("@Monday", MondayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Tuesday", TuesdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Wednesday", WednesdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Thursday", ThursdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Friday", FridayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Saturday", SaturdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Sunday", SundayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Shift1", Shift1CheckBox.Checked);
                cmd.Parameters.AddWithValue("@Shift2", Shift2CheckBox.Checked);
                cmd.Parameters.AddWithValue("@StartTime", StartTimeTb.Text);
                cmd.Parameters.AddWithValue("@EndTime", EndTimeTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Расписание сохранено успешно!");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "DELETE FROM DoctorScheduleTbl WHERE DocId=@DocId";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.Parameters.AddWithValue("@DocId", int.Parse(DoctorIdTb.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Расписание удалено успешно!");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "UPDATE DoctorScheduleTbl SET Monday=@Monday, Tuesday=@Tuesday, Wednesday=@Wednesday, Thursday=@Thursday, Friday=@Friday, Saturday=@Saturday, Sunday=@Sunday, Shift1=@Shift1, Shift2=@Shift2, StartTime=@StartTime, EndTime=@EndTime WHERE DocId=@DocId";
                SqlCommand cmd = new SqlCommand(Query, Con);

                cmd.Parameters.AddWithValue("@DocId", int.Parse(DoctorIdTb.Text));
                cmd.Parameters.AddWithValue("@Monday", MondayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Tuesday", TuesdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Wednesday", WednesdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Thursday", ThursdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Friday", FridayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Saturday", SaturdayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Sunday", SundayCheckBox.Checked);
                cmd.Parameters.AddWithValue("@Shift1", Shift1CheckBox.Checked);
                cmd.Parameters.AddWithValue("@Shift2", Shift2CheckBox.Checked);
                cmd.Parameters.AddWithValue("@StartTime", StartTimeTb.Text);
                cmd.Parameters.AddWithValue("@EndTime", EndTimeTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Расписание обновлено успешно!");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Shift1CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Shift1CheckBox.Checked)
            {
                StartTimeTb.Text = "08:00";
                EndTimeTb.Text = "16:00";
            }
        }

        private void Shift2CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Shift2CheckBox.Checked)
            {
                StartTimeTb.Text = "16:00";
                EndTimeTb.Text = "00:00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
        }
    }
}
