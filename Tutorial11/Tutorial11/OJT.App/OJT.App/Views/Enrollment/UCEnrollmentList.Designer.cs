namespace OJT.App.Views.Enrollment
{
    partial class UCEnrollmentList
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
            this.lblELIst = new System.Windows.Forms.Label();
            this.dgvEnrollList = new System.Windows.Forms.DataGridView();
            this.gc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet2 = new OJT.App.StudentDBDataSet2();
            this.studentDBDataSet = new OJT.App.StudentDBDataSet();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollments_tbTableAdapter = new OJT.App.StudentDBDataSet2TableAdapters.enrollments_tbTableAdapter();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentstbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.lblELIst);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1564, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblELIst
            // 
            this.lblELIst.AutoSize = true;
            this.lblELIst.Location = new System.Drawing.Point(84, 14);
            this.lblELIst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblELIst.Name = "lblELIst";
            this.lblELIst.Size = new System.Drawing.Size(175, 29);
            this.lblELIst.TabIndex = 0;
            this.lblELIst.Text = "EnrollmentLIst";
            // 
            // dgvEnrollList
            // 
            this.dgvEnrollList.AutoGenerateColumns = false;
            this.dgvEnrollList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gc_id,
            this.studentidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.enrollmentdateDataGridViewTextBoxColumn});
            this.dgvEnrollList.DataSource = this.enrollmentstbBindingSource;
            this.dgvEnrollList.Location = new System.Drawing.Point(0, 121);
            this.dgvEnrollList.Name = "dgvEnrollList";
            this.dgvEnrollList.RowHeadersWidth = 66;
            this.dgvEnrollList.RowTemplate.Height = 29;
            this.dgvEnrollList.Size = new System.Drawing.Size(877, 150);
            this.dgvEnrollList.TabIndex = 1;
            this.dgvEnrollList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollList_CellContentClick);
            // 
            // gc_id
            // 
            this.gc_id.DataPropertyName = "enrollment_id";
            this.gc_id.HeaderText = "enrollment_id";
            this.gc_id.MinimumWidth = 8;
            this.gc_id.Name = "gc_id";
            this.gc_id.ReadOnly = true;
            this.gc_id.Width = 200;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 200;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.Width = 200;
            // 
            // enrollmentdateDataGridViewTextBoxColumn
            // 
            this.enrollmentdateDataGridViewTextBoxColumn.DataPropertyName = "enrollment_date";
            this.enrollmentdateDataGridViewTextBoxColumn.HeaderText = "enrollment_date";
            this.enrollmentdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enrollmentdateDataGridViewTextBoxColumn.Name = "enrollmentdateDataGridViewTextBoxColumn";
            this.enrollmentdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // enrollmentstbBindingSource
            // 
            this.enrollmentstbBindingSource.DataMember = "enrollments_tb";
            this.enrollmentstbBindingSource.DataSource = this.studentDBDataSet2;
            // 
            // studentDBDataSet2
            // 
            this.studentDBDataSet2.DataSetName = "StudentDBDataSet2";
            this.studentDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // enrollments_tbTableAdapter
            // 
            this.enrollments_tbTableAdapter.ClearBeforeFill = true;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(322, 8);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(165, 53);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // UCEnrollmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEnrollList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCEnrollmentList";
            this.Size = new System.Drawing.Size(1597, 1116);
            this.Load += new System.EventHandler(this.UCEnrollmentList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentstbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblELIst;
        private System.Windows.Forms.DataGridView dgvEnrollList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource enrollmentstbBindingSource;
        private StudentDBDataSet2 studentDBDataSet2;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet2TableAdapters.enrollments_tbTableAdapter enrollments_tbTableAdapter;
        private System.Windows.Forms.Button btn_export;
    }
}
