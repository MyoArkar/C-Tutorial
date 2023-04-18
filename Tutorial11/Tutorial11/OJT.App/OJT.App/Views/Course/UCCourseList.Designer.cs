namespace OJT.App.Views.Course
{
    partial class UCCourseList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.lbl_courseLIst = new System.Windows.Forms.Label();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.coursetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1 = new OJT.App.StudentDBDataSet1();
            this.course_tbTableAdapter = new OJT.App.StudentDBDataSet1TableAdapters.course_tbTableAdapter();
            this.gc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursehoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addnew);
            this.panel1.Controls.Add(this.lbl_courseLIst);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 92);
            this.panel1.TabIndex = 0;
            // 
            // btn_addnew
            // 
            this.btn_addnew.Location = new System.Drawing.Point(422, 19);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(142, 55);
            this.btn_addnew.TabIndex = 1;
            this.btn_addnew.Text = "AddNew";
            this.btn_addnew.UseVisualStyleBackColor = true;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // lbl_courseLIst
            // 
            this.lbl_courseLIst.AutoSize = true;
            this.lbl_courseLIst.Location = new System.Drawing.Point(66, 32);
            this.lbl_courseLIst.Name = "lbl_courseLIst";
            this.lbl_courseLIst.Size = new System.Drawing.Size(134, 29);
            this.lbl_courseLIst.TabIndex = 0;
            this.lbl_courseLIst.Text = "CourseList";
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AutoGenerateColumns = false;
            this.dgvCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gc_id,
            this.coursenameDataGridViewTextBoxColumn,
            this.coursehoursDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.coursepriceDataGridViewTextBoxColumn,
            this.coursedescriptionDataGridViewTextBoxColumn});
            this.dgvCourseList.DataSource = this.coursetbBindingSource;
            this.dgvCourseList.Location = new System.Drawing.Point(6, 105);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowHeadersWidth = 66;
            this.dgvCourseList.RowTemplate.Height = 29;
            this.dgvCourseList.Size = new System.Drawing.Size(909, 347);
            this.dgvCourseList.TabIndex = 1;
            this.dgvCourseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseList_CellContentClick);
            // 
            // coursetbBindingSource
            // 
            this.coursetbBindingSource.DataMember = "course_tb";
            this.coursetbBindingSource.DataSource = this.studentDBDataSet1;
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "StudentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_tbTableAdapter
            // 
            this.course_tbTableAdapter.ClearBeforeFill = true;
            // 
            // gc_id
            // 
            this.gc_id.DataPropertyName = "course_id";
            this.gc_id.HeaderText = "course_id";
            this.gc_id.MinimumWidth = 8;
            this.gc_id.Name = "gc_id";
            this.gc_id.ReadOnly = true;
            this.gc_id.Width = 160;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursenameDataGridViewTextBoxColumn.Width = 200;
            // 
            // coursehoursDataGridViewTextBoxColumn
            // 
            this.coursehoursDataGridViewTextBoxColumn.DataPropertyName = "course_hours";
            this.coursehoursDataGridViewTextBoxColumn.HeaderText = "course_hours";
            this.coursehoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursehoursDataGridViewTextBoxColumn.Name = "coursehoursDataGridViewTextBoxColumn";
            this.coursehoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursehoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.enddateDataGridViewTextBoxColumn.Width = 160;
            // 
            // coursepriceDataGridViewTextBoxColumn
            // 
            this.coursepriceDataGridViewTextBoxColumn.DataPropertyName = "course_price";
            this.coursepriceDataGridViewTextBoxColumn.HeaderText = "course_price";
            this.coursepriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursepriceDataGridViewTextBoxColumn.Name = "coursepriceDataGridViewTextBoxColumn";
            this.coursepriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursepriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // coursedescriptionDataGridViewTextBoxColumn
            // 
            this.coursedescriptionDataGridViewTextBoxColumn.DataPropertyName = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.HeaderText = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursedescriptionDataGridViewTextBoxColumn.Name = "coursedescriptionDataGridViewTextBoxColumn";
            this.coursedescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursedescriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // UCCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCourseList";
            this.Size = new System.Drawing.Size(1539, 973);
            this.Load += new System.EventHandler(this.UCCourseList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_courseLIst;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.BindingSource coursetbBindingSource;
        private StudentDBDataSet1 studentDBDataSet1;
        private StudentDBDataSet1TableAdapters.course_tbTableAdapter course_tbTableAdapter;
        private System.Windows.Forms.Button btn_addnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursehoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursedescriptionDataGridViewTextBoxColumn;
    }
}
