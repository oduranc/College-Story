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
    public partial class Edit : Form
    {
        int id, credits, semester;
        string code, subject, grade;

        public Edit(int idStudent, string codeSubject, string nameSubject, int creditsSubject, int semesterSubject, string gradeSubject)
        {
            InitializeComponent();
            id = idStudent;
            code = codeSubject;
            subject = nameSubject;
            credits = creditsSubject;
            semester = semesterSubject;
            grade = gradeSubject;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Edit_Load(object sender, EventArgs e)
        {
            txtCode.Text = code;
            txtSubject.Text = subject;
            numCredits.Value = credits;
            numSemester.Value = semester;
            cmbGrade.Texts = grade;
        }

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSubject();
        }

        void EditSubject()
        {
            code = txtCode.Text;
            subject = txtSubject.Text;
            credits = Convert.ToInt32(numCredits.Value);
            semester = Convert.ToInt32(numSemester.Value);
            grade = cmbGrade.Texts;

            try
            {
                using (SchoolStoryEntities db = new SchoolStoryEntities())
                {
                    StudentSubjectCross cross = db.StudentSubjectCross.Where(d => d.CodeSubject == code).First();
                    cross.Credits = credits;
                    cross.Semester = semester;
                    cross.GradeLetter = grade;

                    Classes.GradeNumber gradeNumber = new Classes.GradeNumber();
                    cross.GradeNumber = gradeNumber.Grade(grade, cross);

                    db.Entry(cross).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("La asignatura se ha editado correctamente.", "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Visible = false;
                FormsGrades.Menu menu = new FormsGrades.Menu(id);
                menu.Visible = true;
                menu.OpenForm(new Subjects(id), menu.btnSubjects);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DeleteSubject()
        {
            try
            {
                using (SchoolStoryEntities db = new SchoolStoryEntities())
                {
                    StudentSubjectCross cross = db.StudentSubjectCross.Where(d => d.CodeSubject == code).First();;

                    db.StudentSubjectCross.Remove(cross);
                    db.SaveChanges();

                    MessageBox.Show("La asignatura se ha eliminado correctamente.", "Perfecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Visible = false;
                FormsGrades.Menu menu = new FormsGrades.Menu(id);
                menu.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
