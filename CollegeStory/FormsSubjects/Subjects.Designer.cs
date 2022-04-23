
namespace CollegeStory.FormsSubjects
{
    partial class Subjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.tblSubjects = new System.Windows.Forms.DataGridView();
            this.studentSubjectCrossBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolStoryDataSet = new CollegeStory.SchoolStoryDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCareer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.studentSubjectCrossTableAdapter = new CollegeStory.SchoolStoryDataSetTableAdapters.StudentSubjectCrossTableAdapter();
            this.codeSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeLetterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSemester = new CollegeStory.Classes.CustomComboBox();
            this.studentSubjectCrossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSubjects
            // 
            this.tblSubjects.AllowUserToAddRows = false;
            this.tblSubjects.AllowUserToDeleteRows = false;
            this.tblSubjects.AllowUserToResizeColumns = false;
            this.tblSubjects.AllowUserToResizeRows = false;
            this.tblSubjects.AutoGenerateColumns = false;
            this.tblSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSubjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.tblSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblSubjects.CausesValidation = false;
            this.tblSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblSubjects.ColumnHeadersHeight = 50;
            this.tblSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeSubjectDataGridViewTextBoxColumn,
            this.nameSubjectDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.gradeLetterDataGridViewTextBoxColumn});
            this.tblSubjects.DataSource = this.studentSubjectCrossBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblSubjects.DefaultCellStyle = dataGridViewCellStyle5;
            this.tblSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblSubjects.EnableHeadersVisualStyles = false;
            this.tblSubjects.Location = new System.Drawing.Point(12, 66);
            this.tblSubjects.MultiSelect = false;
            this.tblSubjects.Name = "tblSubjects";
            this.tblSubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblSubjects.RowHeadersVisible = false;
            this.tblSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.tblSubjects.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tblSubjects.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.tblSubjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblSubjects.RowTemplate.Height = 50;
            this.tblSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSubjects.Size = new System.Drawing.Size(987, 468);
            this.tblSubjects.TabIndex = 7;
            this.tblSubjects.TabStop = false;
            this.tblSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSubjects_CellClick);
            // 
            // studentSubjectCrossBindingSource1
            // 
            this.studentSubjectCrossBindingSource1.DataMember = "StudentSubjectCross";
            this.studentSubjectCrossBindingSource1.DataSource = this.schoolStoryDataSet;
            // 
            // schoolStoryDataSet
            // 
            this.schoolStoryDataSet.DataSetName = "SchoolStoryDataSet";
            this.schoolStoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trimestre:";
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCareer.ForeColor = System.Drawing.Color.White;
            this.lblCareer.Location = new System.Drawing.Point(12, 13);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(95, 29);
            this.lblCareer.TabIndex = 4;
            this.lblCareer.Text = "Carrera";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(144)))), ((int)(((byte)(97)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(687, 552);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(312, 63);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // studentSubjectCrossTableAdapter
            // 
            this.studentSubjectCrossTableAdapter.ClearBeforeFill = true;
            // 
            // codeSubjectDataGridViewTextBoxColumn
            // 
            this.codeSubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeSubjectDataGridViewTextBoxColumn.DataPropertyName = "CodeSubject";
            this.codeSubjectDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeSubjectDataGridViewTextBoxColumn.Name = "codeSubjectDataGridViewTextBoxColumn";
            this.codeSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeSubjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codeSubjectDataGridViewTextBoxColumn.Width = 114;
            // 
            // nameSubjectDataGridViewTextBoxColumn
            // 
            this.nameSubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameSubjectDataGridViewTextBoxColumn.DataPropertyName = "NameSubject";
            this.nameSubjectDataGridViewTextBoxColumn.HeaderText = "Asignatura";
            this.nameSubjectDataGridViewTextBoxColumn.Name = "nameSubjectDataGridViewTextBoxColumn";
            this.nameSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameSubjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.creditsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Créditos";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.creditsDataGridViewTextBoxColumn.Width = 128;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.semesterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Trimestre";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.semesterDataGridViewTextBoxColumn.Width = 141;
            // 
            // gradeLetterDataGridViewTextBoxColumn
            // 
            this.gradeLetterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradeLetterDataGridViewTextBoxColumn.DataPropertyName = "GradeLetter";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gradeLetterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gradeLetterDataGridViewTextBoxColumn.HeaderText = "Calificación";
            this.gradeLetterDataGridViewTextBoxColumn.Name = "gradeLetterDataGridViewTextBoxColumn";
            this.gradeLetterDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeLetterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gradeLetterDataGridViewTextBoxColumn.Width = 164;
            // 
            // cmbSemester
            // 
            this.cmbSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.cmbSemester.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.cmbSemester.BorderSize = 0;
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSemester.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cmbSemester.ForeColor = System.Drawing.Color.White;
            this.cmbSemester.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.cmbSemester.Items.AddRange(new object[] {
            "Todos",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cmbSemester.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.cmbSemester.ListTextColor = System.Drawing.Color.White;
            this.cmbSemester.Location = new System.Drawing.Point(861, 12);
            this.cmbSemester.MinimumSize = new System.Drawing.Size(30, 30);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(138, 30);
            this.cmbSemester.TabIndex = 6;
            this.cmbSemester.Texts = "Todos";
            this.cmbSemester.OnSelectedIndexChanged += new System.EventHandler(this.cmbSemester_OnSelectedIndexChanged);
            // 
            // studentSubjectCrossBindingSource
            // 
            this.studentSubjectCrossBindingSource.DataSource = typeof(CollegeStory.Database.StudentSubjectCross);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1011, 627);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblSubjects);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCareer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subjects";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSubjects;
        private Classes.CustomComboBox cmbSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource studentSubjectCrossBindingSource;
        private SchoolStoryDataSet schoolStoryDataSet;
        private System.Windows.Forms.BindingSource studentSubjectCrossBindingSource1;
        private SchoolStoryDataSetTableAdapters.StudentSubjectCrossTableAdapter studentSubjectCrossTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeLetterDataGridViewTextBoxColumn;
    }
}