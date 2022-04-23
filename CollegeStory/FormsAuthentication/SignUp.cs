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
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Visible = true;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nombre")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.White;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nombre";
                txtName.ForeColor = Color.Gainsboro;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Apellido")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.White;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Apellido";
                txtLastName.ForeColor = Color.Gainsboro;
            }
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
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPassOne_Enter(object sender, EventArgs e)
        {
            if (txtPassOne.Text == "Contraseña")
            {
                txtPassOne.Text = "";
                txtPassOne.ForeColor = Color.White;
                txtPassOne.UseSystemPasswordChar = true;
            }
        }

        private void txtPassOne_Leave(object sender, EventArgs e)
        {
            if (txtPassOne.Text == "")
            {
                txtPassOne.UseSystemPasswordChar = false;
                txtPassOne.Text = "Contraseña";
                txtPassOne.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPassTwo_Enter(object sender, EventArgs e)
        {
            if (txtPassTwo.Text == "Confirmar contraseña")
            {
                txtPassTwo.Text = "";
                txtPassTwo.ForeColor = Color.White;
                txtPassTwo.UseSystemPasswordChar = true;
            }
        }

        private void txtPassTwo_Leave(object sender, EventArgs e)
        {
            if (txtPassTwo.Text == "")
            {
                txtPassTwo.UseSystemPasswordChar = false;
                txtPassTwo.Text = "Confirmar contraseña";
                txtPassTwo.ForeColor = Color.Gainsboro;
            }
        }

        private void txtCareer_Enter(object sender, EventArgs e)
        {
            if (txtCareer.Text == "Carrera")
            {
                txtCareer.Text = "";
                txtCareer.ForeColor = Color.White;
            }
        }

        private void txtCareer_Leave(object sender, EventArgs e)
        {
            if (txtCareer.Text == "")
            {
                txtCareer.Text = "Carrera";
                txtCareer.ForeColor = Color.Gainsboro;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassOne.Text != txtPassTwo.Text)
            {
                lblError.Text = "Las contraseñas no coinciden";
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
                string password = Classes.Encrypt.GetSHA256(txtPassOne.Text);
                Register(txtName.Text, txtLastName.Text, txtEmail.Text, password, txtCareer.Text);
            }
        }

        void Register(string name, string lastName, string email, string pass, string career)
        {
            if (name != "" && lastName != "" && email != "" && pass != "" && career != "" && name != "Nombre" && lastName != "Apellido" && email != "Email" && pass != "Contraseña" && career != "Carrera")
            {
                lblError.Visible = false;
                try
                {
                    using (SchoolStoryEntities db = new SchoolStoryEntities())
                    {
                        Student student = new Student();
                        student.Name = name;
                        student.LastName = lastName;
                        student.Email = email;
                        student.Password = pass;
                        student.Career = career;

                        db.Student.Add(student);
                        db.SaveChanges();

                        MessageBox.Show("Se ha registrado exitosamente. Su ID es " + student.Id);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la base de datos. No se ha podido registrar.");
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
