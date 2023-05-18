namespace CourseWork
{
    partial class AttendanceDate
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
            this.calAttendData = new System.Windows.Forms.MonthCalendar();
            this.dgAttendData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendData)).BeginInit();
            this.SuspendLayout();
            // 
            // calAttendData
            // 
            this.calAttendData.BackColor = System.Drawing.Color.GhostWhite;
            this.calAttendData.Location = new System.Drawing.Point(64, 71);
            this.calAttendData.Name = "calAttendData";
            this.calAttendData.TabIndex = 0;
            this.calAttendData.TitleBackColor = System.Drawing.Color.NavajoWhite;
            this.calAttendData.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calAttendData_DateSelected);
            // 
            // dgAttendData
            // 
            this.dgAttendData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttendData.Location = new System.Drawing.Point(331, 24);
            this.dgAttendData.Name = "dgAttendData";
            this.dgAttendData.Size = new System.Drawing.Size(246, 273);
            this.dgAttendData.TabIndex = 1;
            // 
            // AttendanceDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(614, 321);
            this.Controls.Add(this.dgAttendData);
            this.Controls.Add(this.calAttendData);
            this.Name = "AttendanceDate";
            this.Text = "Присъствия по дни";
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calAttendData;
        private System.Windows.Forms.DataGridView dgAttendData;
    }
}