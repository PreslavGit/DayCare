namespace CourseWork
{
    partial class frmPayPeriod
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
            this.btnPay = new System.Windows.Forms.Button();
            this.tb_Days = new System.Windows.Forms.TextBox();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayDays = new System.Windows.Forms.Label();
            this.lblPayFrom = new System.Windows.Forms.Label();
            this.lbl_Child = new System.Windows.Forms.Label();
            this.cbbPay = new System.Windows.Forms.ComboBox();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.paymentsTableAdapter = new CourseWork.DayCareDataSetTableAdapters.PaymentsTableAdapter();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(76, 267);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(142, 44);
            this.btnPay.TabIndex = 33;
            this.btnPay.Text = "Записване";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tb_Days
            // 
            this.tb_Days.Location = new System.Drawing.Point(127, 128);
            this.tb_Days.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Days.Name = "tb_Days";
            this.tb_Days.Size = new System.Drawing.Size(144, 20);
            this.tb_Days.TabIndex = 32;
            this.tb_Days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Days_KeyPress);
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(127, 80);
            this.dt_StartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(151, 20);
            this.dt_StartDate.TabIndex = 31;
            // 
            // lblPayDays
            // 
            this.lblPayDays.AutoSize = true;
            this.lblPayDays.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lblPayDays.Location = new System.Drawing.Point(9, 128);
            this.lblPayDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayDays.Name = "lblPayDays";
            this.lblPayDays.Size = new System.Drawing.Size(38, 22);
            this.lblPayDays.TabIndex = 30;
            this.lblPayDays.Text = "Дни";
            // 
            // lblPayFrom
            // 
            this.lblPayFrom.AutoSize = true;
            this.lblPayFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lblPayFrom.Location = new System.Drawing.Point(9, 77);
            this.lblPayFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayFrom.Name = "lblPayFrom";
            this.lblPayFrom.Size = new System.Drawing.Size(28, 22);
            this.lblPayFrom.TabIndex = 29;
            this.lblPayFrom.Text = "От";
            // 
            // lbl_Child
            // 
            this.lbl_Child.AutoSize = true;
            this.lbl_Child.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child.Location = new System.Drawing.Point(9, 23);
            this.lbl_Child.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child.Name = "lbl_Child";
            this.lbl_Child.Size = new System.Drawing.Size(46, 22);
            this.lbl_Child.TabIndex = 28;
            this.lbl_Child.Text = "Дете";
            // 
            // cbbPay
            // 
            this.cbbPay.DataSource = this.childrenBindingSource;
            this.cbbPay.DisplayMember = "FullName";
            this.cbbPay.FormattingEnabled = true;
            this.cbbPay.Location = new System.Drawing.Point(127, 23);
            this.cbbPay.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPay.Name = "cbbPay";
            this.cbbPay.Size = new System.Drawing.Size(144, 21);
            this.cbbPay.TabIndex = 27;
            this.cbbPay.ValueMember = "id";
            // 
            // childrenBindingSource
            // 
            this.childrenBindingSource.DataMember = "Children";
            this.childrenBindingSource.DataSource = this.dayCareDataSet;
            // 
            // dayCareDataSet
            // 
            this.dayCareDataSet.DataSetName = "DayCareDataSet";
            this.dayCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // childrenTableAdapter
            // 
            this.childrenTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 366);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tb_Days);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.lblPayDays);
            this.Controls.Add(this.lblPayFrom);
            this.Controls.Add(this.lbl_Child);
            this.Controls.Add(this.cbbPay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayPeriod";
            this.Text = "Плащане";
            this.Load += new System.EventHandler(this.frmPayPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox tb_Days;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.Label lblPayDays;
        private System.Windows.Forms.Label lblPayFrom;
        private System.Windows.Forms.Label lbl_Child;
        private System.Windows.Forms.ComboBox cbbPay;
        private DayCareDataSet dayCareDataSet;
        private DayCareDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
    }
}