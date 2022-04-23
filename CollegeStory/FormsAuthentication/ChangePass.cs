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

namespace CollegeStory.FormsAuthentication
{
    public partial class ChangePass : Form
    {
        string email;
        public ChangePass(string emailStudent)
        {
            InitializeComponent();
            email = emailStudent;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Nueva contraseña")
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
                txtPass.ForeColor = Color.Gainsboro;
                txtPass.Text = "Nueva contraseña";
            }
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Confirmar nueva contraseña")
            {
                txtConfirmPass.Text = "";
                txtConfirmPass.ForeColor = Color.White;
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "")
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                txtConfirmPass.ForeColor = Color.Gainsboro;
                txtConfirmPass.Text = "Confirmar nueva contraseña";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConfirmPass.Text)
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                ChangePassword(txtPass.Text);
            }
        }

        void ChangePassword(string pass)
        {
            if (pass != "" && pass != "Nueva contraseña")
            {
                lblError.Visible = false;
                string password = Classes.Encrypt.GetSHA256(txtPass.Text);
                try
                {
                    using (SchoolStoryEntities db = new SchoolStoryEntities())
                    {
                        Student student = db.Student.Where(d => d.Email == email).First();
                        student.Password = password;

                        db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Ha cambiado su contraseña correctamente.", "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Visible = false;
                    Login login = new Login();
                    login.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
