namespace CourseWork
{
    partial class SearchGradeDate
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
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgDateGrade = new System.Windows.Forms.DataGridView();
            this.cbDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDateGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dayCareDataSet
            // 
            this.dayCareDataSet.DataSetName = "DayCareDataSet";
            this.dayCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(46, 46);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(39, 16);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Дата";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGrade.Location = new System.Drawing.Point(46, 90);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(38, 16);
            this.lbGrade.TabIndex = 3;
            this.lbGrade.Text = "Клас";
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
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
            "12"});
            this.cbGrade.Location = new System.Drawing.Point(102, 85);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(164, 21);
            this.cbGrade.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(135, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Търсене";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgDateGrade
            // 
            this.dgDateGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDateGrade.Location = new System.Drawing.Point(358, 24);
            this.dgDateGrade.Name = "dgDateGrade";
            this.dgDateGrade.Size = new System.Drawing.Size(386, 164);
            this.dgDateGrade.TabIndex = 5;
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(102, 41);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(164, 21);
            this.cbDate.TabIndex = 6;
            // 
            // SearchGradeDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.dgDateGrade);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lbDate);
            this.Name = "SearchGradeDate";
            this.Text = "Търсене по дата и клас";
            this.Load += new System.EventHandler(this.SearchGradeDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDateGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgDateGrade;
        private System.Windows.Forms.ComboBox cbDate;
    }
}