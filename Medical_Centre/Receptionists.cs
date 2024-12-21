using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
namespace Medical_Centre
{
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();
            if (Login.Role == "Админ")
            {
                HomeBtn.Enabled = false;
            }
            DisplayRec();

            this.ReceptionistDGV.ReadOnly = true;
            this.ReceptionistDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ReceptionistDGV.AllowUserToAddRows = false;
            this.ReceptionistDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите Ресепшена");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ReceptionistTbl where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ресепшеонист Удалена");
                    Con.Close();
                    DisplayRec();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAdressTb.Text == "" || SurnameTb.Text == "" || OtchestvoTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM ReceptionistTbl WHERE RecepName = @RN AND RecepSurname = @RS AND RecepPhone = @RP";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    checkCmd.Parameters.AddWithValue("@RS", SurnameTb.Text);
                    checkCmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Ресепшионист с такими данными уже существует");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecepName,RecepPhone,RecepAdd,RecepPass,RecepSurname,RecepLastName,RecepDOB) values(@RN,@RP,@RA,@RPA,@RS,@RLN,@RD)", Con);
                        cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                        cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@RA", RAdressTb.Text);
                        cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                        cmd.Parameters.AddWithValue("@RS", SurnameTb.Text);
                        cmd.Parameters.AddWithValue("@RLN", OtchestvoTb.Text);
                        cmd.Parameters.AddWithValue("@RD", RecepDOB.Value.Date);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ресепшионист добавлен");
                    }

                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNameTb.Text = ReceptionistDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTb.Text = ReceptionistDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAdressTb.Text = ReceptionistDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPassword.Text = ReceptionistDGV.SelectedRows[0].Cells[4].Value.ToString();
            SurnameTb.Text = ReceptionistDGV.SelectedRows[0].Cells[5].Value.ToString();
            OtchestvoTb.Text = ReceptionistDGV.SelectedRows[0].Cells[6].Value.ToString();
            RecepDOB.Text = ReceptionistDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (RNameTb.Text == "")
            {
                Key = 0;
            }else
            {
                Key = Convert.ToInt32(ReceptionistDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAdressTb.Text == "" || SurnameTb.Text == "" || OtchestvoTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM ReceptionistTbl WHERE (RecepName = @RN AND RecepSurname = @RS AND RecepPhone = @RP) AND RecepId <> @RKey";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    checkCmd.Parameters.AddWithValue("@RS", SurnameTb.Text);
                    checkCmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    checkCmd.Parameters.AddWithValue("@RKey", Key);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Ресепшионист с такими данными уже существует");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecepName=@RN,RecepPhone=@RP,RecepAdd=@RA,RecepPass=@RPA,RecepSurname=@RS,RecepLastName=@RLN,RecepDOB=@RD where RecepId=@RKey", Con);
                        cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                        cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@RA", RAdressTb.Text);
                        cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                        cmd.Parameters.AddWithValue("@RS", SurnameTb.Text);
                        cmd.Parameters.AddWithValue("@RLN", OtchestvoTb.Text);
                        cmd.Parameters.AddWithValue("@RD", RecepDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@RKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ресепшионист Обновлен");
                    }

                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Clear()
        {
            RNameTb.Text =  "";
            RPassword.Text = "";
            RPhoneTb.Text = "+998";
            RAdressTb.Text = "";
            SurnameTb.Text = "";
            OtchestvoTb.Text = "";
            Key = 0;
        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void PatBtn_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void DocBtn_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabTestBtn_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void AdmPanBtn_Click(object sender, EventArgs e)
        {
            AdminPanel Obj = new AdminPanel();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SurnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RPhoneTb_TextChanged(object sender, EventArgs e)
        {
            if (!RPhoneTb.Text.StartsWith("+998") && RPhoneTb.Text.Length > 0)
            {
                MessageBox.Show("Номер телефона должен начинаться с +998.");
                RPhoneTb.Text = "+998";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
