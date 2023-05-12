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
            this.calAttendData.Location = new System.Drawing.Point(55, 18);
            this.calAttendData.Name = "calAttendData";
            this.calAttendData.TabIndex = 0;
            this.calAttendData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calAttendData_DateChanged);
            // 
            // dgAttendData
            // 
            this.dgAttendData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttendData.Location = new System.Drawing.Point(55, 192);
            this.dgAttendData.Name = "dgAttendData";
            this.dgAttendData.Size = new System.Drawing.Size(220, 244);
            this.dgAttendData.TabIndex = 1;
            // 
            // AttendanceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.dgAttendData);
            this.Controls.Add(this.calAttendData);
            this.Name = "AttendanceData";
            this.Text = "AttendanceData";
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calAttendData;
        private System.Windows.Forms.DataGridView dgAttendData;
    }
}