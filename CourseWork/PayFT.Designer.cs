namespace CourseWork
{
    partial class frmPayFood
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
            this.gbxFood = new System.Windows.Forms.GroupBox();
            this.btnPayFood = new System.Windows.Forms.Button();
            this.tbPayKidsF = new System.Windows.Forms.TextBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblKids = new System.Windows.Forms.Label();
            this.cbbPayKidsF = new System.Windows.Forms.ComboBox();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            this.gbxFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFood
            // 
            this.gbxFood.Controls.Add(this.btnPayFood);
            this.gbxFood.Controls.Add(this.tbPayKidsF);
            this.gbxFood.Controls.Add(this.lblNumbers);
            this.gbxFood.Controls.Add(this.lblKids);
            this.gbxFood.Controls.Add(this.cbbPayKidsF);
            this.gbxFood.Location = new System.Drawing.Point(40, 54);
            this.gbxFood.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFood.Name = "gbxFood";
            this.gbxFood.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFood.Size = new System.Drawing.Size(209, 245);
            this.gbxFood.TabIndex = 0;
            this.gbxFood.TabStop = false;
            this.gbxFood.Text = "Храна";
            // 
            // btnPayFood
            // 
            this.btnPayFood.Location = new System.Drawing.Point(32, 184);
            this.btnPayFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayFood.Name = "btnPayFood";
            this.btnPayFood.Size = new System.Drawing.Size(142, 44);
            this.btnPayFood.TabIndex = 34;
            this.btnPayFood.Text = "Записване";
            this.btnPayFood.UseVisualStyleBackColor = true;
            this.btnPayFood.Click += new System.EventHandler(this.btnPayFood_Click);
            // 
            // tbPayKidsF
            // 
            this.tbPayKidsF.Location = new System.Drawing.Point(84, 126);
            this.tbPayKidsF.Margin = new System.Windows.Forms.Padding(2);
            this.tbPayKidsF.Name = "tbPayKidsF";
            this.tbPayKidsF.Size = new System.Drawing.Size(41, 20);
            this.tbPayKidsF.TabIndex = 3;
            this.tbPayKidsF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayKidsF_KeyPress);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(30, 132);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(33, 13);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.Text = "Пъти";
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Location = new System.Drawing.Point(28, 53);
            this.lblKids.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(33, 13);
            this.lblKids.TabIndex = 1;
            this.lblKids.Text = "Дете";
            // 
            // cbbPayKidsF
            // 
            this.cbbPayKidsF.DataSource = this.childrenBindingSource;
            this.cbbPayKidsF.DisplayMember = "FullName";
            this.cbbPayKidsF.FormattingEnabled = true;
            this.cbbPayKidsF.Location = new System.Drawing.Point(84, 47);
            this.cbbPayKidsF.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPayKidsF.Name = "cbbPayKidsF";
            this.cbbPayKidsF.Size = new System.Drawing.Size(108, 21);
            this.cbbPayKidsF.TabIndex = 0;
            this.cbbPayKidsF.ValueMember = "id";
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
            // childrenTableAdapter
            // 
            this.childrenTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 366);
            this.Controls.Add(this.gbxFood);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayFood";
            this.Text = "Плащане";
            this.Load += new System.EventHandler(this.frmPayFood_Load);
            this.gbxFood.ResumeLayout(false);
            this.gbxFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFood;
        private System.Windows.Forms.TextBox tbPayKidsF;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.ComboBox cbbPayKidsF;
        private System.Windows.Forms.Button btnPayFood;
        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
    }
}