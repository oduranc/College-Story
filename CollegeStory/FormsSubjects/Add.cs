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

namespace CollegeStory.FormsSubjects
{
    public partial class Add : Form
    {
        int id;
        public Add(int studentId)
        {
            InitializeComponent();
            id = studentId;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormsGrades.Menu menu = new FormsGrades.Menu(id);
            menu.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Código")
            {
                txtCode.Text = "";
                txtCode.ForeColor = Color.White;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                txtCode.Text = "Código";
                txtCode.ForeColor = Color.Gainsboro;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtCode.Text.ToUpper());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubject(txtCode.Text.ToUpper(), txtSubject.Text, Convert.ToInt32(numCredits.Value), Convert.ToInt32(numSemester.Value), cmbGrade.Texts.ToString());
        }

        void Search(string code)
        {
            try
            {
                using (SchoolStoryEntities db = new SchoolStoryEntities())
                {
                    int validation = 0;
                    var lst = db.Subject;
                    foreach (var subject in lst)
                    {
                        if (subject.Code == code)
                        {
                            txtSubject.Text = subject.Name;
                            validation = 1;
                            break;
                        }
                        else
                        {
                            txtSubject.Text = "Asignatura";
                            validation = 0;
                        }
                    }
                    if (validation == 0)
                    {
                        MessageBox.Show("Asignatura no encontrada. Verifique el código nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la base de datos. No se puede conectar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddSubject(string code, string subject, int credits, int semester, string grade)
        {
            try
            {
                using (SchoolStoryEntities db = new SchoolStoryEntities())
                {
                    var lst = db.StudentSubjectCross;
                    int validation = 0;
                    foreach (var studentSubject in lst)
                    {
                        if (studentSubject.CodeSubject == code)
                        {
                            validation++;
                            break;
                        }
                    }

                    if (validation == 0)
                    {
                        StudentSubjectCross cross = new StudentSubjectCross();
                        cross.IdStudent = id;
                        cross.CodeSubject = code;
                        cross.NameSubject = subject;
                        cross.Credits = credits;
                        cross.Semester = semester;
                        cross.GradeLetter = grade;

                        Classes.GradeNumber gradeNumber = new Classes.GradeNumber();
                        cross.GradeNumber = gradeNumber.Grade(grade, cross);

                        db.StudentSubjectCross.Add(cross);
                        db.SaveChanges();

                        MessageBox.Show("La asignatura se ha agregado correctamente.", "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La asignatura ya se encuentra registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al añadir la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
