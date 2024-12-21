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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPresc();
            GetDocId();
            GetPatId();
            GetTestId();
            if (Login.Role == "Доктор")
            {
                AdmPanBtn.Hide();
                AdmPanPb.Hide();
            }
            this.PrescriptionDGV.ReadOnly = true;
            this.PrescriptionDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PrescriptionDGV.AllowUserToAddRows = false;
            this.PrescriptionDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DisplayPresc()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocIdCb.SelectedIndex = -1;
            PatIdCb.SelectedIndex = -1;
            TestIdCb.SelectedIndex = -1;
            CostTb.Text = "";
            MedTb.Text = "";
            DocNameTb.Text = "";
            PatNameTb.Text = "";
            TestNameTb.Text = "";
            PrescSumTxt.Text = "";
            //Key = 0;

        }
        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId=" + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr ["DocName"].ToString();
            }

            Con.Close();
        }
        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId=" + PatIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PatName"].ToString();
            }

            Con.Close();
        }
        private void GetTestName()
        {
            Con.Open();
            string Query = "Select * from TestTbl where TestNum=" + TestIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameTb.Text = dr["TestName"].ToString();
                CostTb.Text = dr["TestCost"].ToString();
            }

            Con.Close();
        }
        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId",  typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocId";
            DocIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            PatIdCb.ValueMember = "PatId";
            PatIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            TestIdCb.ValueMember = "TestNum";
            TestIdCb.DataSource = dt;
            Con.Close();
        }

        int Key = 0;

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || DocNameTb.Text == "" || TestNameTb.Text == "")
            {
                MessageBox.Show("Информации не заполнено");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,LabTestId,LabTestName,Medicines,Cost) values(@DI,@DN,@PI,@PN,@TI,@TN,@MED,@CO)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@TI", TestIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", TestNameTb.Text);
                    cmd.Parameters.AddWithValue("@MED", MedTb.Text);
                    cmd.Parameters.AddWithValue("@CO", CostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Рецепт лекартсв добавлен");
                    Con.Close();
                    DisplayPresc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void TestIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTestName();
        }

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PrescriptionDGV.ReadOnly = true;
            this.PrescriptionDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.PrescriptionDGV.AllowUserToAddRows = false;
            this.PrescriptionDGV.EditMode = DataGridViewEditMode.EditProgrammatically;

            string doctor = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            string patient = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            string test = PrescriptionDGV.SelectedRows[0].Cells[6].Value.ToString();
            string medication = PrescriptionDGV.SelectedRows[0].Cells[7].Value.ToString();
            DateTime date = DateTime.Today;

            string prescriptionText =
                "                                HeathHorizon Clinic\n\n" +
                "                                Назначения Доктора\n" +
                "**********************************************************************\n" +
                $"{date:dd.MM.yyyy}\n\n" +
                $"Доктор: {doctor}\n" +
                $"Пациент: {patient}\n\n" +
                $"Тест: {test}\n" +
                $"Медикаменты: {medication}\n" +
                $"Прием Леккарств_________________\n\n" +
                "**********************************************************************\n" +
                "                                Health Horizon";

            PrescSumTxt.Text = prescriptionText;

            MedTb.Text = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();


            if (string.IsNullOrEmpty(MedTb.Text))
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PrescSumTxt.Text + "\n", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(95, 80));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите Назначение");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PrescriptionTbl where PrescId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Назначение Удалена");
                    Con.Close();
                    DisplayPresc();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
