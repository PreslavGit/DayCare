namespace CourseWork
{
    partial class Attendance
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
            this.dgAttendance = new System.Windows.Forms.DataGridView();
            this.btnSubmitAttend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAttendance
            // 
            this.dgAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttendance.Location = new System.Drawing.Point(12, 12);
            this.dgAttendance.Name = "dgAttendance";
            this.dgAttendance.Size = new System.Drawing.Size(446, 243);
            this.dgAttendance.TabIndex = 0;
            // 
            // btnSubmitAttend
            // 
            this.btnSubmitAttend.Location = new System.Drawing.Point(194, 320);
            this.btnSubmitAttend.Name = "btnSubmitAttend";
            this.btnSubmitAttend.Size = new System.Drawing.Size(85, 23);
            this.btnSubmitAttend.TabIndex = 1;
            this.btnSubmitAttend.Text = "Отбелязване";
            this.btnSubmitAttend.UseVisualStyleBackColor = true;
            this.btnSubmitAttend.Click += new System.EventHandler(this.btnSubmitAttend_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnSubmitAttend);
            this.Controls.Add(this.dgAttendance);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAttendance;
        private System.Windows.Forms.Button btnSubmitAttend;
    }
}