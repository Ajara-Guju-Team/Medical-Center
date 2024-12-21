using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Centre
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            if (Login.Role == "Ресепшен")
            {
                DocBtn.Enabled = false;
                LabBtn.Enabled = false;
                RecepBtn.Enabled = false;
                AdmPanPb.Hide();
                AdmPanBtn.Hide();

            }
            if (Login.Role == "Админ")
            {
                HomeBtn.Enabled = false;
            }
            DisplayPat();

            this.PatientsDGV.ReadOnly = true;
            this.PatientsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.AllowUserToAddRows = false;
            this.PatientsDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            PatNameTb.Text = "";
            PatGenCb.SelectedIndex = -1;
            PatAddTb.Text = "";
            PatPhoneTb.Text = "+998";
            PatAlTb.Text = "";
            SurnameTb.Text = "";
            OtchestvoTb.Text = "";

            Key = 0;

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || SurnameTb.Text == "" || OtchestvoTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM PatientTbl WHERE PatName = @PN AND PatGen = @PG AND PatDOB = @PD AND PatAdd = @PA AND PatPhone = @PP AND PatAll = @PAL AND PatSurname = @PS AND PatLastName = @PLN";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    checkCmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    checkCmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    checkCmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    checkCmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                    checkCmd.Parameters.AddWithValue("@PS", SurnameTb.Text);
                    checkCmd.Parameters.AddWithValue("@PLN", OtchestvoTb.Text);
                    checkCmd.ExecuteNonQuery();
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Доктор с такими данными уже существует");
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatGen,PatDOB,PatAdd,PatPhone,PatAll,PatSurname,PatLastName) values(@PN,@PG,@PD,@PA,@PP,@PAL,@PS,@PLN)", Con);
                        cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                        cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                        cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                        cmd.Parameters.AddWithValue("@PS", SurnameTb.Text);
                        cmd.Parameters.AddWithValue("@PLN", OtchestvoTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Пациент добавлен");
                    }
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || SurnameTb.Text == "" || OtchestvoTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM PatientTbl WHERE PatName = @PN AND PatGen = @PG AND PatDOB = @PD AND PatAdd = @PA AND PatPhone = @PP AND PatAll = @PAL AND PatSurname = @PS AND PatLastName = @PLN  AND PatId <> @PKey";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    checkCmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    checkCmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    checkCmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    checkCmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                    checkCmd.Parameters.AddWithValue("@PS", SurnameTb.Text);
                    checkCmd.Parameters.AddWithValue("@PLN", OtchestvoTb.Text);
                    checkCmd.Parameters.AddWithValue("@PKey", Key);

                    checkCmd.ExecuteNonQuery();
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Доктор с такими данными уже существует");
                    }
                    else



                    {
                        SqlCommand cmd = new SqlCommand("Update PatientTbl set PatName=@PN,PatGen=@PG,PatDOB=@PD,PatAdd=@PA,PatPhone=@PP,PatAll=@PAL,PatSurname=@PS,PatLastName=@PLN where PatId=@PKey", Con);
                        cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                        cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                        cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@PAL", PatAlTb.Text);
                        cmd.Parameters.AddWithValue("@PKey", Key);
                        cmd.Parameters.AddWithValue("@PS", SurnameTb.Text);
                        cmd.Parameters.AddWithValue("@PLN", OtchestvoTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Пациент Изменен");
                    }
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatGenCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatDOB.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatPhoneTb.Text = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatAlTb.Text = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatAddTb.Text = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
            SurnameTb.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
            OtchestvoTb.Text = PatientsDGV.SelectedRows[0].Cells[8].Value.ToString();


            if (PatNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите Пациента");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl where PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пациент Удалена");
                    Con.Close();
                    DisplayPat();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void DocBtn_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabBtn_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void RecepBtn_Click(object sender, EventArgs e)
        {
            Receptionists Obj = new Receptionists();
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

        private void PatPhoneTb_TextChanged(object sender, EventArgs e)
        {
            if (!PatPhoneTb.Text.StartsWith("+998") && PatPhoneTb.Text.Length > 0)
            {
                MessageBox.Show("Номер телефона должен начинаться с +998.");
                PatPhoneTb.Text = "+998";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDoctorInfo();
        }

        private void UpdateDoctorInfo()
        {
            var selectedDays = new StringBuilder();

            if (MondayCheckBox.Checked) selectedDays.Append("Monday, ");
            if (TuesdayCheckBox.Checked) selectedDays.Append("Tuesday, ");
            if (WednesdayCheckBox.Checked) selectedDays.Append("Wednesday, ");
            if (ThursdayCheckBox.Checked) selectedDays.Append("Thursday, ");
            if (FridayCheckBox.Checked) selectedDays.Append("Friday, ");
            if (SaturdayCheckBox.Checked) selectedDays.Append("Saturday, ");
            if (SundayCheckBox.Checked) selectedDays.Append("Sunday, ");

            if (selectedDays.Length > 0)
            {
                selectedDays.Length -= 2; 
                var days = selectedDays.ToString().Split(',').Select(d => d.Trim()).ToArray();
                FetchDoctorsForDays(days);
            }
            else
            {
                DoctorInfoLabel.Text = "No days selected.";
            }
        }

        private void FetchDoctorsForDays(string[] days)
        {
            try
            {
                Con.Open();
                var query = new StringBuilder();
                query.Append("SELECT DISTINCT d.DocName, ");
                query.Append("ds.StartTime, ds.EndTime\n ");
                query.Append("FROM DoctorScheduleTbl ds ");
                query.Append("INNER JOIN DoctorTbl d ON ds.DocId = d.DocId ");
                query.Append("WHERE ");

                for (int i = 0; i < days.Length; i++)
                {
                    query.Append($"{days[i]} = 1");
                    if (i < days.Length - 1)
                    {
                        query.Append(" OR ");
                    }
                }

                SqlCommand cmd = new SqlCommand(query.ToString(), Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    var doctors = new StringBuilder("");
                    while (rdr.Read())
                    {
                        var doctorName = rdr["DocName"].ToString();
                        var startTime = ((TimeSpan)rdr["StartTime"]).ToString(@"hh\:mm");
                        var endTime = ((TimeSpan)rdr["EndTime"]).ToString(@"hh\:mm");
                        doctors.Append($"{doctorName}: {startTime} - {endTime}\n");
                    }

                    DoctorInfoLabel.Text = doctors.ToString();
                }
                else
                {
                    DoctorInfoLabel.Text = "No doctors available for selected days.";
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
