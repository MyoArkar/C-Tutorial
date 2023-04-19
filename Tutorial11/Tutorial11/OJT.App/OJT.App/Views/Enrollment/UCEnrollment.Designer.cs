namespace OJT.App.Views.Enrollment
{
    partial class UCEnrollment
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
            this.lblEnroll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_studentid = new System.Windows.Forms.TextBox();
            this.studentDBDataSet3 = new OJT.App.StudentDBDataSet3();
            this.coursetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_tbTableAdapter = new OJT.App.StudentDBDataSet3TableAdapters.course_tbTableAdapter();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.studentDBDataSet4 = new OJT.App.StudentDBDataSet4();
            this.coursetbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.course_tbTableAdapter1 = new OJT.App.StudentDBDataSet4TableAdapters.course_tbTableAdapter();
            this.dgv_courseLIst = new System.Windows.Forms.DataGridView();
            this.gc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursehoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseLIst)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblEnroll);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 91);
            this.panel1.TabIndex = 0;
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Location = new System.Drawing.Point(57, 28);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(129, 29);
            this.lblEnroll.TabIndex = 0;
            this.lblEnroll.Text = "Enrollment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student_id";
            // 
            // txt_studentid
            // 
            this.txt_studentid.Location = new System.Drawing.Point(367, 132);
            this.txt_studentid.Name = "txt_studentid";
            this.txt_studentid.ReadOnly = true;
            this.txt_studentid.Size = new System.Drawing.Size(374, 36);
            this.txt_studentid.TabIndex = 4;
            // 
            // studentDBDataSet3
            // 
            this.studentDBDataSet3.DataSetName = "StudentDBDataSet3";
            this.studentDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursetbBindingSource
            // 
            this.coursetbBindingSource.DataMember = "course_tb";
            this.coursetbBindingSource.DataSource = this.studentDBDataSet3;
            // 
            // course_tbTableAdapter
            // 
            this.course_tbTableAdapter.ClearBeforeFill = true;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(377, 484);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(132, 50);
            this.btn_enroll.TabIndex = 7;
            this.btn_enroll.Text = "Enroll";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "CourseList";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "CourseName";
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(367, 394);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.ReadOnly = true;
            this.txt_cname.Size = new System.Drawing.Size(374, 36);
            this.txt_cname.TabIndex = 11;
            // 
            // studentDBDataSet4
            // 
            this.studentDBDataSet4.DataSetName = "StudentDBDataSet4";
            this.studentDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursetbBindingSource1
            // 
            this.coursetbBindingSource1.DataMember = "course_tb";
            this.coursetbBindingSource1.DataSource = this.studentDBDataSet4;
            // 
            // course_tbTableAdapter1
            // 
            this.course_tbTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv_courseLIst
            // 
            this.dgv_courseLIst.AutoGenerateColumns = false;
            this.dgv_courseLIst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseLIst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gc_id,
            this.gc_name,
            this.coursehoursDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.coursepriceDataGridViewTextBoxColumn,
            this.coursedescriptionDataGridViewTextBoxColumn});
            this.dgv_courseLIst.DataSource = this.coursetbBindingSource1;
            this.dgv_courseLIst.Location = new System.Drawing.Point(310, 214);
            this.dgv_courseLIst.Name = "dgv_courseLIst";
            this.dgv_courseLIst.RowHeadersWidth = 66;
            this.dgv_courseLIst.RowTemplate.Height = 29;
            this.dgv_courseLIst.Size = new System.Drawing.Size(680, 150);
            this.dgv_courseLIst.TabIndex = 12;
            this.dgv_courseLIst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_courseLIst_CellContentClick);
            // 
            // gc_id
            // 
            this.gc_id.DataPropertyName = "course_id";
            this.gc_id.HeaderText = "course_id";
            this.gc_id.MinimumWidth = 8;
            this.gc_id.Name = "gc_id";
            this.gc_id.Width = 160;
            // 
            // gc_name
            // 
            this.gc_name.DataPropertyName = "course_name";
            this.gc_name.HeaderText = "course_name";
            this.gc_name.MinimumWidth = 8;
            this.gc_name.Name = "gc_name";
            this.gc_name.Width = 160;
            // 
            // coursehoursDataGridViewTextBoxColumn
            // 
            this.coursehoursDataGridViewTextBoxColumn.DataPropertyName = "course_hours";
            this.coursehoursDataGridViewTextBoxColumn.HeaderText = "course_hours";
            this.coursehoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursehoursDataGridViewTextBoxColumn.Name = "coursehoursDataGridViewTextBoxColumn";
            this.coursehoursDataGridViewTextBoxColumn.Width = 160;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.Width = 160;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "end_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.Width = 160;
            // 
            // coursepriceDataGridViewTextBoxColumn
            // 
            this.coursepriceDataGridViewTextBoxColumn.DataPropertyName = "course_price";
            this.coursepriceDataGridViewTextBoxColumn.HeaderText = "course_price";
            this.coursepriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursepriceDataGridViewTextBoxColumn.Name = "coursepriceDataGridViewTextBoxColumn";
            this.coursepriceDataGridViewTextBoxColumn.Width = 160;
            // 
            // coursedescriptionDataGridViewTextBoxColumn
            // 
            this.coursedescriptionDataGridViewTextBoxColumn.DataPropertyName = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.HeaderText = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursedescriptionDataGridViewTextBoxColumn.Name = "coursedescriptionDataGridViewTextBoxColumn";
            this.coursedescriptionDataGridViewTextBoxColumn.Width = 160;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(606, 484);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(158, 50);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_courseLIst);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.txt_studentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCEnrollment";
            this.Size = new System.Drawing.Size(1595, 1060);
            this.Load += new System.EventHandler(this.UCEnrollment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseLIst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_studentid;
        private System.Windows.Forms.BindingSource coursetbBindingSource;
        private StudentDBDataSet3 studentDBDataSet3;
        private StudentDBDataSet3TableAdapters.course_tbTableAdapter course_tbTableAdapter;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cname;
        private StudentDBDataSet4 studentDBDataSet4;
        private System.Windows.Forms.BindingSource coursetbBindingSource1;
        private StudentDBDataSet4TableAdapters.course_tbTableAdapter course_tbTableAdapter1;
        private System.Windows.Forms.DataGridView dgv_courseLIst;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursehoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
