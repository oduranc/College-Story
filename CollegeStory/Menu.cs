using FontAwesome.Sharp;
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

namespace CollegeStory.FormsGrades
{
    public partial class Menu : Form
    {
        int id;
        public Menu(int studentId)
        {
            InitializeComponent();
            id = studentId;
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

        public void OpenForm(object formChild, IconButton btn)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            SelectedButton(btn);
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fc);
            this.panelContainer.Tag = fc;
            lblTitle.Text = fc.Text;
            fc.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenForm(new FormsAuthentication.Profile(id), btnProfile);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            OpenForm(new FormsSubjects.Subjects(id), btnSubjects);
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            using (Database.SchoolStoryEntities db = new Database.SchoolStoryEntities())
            {
                if (db.StudentSubjectCross.Where(d => d.IdStudent == id).Count() > 1)
                {
                    OpenForm(new Grades(id), btnGrades);
                }
                else
                {
                    MessageBox.Show("Para ingresar a esta sección debe añadir asignaturas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnProfile_Click(null, e);
            SelectedButton(btnProfile);
        }

        public void SelectedButton(IconButton selected)
        {
            selected.BackColor = Color.FromArgb(0, 160, 220);
            selected.Font = new Font("Roboto", 36, FontStyle.Bold, GraphicsUnit.Pixel);
            DisableButtons(selected);
        }

        void DisableButtons(IconButton selected)
        {
            foreach (Control button in panelMenu.Controls)
            {
                if (button.GetType() == typeof(IconButton))
                {
                    if (button != selected)
                    {
                        button.BackColor = Color.FromArgb(37, 54, 75);
                        button.Font = new Font("Roboto", 36, FontStyle.Regular, GraphicsUnit.Pixel);
                    }
                }
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
