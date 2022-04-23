
namespace CollegeStory.FormsGrades
{
    partial class Grades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grades));
            this.lblCareer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblGrades = new System.Windows.Forms.DataGridView();
            this.codeSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeLetterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSubjectCrossBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolStoryDataSet1 = new CollegeStory.SchoolStoryDataSet1();
            this.schoolStoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolStoryDataSet = new CollegeStory.SchoolStoryDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentSubjectCrossTableAdapter = new CollegeStory.SchoolStoryDataSet1TableAdapters.StudentSubjectCrossTableAdapter();
            this.cmbSemester = new CollegeStory.Classes.CustomComboBox();
            this.studentSubjectCrossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSemester = new CircularProgressBar.CircularProgressBar();
            this.lblGeneral = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCareer.ForeColor = System.Drawing.Color.White;
            this.lblCareer.Location = new System.Drawing.Point(12, 13);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(95, 29);
            this.lblCareer.TabIndex = 0;
            this.lblCareer.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trimestre:";
            // 
            // tblGrades
            // 
            this.tblGrades.AllowUserToAddRows = false;
            this.tblGrades.AllowUserToDeleteRows = false;
            this.tblGrades.AllowUserToResizeColumns = false;
            this.tblGrades.AllowUserToResizeRows = false;
            this.tblGrades.AutoGenerateColumns = false;
            this.tblGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblGrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.tblGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblGrades.ColumnHeadersHeight = 50;
            this.tblGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeSubjectDataGridViewTextBoxColumn,
            this.nameSubjectDataGridViewTextBoxColumn,
            this.gradeLetterDataGridViewTextBoxColumn,
            this.gradeNumberDataGridViewTextBoxColumn});
            this.tblGrades.DataSource = this.studentSubjectCrossBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblGrades.DefaultCellStyle = dataGridViewCellStyle4;
            this.tblGrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblGrades.EnableHeadersVisualStyles = false;
            this.tblGrades.Location = new System.Drawing.Point(12, 66);
            this.tblGrades.MultiSelect = false;
            this.tblGrades.Name = "tblGrades";
            this.tblGrades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblGrades.RowHeadersVisible = false;
            this.tblGrades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.tblGrades.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblGrades.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.tblGrades.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tblGrades.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tblGrades.RowTemplate.Height = 50;
            this.tblGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblGrades.Size = new System.Drawing.Size(987, 372);
            this.tblGrades.TabIndex = 3;
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
            // gradeLetterDataGridViewTextBoxColumn
            // 
            this.gradeLetterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradeLetterDataGridViewTextBoxColumn.DataPropertyName = "GradeLetter";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gradeLetterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gradeLetterDataGridViewTextBoxColumn.HeaderText = "Letra";
            this.gradeLetterDataGridViewTextBoxColumn.Name = "gradeLetterDataGridViewTextBoxColumn";
            this.gradeLetterDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeLetterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gradeLetterDataGridViewTextBoxColumn.Width = 92;
            // 
            // gradeNumberDataGridViewTextBoxColumn
            // 
            this.gradeNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradeNumberDataGridViewTextBoxColumn.DataPropertyName = "GradeNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gradeNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.gradeNumberDataGridViewTextBoxColumn.HeaderText = "Calificación";
            this.gradeNumberDataGridViewTextBoxColumn.Name = "gradeNumberDataGridViewTextBoxColumn";
            this.gradeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gradeNumberDataGridViewTextBoxColumn.Width = 164;
            // 
            // studentSubjectCrossBindingSource1
            // 
            this.studentSubjectCrossBindingSource1.DataMember = "StudentSubjectCross";
            this.studentSubjectCrossBindingSource1.DataSource = this.schoolStoryDataSet1;
            // 
            // schoolStoryDataSet1
            // 
            this.schoolStoryDataSet1.DataSetName = "SchoolStoryDataSet1";
            this.schoolStoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolStoryDataSetBindingSource
            // 
            this.schoolStoryDataSetBindingSource.DataSource = this.schoolStoryDataSet;
            this.schoolStoryDataSetBindingSource.Position = 0;
            // 
            // schoolStoryDataSet
            // 
            this.schoolStoryDataSet.DataSetName = "SchoolStoryDataSet";
            this.schoolStoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Índice trimestral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(768, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Índice general";
            // 
            // studentSubjectCrossTableAdapter
            // 
            this.studentSubjectCrossTableAdapter.ClearBeforeFill = true;
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
            this.cmbSemester.TabIndex = 2;
            this.cmbSemester.Texts = "1";
            this.cmbSemester.OnSelectedIndexChanged += new System.EventHandler(this.cmbSemester_OnSelectedIndexChanged);
            // 
            // studentSubjectCrossBindingSource
            // 
            this.studentSubjectCrossBindingSource.DataSource = typeof(CollegeStory.Database.StudentSubjectCross);
            // 
            // lblSemester
            // 
            this.lblSemester.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.lblSemester.AnimationSpeed = 500;
            this.lblSemester.BackColor = System.Drawing.Color.Transparent;
            this.lblSemester.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.White;
            this.lblSemester.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.lblSemester.InnerMargin = 2;
            this.lblSemester.InnerWidth = -1;
            this.lblSemester.Location = new System.Drawing.Point(66, 485);
            this.lblSemester.MarqueeAnimationSpeed = 2000;
            this.lblSemester.Maximum = 400;
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.lblSemester.OuterMargin = -25;
            this.lblSemester.OuterWidth = 26;
            this.lblSemester.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.lblSemester.ProgressWidth = 25;
            this.lblSemester.SecondaryFont = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSemester.Size = new System.Drawing.Size(130, 130);
            this.lblSemester.StartAngle = 270;
            this.lblSemester.Step = 200;
            this.lblSemester.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.lblSemester.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblSemester.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.lblSemester.SubscriptText = "";
            this.lblSemester.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblSemester.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.lblSemester.SuperscriptText = "";
            this.lblSemester.TabIndex = 8;
            this.lblSemester.Text = "0";
            this.lblSemester.TextMargin = new System.Windows.Forms.Padding(0);
            this.lblSemester.Value = 68;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.lblGeneral.AnimationSpeed = 500;
            this.lblGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneral.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.White;
            this.lblGeneral.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.lblGeneral.InnerMargin = 2;
            this.lblGeneral.InnerWidth = -1;
            this.lblGeneral.Location = new System.Drawing.Point(788, 485);
            this.lblGeneral.MarqueeAnimationSpeed = 2000;
            this.lblGeneral.Maximum = 400;
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.lblGeneral.OuterMargin = -25;
            this.lblGeneral.OuterWidth = 26;
            this.lblGeneral.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.lblGeneral.ProgressWidth = 25;
            this.lblGeneral.SecondaryFont = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGeneral.Size = new System.Drawing.Size(130, 130);
            this.lblGeneral.StartAngle = 270;
            this.lblGeneral.Step = 200;
            this.lblGeneral.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.lblGeneral.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblGeneral.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.lblGeneral.SubscriptText = "";
            this.lblGeneral.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblGeneral.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.lblGeneral.SuperscriptText = "";
            this.lblGeneral.TabIndex = 9;
            this.lblGeneral.Text = "0";
            this.lblGeneral.TextMargin = new System.Windows.Forms.Padding(0);
            this.lblGeneral.Value = 68;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(441, 485);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 400;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 200;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 10;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 68;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(363, 453);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(267, 29);
            this.lblCredits.TabIndex = 11;
            this.lblCredits.Text = "Créditos aprobados de ";
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1011, 627);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lblGeneral);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblGrades);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCareer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grades";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Grades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolStoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSubjectCrossBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.Label label2;
        private Classes.CustomComboBox cmbSemester;
        private System.Windows.Forms.DataGridView tblGrades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource schoolStoryDataSetBindingSource;
        private SchoolStoryDataSet schoolStoryDataSet;
        private System.Windows.Forms.BindingSource studentSubjectCrossBindingSource;
        private SchoolStoryDataSet1 schoolStoryDataSet1;
        private System.Windows.Forms.BindingSource studentSubjectCrossBindingSource1;
        private SchoolStoryDataSet1TableAdapters.StudentSubjectCrossTableAdapter studentSubjectCrossTableAdapter;
        private CircularProgressBar.CircularProgressBar lblSemester;
        private CircularProgressBar.CircularProgressBar lblGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeLetterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeNumberDataGridViewTextBoxColumn;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lblCredits;
    }
}