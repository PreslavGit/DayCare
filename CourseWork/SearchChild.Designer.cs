namespace CourseWork
{
    partial class SearchChild
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
            this.cbChildName = new System.Windows.Forms.ComboBox();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            this.lbChildName = new System.Windows.Forms.Label();
            this.dgChildInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChildName
            // 
            this.cbChildName.BackColor = System.Drawing.Color.FloralWhite;
            this.cbChildName.DataSource = this.childrenBindingSource;
            this.cbChildName.DisplayMember = "FullName";
            this.cbChildName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChildName.FormattingEnabled = true;
            this.cbChildName.Location = new System.Drawing.Point(40, 55);
            this.cbChildName.Name = "cbChildName";
            this.cbChildName.Size = new System.Drawing.Size(157, 21);
            this.cbChildName.TabIndex = 0;
            this.cbChildName.TabStop = false;
            this.cbChildName.ValueMember = "id";
            this.cbChildName.SelectedIndexChanged += new System.EventHandler(this.cbChildName_SelectedIndexChanged);
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
            // lbChildName
            // 
            this.lbChildName.AutoSize = true;
            this.lbChildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChildName.Location = new System.Drawing.Point(37, 26);
            this.lbChildName.Name = "lbChildName";
            this.lbChildName.Size = new System.Drawing.Size(87, 16);
            this.lbChildName.TabIndex = 1;
            this.lbChildName.Text = "Име на дете";
            // 
            // dgChildInfo
            // 
            this.dgChildInfo.AllowUserToAddRows = false;
            this.dgChildInfo.AllowUserToDeleteRows = false;
            this.dgChildInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChildInfo.Location = new System.Drawing.Point(40, 113);
            this.dgChildInfo.Name = "dgChildInfo";
            this.dgChildInfo.ReadOnly = true;
            this.dgChildInfo.Size = new System.Drawing.Size(374, 103);
            this.dgChildInfo.TabIndex = 2;
            // 
            // SearchChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.dgChildInfo);
            this.Controls.Add(this.lbChildName);
            this.Controls.Add(this.cbChildName);
            this.Name = "SearchChild";
            this.Text = "Посещения за последен период";
            this.Load += new System.EventHandler(this.SearchChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChildInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChildName;
        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
        private System.Windows.Forms.Label lbChildName;
        private System.Windows.Forms.DataGridView dgChildInfo;
    }
}