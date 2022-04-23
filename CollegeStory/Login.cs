using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeStory.Database;

namespace CollegeStory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormsAuthentication.SignUp signUp = new FormsAuthentication.SignUp();
            signUp.Visible = true;
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormsAuthentication.ForgotPass forgotPass = new FormsAuthentication.ForgotPass();
            forgotPass.Visible = true;
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.White;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Gainsboro;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtPass.Text != "" && txtId.Text != "ID" && txtPass.Text != "Contraseña")
            {
                Access(txtId.Text, txtPass.Text);
            }
            else
            {
                lblError.Text = "Llene los campos correctamente";
                lblError.Visible = true;
            }
        }

        void Access(string id, string pass)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                try
                {
                    lblError.Visible = false;
                    using (SchoolStoryEntities db = new SchoolStoryEntities())
                    {
                        var lst = db.Student;
                        foreach (var student in lst)
                        {
                            if (student.Id == ID && student.Password == Classes.Encrypt.GetSHA256(pass))
                            {
                                MessageBox.Show($"Bienvenido {student.Name} {student.LastName}.", "College Story", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Visible = false;
                                FormsGrades.Menu menu = new FormsGrades.Menu(student.Id);
                                menu.Visible = true;
                                break;
                            }
                            else
                            {
                                lblError.Text = "Esta cuenta no existe en la base de datos.";
                                lblError.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    lblError.Text = "Error en la base de datos. No se puede conectar.";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Llene los campos correctamente";
                lblError.Visible = true;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
