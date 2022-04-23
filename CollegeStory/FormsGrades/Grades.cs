using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeStory.FormsGrades
{
    public partial class Grades : Form
    {
        int id;
        public Grades(int studentId)
        {
            InitializeComponent();
            id = studentId;
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'schoolStoryDataSet1.StudentSubjectCross' Puede moverla o quitarla según sea necesario.
            this.studentSubjectCrossTableAdapter.FillBy(this.schoolStoryDataSet1.StudentSubjectCross, 1, id);

            GradeSemester();
            GradeGeneral();

            using (Database.SchoolStoryEntities db = new Database.SchoolStoryEntities())
            {
                lblCareer.Text = db.Student.Find(id).Career;
            }

            circularProgressBar1.Maximum = Convert.ToInt32(studentSubjectCrossTableAdapter.AllCredits(id));
            circularProgressBar1.Value = Convert.ToInt32(studentSubjectCrossTableAdapter.PassedCredits(id));
            circularProgressBar1.Text = studentSubjectCrossTableAdapter.PassedCredits(id).ToString();
            lblCredits.Text += studentSubjectCrossTableAdapter.AllCredits(id).ToString();
        }

        private void cmbSemester_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSemester(cmbSemester.SelectedIndex);
            GradeSemester();
            GradeGeneral();
        }

        void SelectSemester(int index)
        {
            this.studentSubjectCrossTableAdapter.FillBy(this.schoolStoryDataSet1.StudentSubjectCross, index + 1, id);
        }

        void GradeSemester()
        {
            if (cmbSemester.SelectedIndex < 0)
            {
                lblSemester.Value = Convert.ToInt32((double)this.studentSubjectCrossTableAdapter.GradeSemester(1, id) * 100);
                lblSemester.Text = this.studentSubjectCrossTableAdapter.GradeSemester(1, id).ToString();
            }
            else
            {
                if (this.studentSubjectCrossTableAdapter.GradeSemester(cmbSemester.SelectedIndex + 1, id) != null)
                {
                    lblSemester.Value = Convert.ToInt32((double)this.studentSubjectCrossTableAdapter.GradeSemester(cmbSemester.SelectedIndex + 1, id) * 100);
                    lblSemester.Text = this.studentSubjectCrossTableAdapter.GradeSemester(cmbSemester.SelectedIndex + 1, id).ToString();
                }
                else
                {
                    lblSemester.Value = 0;
                    lblSemester.Text = "NaN";
                }
            }
        }

        void GradeGeneral()
        {
            double? sum = 0;
            double? prom;
            int i = 1;
            while (this.studentSubjectCrossTableAdapter.GradeSemester(i, id) != null)
            {
                sum += (double)this.studentSubjectCrossTableAdapter.GradeSemester(i, id);
                i++;
            }
            prom = Math.Round((double)sum / (i - 1), 2, MidpointRounding.AwayFromZero);
            lblGeneral.Value = Convert.ToInt32(prom * 100);
            lblGeneral.Text = prom.ToString();
        }
    }
}
