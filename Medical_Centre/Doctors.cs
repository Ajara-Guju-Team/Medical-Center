using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Medical_Centre
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            if (Login.Role == "Админ")
            {
                label9.Enabled = false;
            }
            if (Login.Role == "Ресепшен")
            {
                LabTestBtn.Enabled = false;
                RecepBtn.Enabled = false;
            }
            DisplayDoc();

            this.DoctorsDGV.ReadOnly = true;
            this.DoctorsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DoctorsDGV.AllowUserToAddRows = false;
            this.DoctorsDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DNameTb.Text = "";
            DocPhoneTb.Text = "+998";
            DocAddTb.Text = "";
            DocExpTb.Text = "";
            DocPassWordTb.Text = "";
            FamilyaDocTb.Text = "";
            OtchestvoDocTb.Text = "";
            DocGenCb.SelectedIndex = -1;
            DocSpecCb.SelectedIndex = -1;
            Key = 0;

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1 || FamilyaDocTb.Text == "" || OtchestvoDocTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM DoctorTbl WHERE DocName = @DN AND DocDOB = @DD AND DOCGEN = @DG AND DOCSPEC = @DS AND DOCEXP = @DE AND DOCPHONE = @DP AND DocAdd = @DA AND DocPass = @DPA AND DocSurName = @DSN AND DocOtchestvo = @DO";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    checkCmd.Parameters.AddWithValue("@DD", DOcDOB.Value.Date);
                    checkCmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    checkCmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    checkCmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    checkCmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    checkCmd.Parameters.AddWithValue("@DSN", FamilyaDocTb.Text);
                    checkCmd.Parameters.AddWithValue("@DO", OtchestvoDocTb.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Доктор с такими данными уже существует");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DocDOB,DOCGEN,DOCSPEC,DOCEXP,DOCPHONE,DocAdd,DocPass,DocSurName,DocOtchestvo) values(@DN,@DD,@DG,@DS,@DE,@DP,@DA,@DPA,@DSN,@DO)", Con);
                        cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                        cmd.Parameters.AddWithValue("@DD", DOcDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                        cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                        cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                        cmd.Parameters.AddWithValue("@DSN", FamilyaDocTb.Text);
                        cmd.Parameters.AddWithValue("@DO", OtchestvoDocTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Доктор добавлена");
                    }

                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DNameTb.Text = DoctorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DOcDOB.Text = DoctorsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocGenCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocSpecCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[4].Value.ToString();
            DocExpTb.Text = DoctorsDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocPhoneTb.Text = DoctorsDGV.SelectedRows[0].Cells[6].Value.ToString();
            DocAddTb.Text = DoctorsDGV.SelectedRows[0].Cells[7].Value.ToString();
            DocPassWordTb.Text = DoctorsDGV.SelectedRows[0].Cells[8].Value.ToString();
            FamilyaDocTb.Text = DoctorsDGV.SelectedRows[0].Cells[9].Value.ToString();
            OtchestvoDocTb.Text = DoctorsDGV.SelectedRows[0].Cells[10].Value.ToString();


            if (DNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1 || FamilyaDocTb.Text == "" || OtchestvoDocTb.Text == "")
            {
                MessageBox.Show("Доктор не выбран");
            }
            else
            {
                try
                {
                    Con.Open();
                    
                        SqlCommand cmd = new SqlCommand("Update DoctorTbl set DocName=@DN,DocDOB=@DD,DOCGEN=@DG,DOCSPEC=@DS,DOCEXP=@DE,DOCPHONE=@DP,DocAdd=@DA,DocPass=@DPA,DocSurName=@DSN,DocOtchestvo=@DO where DocId=@DKey", Con);
                        cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                        cmd.Parameters.AddWithValue("@DD", DOcDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                        cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                        cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                        cmd.Parameters.AddWithValue("@DKey", Key);
                        cmd.Parameters.AddWithValue("@DSN", FamilyaDocTb.Text);
                        cmd.Parameters.AddWithValue("@DO", OtchestvoDocTb.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Доктор Изменена");
                    

                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите Доктора");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Доктор Удалена");
                    Con.Close();
                    DisplayDoc();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LabTestBtn_Click(object sender, EventArgs e)
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

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
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

        private void DNameTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FamilyaDocTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OtchestvoDocTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocPhoneTb_TextChanged(object sender, EventArgs e)
        {
            if (!DocPhoneTb.Text.StartsWith("+998") && DocPhoneTb.Text.Length > 0)
            {
                MessageBox.Show("Номер телефона должен начинаться с +998.");
                DocPhoneTb.Text = "+998";
            }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            DoctorScheduleForm scheduleForm = new DoctorScheduleForm();
            scheduleForm.Show();
        }
    }
}
