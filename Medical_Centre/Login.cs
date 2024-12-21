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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Centre
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = -1;
            UnameTb.Text = "";
            Passtb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5C3IJB0;Initial Catalog=Medical_Centre;Integrated Security=True;Encrypt=False");
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите свою позицию");
            }else if (RoleCb.SelectedIndex == 0)
            {
                if(UnameTb.Text == "" || Passtb.Text == "")
                {
                    MessageBox.Show("Введите имя Администратора и Пароль.");
                }else if(UnameTb.Text == "admin" &&  Passtb.Text == "admin")
                {
                    Role = "Админ";
                    AdminPanel obj = new AdminPanel();
                    obj.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Неверное имя Администратора и Пароль.");
                }
            }else if (RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || Passtb.Text == "")
                {
                    MessageBox.Show("Введите имя Доктора и пароль.");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName='" + UnameTb.Text + "' and DocPass='" + Passtb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Доктор";
                        Prescriptions obj = new Prescriptions();
                        obj.Show();
                        this.Hide();
                    }else
                    {
                        MessageBox.Show("Доктор не найден");
                    }
                    Con.Close();
                }
                
            }
            else
            {
                if (UnameTb.Text == "" || Passtb.Text == "")
                {
                    MessageBox.Show("Введите имя Ресепшиониста и Пароль.");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where RecepName='" + UnameTb.Text + "' and RecepPass='" + Passtb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Ресепшен";
                        Homes obj = new Homes();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ресепшионист не найден");
                    }
                    Con.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Passtb.PasswordChar = '\0';
                checkBox1.Text = " Скрыть\n пароль";
            }
            else
            {
                Passtb.PasswordChar = '*';
                checkBox1.Text = "Показать\n пароль";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Passtb.Focus();

            }
            if (e.KeyCode == Keys.Down)
            {

                Passtb.Focus();

            }
        }

        private void Passtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(LoginBtn, EventArgs.Empty);

            }
            if (e.KeyCode == Keys.Up)
            {
                UnameTb.Focus();
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
