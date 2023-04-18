namespace OJT.App.Views.Menu
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crudStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseCrudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUC = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.courseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1582, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentListToolStripMenuItem,
            this.crudStudentToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(92, 34);
            this.menuToolStripMenuItem.Text = "Student";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.studentListToolStripMenuItem.Text = "StudentList";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // crudStudentToolStripMenuItem
            // 
            this.crudStudentToolStripMenuItem.Name = "crudStudentToolStripMenuItem";
            this.crudStudentToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.crudStudentToolStripMenuItem.Text = "CrudStudent";
            this.crudStudentToolStripMenuItem.Click += new System.EventHandler(this.crudStudentToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseListToolStripMenuItem,
            this.courseCrudToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // courseListToolStripMenuItem
            // 
            this.courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            this.courseListToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.courseListToolStripMenuItem.Text = "CourseList";
            this.courseListToolStripMenuItem.Click += new System.EventHandler(this.courseListToolStripMenuItem_Click);
            // 
            // courseCrudToolStripMenuItem
            // 
            this.courseCrudToolStripMenuItem.Name = "courseCrudToolStripMenuItem";
            this.courseCrudToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.courseCrudToolStripMenuItem.Text = "CourseCrud";
            this.courseCrudToolStripMenuItem.Click += new System.EventHandler(this.courseCrudToolStripMenuItem_Click);
            // 
            // pnUC
            // 
            this.pnUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUC.Location = new System.Drawing.Point(0, 38);
            this.pnUC.Margin = new System.Windows.Forms.Padding(5);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(1582, 1010);
            this.pnUC.TabIndex = 1;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1048);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crudStudentToolStripMenuItem;
        public System.Windows.Forms.Panel pnUC;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseCrudToolStripMenuItem;
    }
}