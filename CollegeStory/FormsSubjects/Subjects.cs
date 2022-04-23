using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeStory.FormsSubjects
{
    public partial class Subjects : Form
    {
        int id;
        public Subjects(int studentId)
        {
            InitializeComponent();
            id = studentId;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'schoolStoryDataSet.StudentSubjectCross' Puede moverla o quitarla según sea necesario.
            this.studentSubjectCrossTableAdapter.Fill(this.schoolStoryDataSet.StudentSubjectCross, id);
            using (Database.SchoolStoryEntities db = new Database.SchoolStoryEntities())
            {
                lblCareer.Text = db.Student.Find(id).Career;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ParentForm.Visible = false;
            Add add = new Add(id);
            add.Visible = true;
        }

        private void tblSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string code = tblSubjects.Rows[e.RowIndex].Cells[0].Value.ToString();
                string subject = tblSubjects.Rows[e.RowIndex].Cells[1].Value.ToString();
                int credits = Convert.ToInt32(tblSubjects.Rows[e.RowIndex].Cells[2].Value);
                int semester = Convert.ToInt32(tblSubjects.Rows[e.RowIndex].Cells[3].Value);
                string grade = tblSubjects.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.ParentForm.Visible = false;
                Edit edit = new Edit(id, code, subject, credits, semester, grade);
                edit.Visible = true;
            }
        }

        private void cmbSemester_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSemester(cmbSemester.SelectedIndex);
        }

        void SelectSemester(int index)
        {
            if (index == 0)
            {
                this.studentSubjectCrossTableAdapter.Fill(this.schoolStoryDataSet.StudentSubjectCross, id);
            }
            else
            {
                this.studentSubjectCrossTableAdapter.FillBy(this.schoolStoryDataSet.StudentSubjectCross, index - 1, id);
            }
        }
    }
}
