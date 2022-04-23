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
using CollegeStory.Classes;

namespace CollegeStory.FormsAuthentication
{
    public partial class ForgotPass : Form
    {
        int random;
        Random rnd = new Random();
        public ForgotPass()
        {
            InitializeComponent();
            random = rnd.Next(1000, 9999);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.ForeColor = Color.Gainsboro;
                txtEmail.Text = "Email";
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Código")
            {
                txtCode.Text = "";
                txtCode.ForeColor = Color.White;
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                txtCode.ForeColor = Color.White;
                txtCode.Text = "Código";
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            SendEmail(txtEmail.Text);
        }

        void SendEmail(string email)
        {
            try
            {
                using (Database.SchoolStoryEntities db = new Database.SchoolStoryEntities())
                {
                    int validation = 0;
                    var lst = db.Student;
                    foreach (var student in lst)
                    {
                        if (email == student.Email)
                        {
                            validation = 0;
                            var mailService = new SystemSupportMail();
                            mailService.sendMail(
                                subject: "CollegeStory: Solicitud de recuperación de contraseña.",
                                body: $"Hola {student.Name} {student.LastName}.\n" +
                                $"Has solicitado cambiar tu contraseña. Aquí está el código que deberá poner en la aplicación para cambiar su contraseña:\n" +
                                $"{random}",
                            recipientMail: student.Email);
                            break;
                        }
                        else
                        {
                            validation++;
                        }
                    }
                    if (validation == 0)
                    {
                        MessageBox.Show("Se ha enviado un correo al email especificado. Favor revise su bandeja de entrada.", "Perfeccto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El email ingresado no se encuentra en nuestra base de datos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al hacer la consulta con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == random.ToString())
            {
                this.Visible = false;
                ChangePass change = new ChangePass(txtEmail.Text);
                change.Visible = true;
            }
            else
            {
                MessageBox.Show("El código ingresado no coincide con el enviado al correo electrónico. Valide nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
