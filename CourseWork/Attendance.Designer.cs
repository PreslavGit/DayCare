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
            this.lbl_Text = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
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
            this.btnSubmitAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmitAttend.Location = new System.Drawing.Point(171, 346);
            this.btnSubmitAttend.Name = "btnSubmitAttend";
            this.btnSubmitAttend.Size = new System.Drawing.Size(112, 53);
            this.btnSubmitAttend.TabIndex = 1;
            this.btnSubmitAttend.Text = "Отбелязване";
            this.btnSubmitAttend.UseVisualStyleBackColor = true;
            this.btnSubmitAttend.Click += new System.EventHandler(this.btnSubmitAttend_Click);
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Text.Location = new System.Drawing.Point(12, 281);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(89, 13);
            this.lbl_Text.TabIndex = 2;
            this.lbl_Text.Text = "Днешна дата:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date.Location = new System.Drawing.Point(95, 281);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 13);
            this.lbl_Date.TabIndex = 3;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.btnSubmitAttend);
            this.Controls.Add(this.dgAttendance);
            this.Name = "Attendance";
            this.Text = "Присъствия за деня";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAttendance;
        private System.Windows.Forms.Button btnSubmitAttend;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Label lbl_Date;
    }
}