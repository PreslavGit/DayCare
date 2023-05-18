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
            this.gbox_pay = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            this.gbox_pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.Location = new System.Drawing.Point(106, 260);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 53);
            this.btnPay.TabIndex = 33;
            this.btnPay.Text = "Записване";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tb_Days
            // 
            this.tb_Days.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Days.Location = new System.Drawing.Point(84, 138);
            this.tb_Days.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Days.Name = "tb_Days";
            this.tb_Days.Size = new System.Drawing.Size(60, 22);
            this.tb_Days.TabIndex = 32;
            this.tb_Days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Days_KeyPress);
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.CalendarMonthBackground = System.Drawing.Color.FloralWhite;
            this.dt_StartDate.Location = new System.Drawing.Point(84, 90);
            this.dt_StartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(169, 22);
            this.dt_StartDate.TabIndex = 31;
            // 
            // lblPayDays
            // 
            this.lblPayDays.AutoSize = true;
            this.lblPayDays.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblPayDays.Location = new System.Drawing.Point(16, 142);
            this.lblPayDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayDays.Name = "lblPayDays";
            this.lblPayDays.Size = new System.Drawing.Size(34, 18);
            this.lblPayDays.TabIndex = 30;
            this.lblPayDays.Text = "Дни";
            // 
            // lblPayFrom
            // 
            this.lblPayFrom.AutoSize = true;
            this.lblPayFrom.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblPayFrom.Location = new System.Drawing.Point(16, 94);
            this.lblPayFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayFrom.Name = "lblPayFrom";
            this.lblPayFrom.Size = new System.Drawing.Size(23, 18);
            this.lblPayFrom.TabIndex = 29;
            this.lblPayFrom.Text = "От";
            // 
            // lbl_Child
            // 
            this.lbl_Child.AutoSize = true;
            this.lbl_Child.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lbl_Child.Location = new System.Drawing.Point(16, 53);
            this.lbl_Child.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child.Name = "lbl_Child";
            this.lbl_Child.Size = new System.Drawing.Size(40, 18);
            this.lbl_Child.TabIndex = 28;
            this.lbl_Child.Text = "Дете";
            // 
            // cbbPay
            // 
            this.cbbPay.DataSource = this.childrenBindingSource;
            this.cbbPay.DisplayMember = "FullName";
            this.cbbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPay.FormattingEnabled = true;
            this.cbbPay.Location = new System.Drawing.Point(84, 47);
            this.cbbPay.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPay.Name = "cbbPay";
            this.cbbPay.Size = new System.Drawing.Size(169, 24);
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
            // gbox_pay
            // 
            this.gbox_pay.Controls.Add(this.lbl_Child);
            this.gbox_pay.Controls.Add(this.lblPayFrom);
            this.gbox_pay.Controls.Add(this.tb_Days);
            this.gbox_pay.Controls.Add(this.lblPayDays);
            this.gbox_pay.Controls.Add(this.dt_StartDate);
            this.gbox_pay.Controls.Add(this.cbbPay);
            this.gbox_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbox_pay.Location = new System.Drawing.Point(22, 28);
            this.gbox_pay.Name = "gbox_pay";
            this.gbox_pay.Size = new System.Drawing.Size(284, 197);
            this.gbox_pay.TabIndex = 34;
            this.gbox_pay.TabStop = false;
            this.gbox_pay.Text = "Плащане за период";
            // 
            // frmPayPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.gbox_pay);
            this.Controls.Add(this.btnPay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayPeriod";
            this.Text = "Плащане за период";
            this.Load += new System.EventHandler(this.frmPayPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            this.gbox_pay.ResumeLayout(false);
            this.gbox_pay.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gbox_pay;
    }
}