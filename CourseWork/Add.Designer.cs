﻿namespace CourseWork
{
    partial class form_Add_Parent
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
            this.tb_Parent_Name = new System.Windows.Forms.TextBox();
            this.tb_Parent_Phone = new System.Windows.Forms.TextBox();
            this.tb_Parent_Email = new System.Windows.Forms.TextBox();
            this.tb_Parent_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Parent_Name = new System.Windows.Forms.Label();
            this.lbl_Parent_LastName = new System.Windows.Forms.Label();
            this.lbl_Parent_Email = new System.Windows.Forms.Label();
            this.lbl_Parent_Phone = new System.Windows.Forms.Label();
            this.lbl_Parent_Relative = new System.Windows.Forms.Label();
            this.tb_Parent_Relative_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Parent_Relative_Phone = new System.Windows.Forms.Label();
            this.btn_Add_Parent = new System.Windows.Forms.Button();
            this.tb_Child_Grade = new System.Windows.Forms.TextBox();
            this.lbl_Child_Grade = new System.Windows.Forms.Label();
            this.lbl_Child_Age = new System.Windows.Forms.Label();
            this.tb_Child_LastName = new System.Windows.Forms.TextBox();
            this.tb_Child_Name = new System.Windows.Forms.TextBox();
            this.lbl_Child_LastName = new System.Windows.Forms.Label();
            this.lbl_Child_Name = new System.Windows.Forms.Label();
            this.lbl_Child_Parent = new System.Windows.Forms.Label();
            this.cbb_Child_Parent = new System.Windows.Forms.ComboBox();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.tb_Child_Info = new System.Windows.Forms.TextBox();
            this.groupBox_Child_Info = new System.Windows.Forms.GroupBox();
            this.btn_Add_Child = new System.Windows.Forms.Button();
            this.parentsTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ParentsTableAdapter();
            this.tb_Parent_Relative_Relation = new System.Windows.Forms.TextBox();
            this.relativesTableAdapter = new CourseWork.DayCareDataSetTableAdapters.RelativesTableAdapter();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            this.tb_Child_Age = new System.Windows.Forms.TextBox();
            this.groupBox_par = new System.Windows.Forms.GroupBox();
            this.groupBox_Child = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            this.groupBox_Child_Info.SuspendLayout();
            this.groupBox_par.SuspendLayout();
            this.groupBox_Child.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Parent_Name
            // 
            this.tb_Parent_Name.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_Name.Location = new System.Drawing.Point(100, 38);
            this.tb_Parent_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_Name.Multiline = true;
            this.tb_Parent_Name.Name = "tb_Parent_Name";
            this.tb_Parent_Name.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_Name.TabIndex = 1;
            // 
            // tb_Parent_Phone
            // 
            this.tb_Parent_Phone.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_Phone.Location = new System.Drawing.Point(100, 141);
            this.tb_Parent_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_Phone.MaxLength = 10;
            this.tb_Parent_Phone.Multiline = true;
            this.tb_Parent_Phone.Name = "tb_Parent_Phone";
            this.tb_Parent_Phone.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_Phone.TabIndex = 4;
            // 
            // tb_Parent_Email
            // 
            this.tb_Parent_Email.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_Email.Location = new System.Drawing.Point(100, 106);
            this.tb_Parent_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_Email.Multiline = true;
            this.tb_Parent_Email.Name = "tb_Parent_Email";
            this.tb_Parent_Email.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_Email.TabIndex = 3;
            // 
            // tb_Parent_LastName
            // 
            this.tb_Parent_LastName.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_LastName.Location = new System.Drawing.Point(100, 72);
            this.tb_Parent_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_LastName.Multiline = true;
            this.tb_Parent_LastName.Name = "tb_Parent_LastName";
            this.tb_Parent_LastName.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_LastName.TabIndex = 2;
            // 
            // lbl_Parent_Name
            // 
            this.lbl_Parent_Name.AutoSize = true;
            this.lbl_Parent_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Parent_Name.Location = new System.Drawing.Point(5, 40);
            this.lbl_Parent_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_Name.Name = "lbl_Parent_Name";
            this.lbl_Parent_Name.Size = new System.Drawing.Size(41, 22);
            this.lbl_Parent_Name.TabIndex = 6;
            this.lbl_Parent_Name.Text = "Име";
            // 
            // lbl_Parent_LastName
            // 
            this.lbl_Parent_LastName.AutoSize = true;
            this.lbl_Parent_LastName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Parent_LastName.Location = new System.Drawing.Point(5, 74);
            this.lbl_Parent_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_LastName.Name = "lbl_Parent_LastName";
            this.lbl_Parent_LastName.Size = new System.Drawing.Size(76, 22);
            this.lbl_Parent_LastName.TabIndex = 7;
            this.lbl_Parent_LastName.Text = "Фамилия";
            // 
            // lbl_Parent_Email
            // 
            this.lbl_Parent_Email.AutoSize = true;
            this.lbl_Parent_Email.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Parent_Email.Location = new System.Drawing.Point(5, 108);
            this.lbl_Parent_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_Email.Name = "lbl_Parent_Email";
            this.lbl_Parent_Email.Size = new System.Drawing.Size(49, 22);
            this.lbl_Parent_Email.TabIndex = 8;
            this.lbl_Parent_Email.Text = "Email";
            // 
            // lbl_Parent_Phone
            // 
            this.lbl_Parent_Phone.AutoSize = true;
            this.lbl_Parent_Phone.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Parent_Phone.Location = new System.Drawing.Point(5, 143);
            this.lbl_Parent_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_Phone.Name = "lbl_Parent_Phone";
            this.lbl_Parent_Phone.Size = new System.Drawing.Size(76, 22);
            this.lbl_Parent_Phone.TabIndex = 9;
            this.lbl_Parent_Phone.Text = "Телефон";
            // 
            // lbl_Parent_Relative
            // 
            this.lbl_Parent_Relative.AutoSize = true;
            this.lbl_Parent_Relative.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Parent_Relative.Location = new System.Drawing.Point(5, 177);
            this.lbl_Parent_Relative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_Relative.Name = "lbl_Parent_Relative";
            this.lbl_Parent_Relative.Size = new System.Drawing.Size(70, 22);
            this.lbl_Parent_Relative.TabIndex = 10;
            this.lbl_Parent_Relative.Text = "Роднина";
            // 
            // tb_Parent_Relative_Phone
            // 
            this.tb_Parent_Relative_Phone.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_Relative_Phone.Location = new System.Drawing.Point(100, 229);
            this.tb_Parent_Relative_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_Relative_Phone.MaxLength = 10;
            this.tb_Parent_Relative_Phone.Multiline = true;
            this.tb_Parent_Relative_Phone.Name = "tb_Parent_Relative_Phone";
            this.tb_Parent_Relative_Phone.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_Relative_Phone.TabIndex = 6;
            // 
            // lbl_Parent_Relative_Phone
            // 
            this.lbl_Parent_Relative_Phone.AutoSize = true;
            this.lbl_Parent_Relative_Phone.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Parent_Relative_Phone.Location = new System.Drawing.Point(5, 209);
            this.lbl_Parent_Relative_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Parent_Relative_Phone.Name = "lbl_Parent_Relative_Phone";
            this.lbl_Parent_Relative_Phone.Size = new System.Drawing.Size(91, 44);
            this.lbl_Parent_Relative_Phone.TabIndex = 12;
            this.lbl_Parent_Relative_Phone.Text = "Телефон \r\nна роднина";
            // 
            // btn_Add_Parent
            // 
            this.btn_Add_Parent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add_Parent.Location = new System.Drawing.Point(107, 295);
            this.btn_Add_Parent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Parent.Name = "btn_Add_Parent";
            this.btn_Add_Parent.Size = new System.Drawing.Size(103, 53);
            this.btn_Add_Parent.TabIndex = 7;
            this.btn_Add_Parent.Text = "Въвеждане";
            this.btn_Add_Parent.UseVisualStyleBackColor = true;
            this.btn_Add_Parent.Click += new System.EventHandler(this.btn_Add_Parent_Click);
            // 
            // tb_Child_Grade
            // 
            this.tb_Child_Grade.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Child_Grade.Location = new System.Drawing.Point(107, 177);
            this.tb_Child_Grade.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Child_Grade.Multiline = true;
            this.tb_Child_Grade.Name = "tb_Child_Grade";
            this.tb_Child_Grade.Size = new System.Drawing.Size(174, 24);
            this.tb_Child_Grade.TabIndex = 12;
            // 
            // lbl_Child_Grade
            // 
            this.lbl_Child_Grade.AutoSize = true;
            this.lbl_Child_Grade.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child_Grade.Location = new System.Drawing.Point(5, 177);
            this.lbl_Child_Grade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child_Grade.Name = "lbl_Child_Grade";
            this.lbl_Child_Grade.Size = new System.Drawing.Size(45, 22);
            this.lbl_Child_Grade.TabIndex = 26;
            this.lbl_Child_Grade.Text = "Клас";
            // 
            // lbl_Child_Age
            // 
            this.lbl_Child_Age.AutoSize = true;
            this.lbl_Child_Age.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child_Age.Location = new System.Drawing.Point(5, 143);
            this.lbl_Child_Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child_Age.Name = "lbl_Child_Age";
            this.lbl_Child_Age.Size = new System.Drawing.Size(62, 22);
            this.lbl_Child_Age.TabIndex = 24;
            this.lbl_Child_Age.Text = "Години";
            // 
            // tb_Child_LastName
            // 
            this.tb_Child_LastName.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Child_LastName.Location = new System.Drawing.Point(107, 106);
            this.tb_Child_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Child_LastName.Multiline = true;
            this.tb_Child_LastName.Name = "tb_Child_LastName";
            this.tb_Child_LastName.Size = new System.Drawing.Size(174, 24);
            this.tb_Child_LastName.TabIndex = 10;
            // 
            // tb_Child_Name
            // 
            this.tb_Child_Name.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Child_Name.Location = new System.Drawing.Point(107, 72);
            this.tb_Child_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Child_Name.Multiline = true;
            this.tb_Child_Name.Name = "tb_Child_Name";
            this.tb_Child_Name.Size = new System.Drawing.Size(174, 24);
            this.tb_Child_Name.TabIndex = 9;
            // 
            // lbl_Child_LastName
            // 
            this.lbl_Child_LastName.AutoSize = true;
            this.lbl_Child_LastName.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child_LastName.Location = new System.Drawing.Point(5, 108);
            this.lbl_Child_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child_LastName.Name = "lbl_Child_LastName";
            this.lbl_Child_LastName.Size = new System.Drawing.Size(76, 22);
            this.lbl_Child_LastName.TabIndex = 21;
            this.lbl_Child_LastName.Text = "Фамилия";
            // 
            // lbl_Child_Name
            // 
            this.lbl_Child_Name.AutoSize = true;
            this.lbl_Child_Name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Child_Name.Location = new System.Drawing.Point(5, 74);
            this.lbl_Child_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child_Name.Name = "lbl_Child_Name";
            this.lbl_Child_Name.Size = new System.Drawing.Size(41, 22);
            this.lbl_Child_Name.TabIndex = 20;
            this.lbl_Child_Name.Text = "Име";
            // 
            // lbl_Child_Parent
            // 
            this.lbl_Child_Parent.AutoSize = true;
            this.lbl_Child_Parent.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child_Parent.Location = new System.Drawing.Point(5, 40);
            this.lbl_Child_Parent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Child_Parent.Name = "lbl_Child_Parent";
            this.lbl_Child_Parent.Size = new System.Drawing.Size(80, 22);
            this.lbl_Child_Parent.TabIndex = 19;
            this.lbl_Child_Parent.Text = "Родители";
            // 
            // cbb_Child_Parent
            // 
            this.cbb_Child_Parent.BackColor = System.Drawing.Color.FloralWhite;
            this.cbb_Child_Parent.DataSource = this.parentsBindingSource;
            this.cbb_Child_Parent.DisplayMember = "FullName";
            this.cbb_Child_Parent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Child_Parent.FormattingEnabled = true;
            this.cbb_Child_Parent.Location = new System.Drawing.Point(107, 38);
            this.cbb_Child_Parent.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Child_Parent.Name = "cbb_Child_Parent";
            this.cbb_Child_Parent.Size = new System.Drawing.Size(174, 28);
            this.cbb_Child_Parent.TabIndex = 8;
            this.cbb_Child_Parent.ValueMember = "id";
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "Parents";
            this.parentsBindingSource.DataSource = this.dayCareDataSet;
            // 
            // dayCareDataSet
            // 
            this.dayCareDataSet.DataSetName = "DayCareDataSet";
            this.dayCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Child_Info
            // 
            this.tb_Child_Info.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Child_Info.Location = new System.Drawing.Point(4, 39);
            this.tb_Child_Info.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Child_Info.Multiline = true;
            this.tb_Child_Info.Name = "tb_Child_Info";
            this.tb_Child_Info.Size = new System.Drawing.Size(264, 28);
            this.tb_Child_Info.TabIndex = 0;
            // 
            // groupBox_Child_Info
            // 
            this.groupBox_Child_Info.Controls.Add(this.tb_Child_Info);
            this.groupBox_Child_Info.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.groupBox_Child_Info.Location = new System.Drawing.Point(19, 209);
            this.groupBox_Child_Info.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Child_Info.Name = "groupBox_Child_Info";
            this.groupBox_Child_Info.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Child_Info.Size = new System.Drawing.Size(272, 82);
            this.groupBox_Child_Info.TabIndex = 13;
            this.groupBox_Child_Info.TabStop = false;
            this.groupBox_Child_Info.Text = "Информация";
            // 
            // btn_Add_Child
            // 
            this.btn_Add_Child.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add_Child.Location = new System.Drawing.Point(107, 295);
            this.btn_Add_Child.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Child.Name = "btn_Add_Child";
            this.btn_Add_Child.Size = new System.Drawing.Size(103, 53);
            this.btn_Add_Child.TabIndex = 14;
            this.btn_Add_Child.Text = "Въвеждане";
            this.btn_Add_Child.UseVisualStyleBackColor = true;
            this.btn_Add_Child.Click += new System.EventHandler(this.btn_Add_Child_Click);
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // tb_Parent_Relative_Relation
            // 
            this.tb_Parent_Relative_Relation.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Parent_Relative_Relation.Location = new System.Drawing.Point(100, 177);
            this.tb_Parent_Relative_Relation.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Parent_Relative_Relation.Multiline = true;
            this.tb_Parent_Relative_Relation.Name = "tb_Parent_Relative_Relation";
            this.tb_Parent_Relative_Relation.Size = new System.Drawing.Size(174, 24);
            this.tb_Parent_Relative_Relation.TabIndex = 5;
            // 
            // relativesTableAdapter
            // 
            this.relativesTableAdapter.ClearBeforeFill = true;
            // 
            // childrenTableAdapter
            // 
            this.childrenTableAdapter.ClearBeforeFill = true;
            // 
            // tb_Child_Age
            // 
            this.tb_Child_Age.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_Child_Age.Location = new System.Drawing.Point(107, 141);
            this.tb_Child_Age.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Child_Age.Multiline = true;
            this.tb_Child_Age.Name = "tb_Child_Age";
            this.tb_Child_Age.Size = new System.Drawing.Size(174, 24);
            this.tb_Child_Age.TabIndex = 11;
            // 
            // groupBox_par
            // 
            this.groupBox_par.Controls.Add(this.lbl_Parent_Name);
            this.groupBox_par.Controls.Add(this.tb_Parent_Name);
            this.groupBox_par.Controls.Add(this.tb_Parent_Relative_Relation);
            this.groupBox_par.Controls.Add(this.lbl_Parent_LastName);
            this.groupBox_par.Controls.Add(this.tb_Parent_LastName);
            this.groupBox_par.Controls.Add(this.lbl_Parent_Email);
            this.groupBox_par.Controls.Add(this.tb_Parent_Email);
            this.groupBox_par.Controls.Add(this.tb_Parent_Phone);
            this.groupBox_par.Controls.Add(this.lbl_Parent_Phone);
            this.groupBox_par.Controls.Add(this.lbl_Parent_Relative);
            this.groupBox_par.Controls.Add(this.lbl_Parent_Relative_Phone);
            this.groupBox_par.Controls.Add(this.tb_Parent_Relative_Phone);
            this.groupBox_par.Controls.Add(this.btn_Add_Parent);
            this.groupBox_par.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_par.Location = new System.Drawing.Point(26, 24);
            this.groupBox_par.Name = "groupBox_par";
            this.groupBox_par.Size = new System.Drawing.Size(308, 365);
            this.groupBox_par.TabIndex = 32;
            this.groupBox_par.TabStop = false;
            this.groupBox_par.Text = "Данни за родителя";
            // 
            // groupBox_Child
            // 
            this.groupBox_Child.Controls.Add(this.lbl_Child_Parent);
            this.groupBox_Child.Controls.Add(this.lbl_Child_Name);
            this.groupBox_Child.Controls.Add(this.btn_Add_Child);
            this.groupBox_Child.Controls.Add(this.tb_Child_Age);
            this.groupBox_Child.Controls.Add(this.tb_Child_Grade);
            this.groupBox_Child.Controls.Add(this.lbl_Child_LastName);
            this.groupBox_Child.Controls.Add(this.lbl_Child_Age);
            this.groupBox_Child.Controls.Add(this.groupBox_Child_Info);
            this.groupBox_Child.Controls.Add(this.tb_Child_LastName);
            this.groupBox_Child.Controls.Add(this.lbl_Child_Grade);
            this.groupBox_Child.Controls.Add(this.tb_Child_Name);
            this.groupBox_Child.Controls.Add(this.cbb_Child_Parent);
            this.groupBox_Child.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Child.Location = new System.Drawing.Point(404, 24);
            this.groupBox_Child.Name = "groupBox_Child";
            this.groupBox_Child.Size = new System.Drawing.Size(308, 365);
            this.groupBox_Child.TabIndex = 33;
            this.groupBox_Child.TabStop = false;
            this.groupBox_Child.Text = "Данни за дете/деца";
            // 
            // form_Add_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.groupBox_Child);
            this.Controls.Add(this.groupBox_par);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_Add_Parent";
            this.Text = "Въвеждане на информация";
            this.Load += new System.EventHandler(this.form_Add_Parent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            this.groupBox_Child_Info.ResumeLayout(false);
            this.groupBox_Child_Info.PerformLayout();
            this.groupBox_par.ResumeLayout(false);
            this.groupBox_par.PerformLayout();
            this.groupBox_Child.ResumeLayout(false);
            this.groupBox_Child.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Parent_Name;
        private System.Windows.Forms.TextBox tb_Parent_Phone;
        private System.Windows.Forms.TextBox tb_Parent_Email;
        private System.Windows.Forms.TextBox tb_Parent_LastName;
        private System.Windows.Forms.Label lbl_Parent_Name;
        private System.Windows.Forms.Label lbl_Parent_LastName;
        private System.Windows.Forms.Label lbl_Parent_Email;
        private System.Windows.Forms.Label lbl_Parent_Phone;
        private System.Windows.Forms.Label lbl_Parent_Relative;
        private System.Windows.Forms.TextBox tb_Parent_Relative_Phone;
        private System.Windows.Forms.Label lbl_Parent_Relative_Phone;
        private System.Windows.Forms.Button btn_Add_Parent;
        private System.Windows.Forms.TextBox tb_Child_Grade;
        private System.Windows.Forms.Label lbl_Child_Grade;
        private System.Windows.Forms.Label lbl_Child_Age;
        private System.Windows.Forms.TextBox tb_Child_LastName;
        private System.Windows.Forms.TextBox tb_Child_Name;
        private System.Windows.Forms.Label lbl_Child_LastName;
        private System.Windows.Forms.Label lbl_Child_Name;
        private System.Windows.Forms.Label lbl_Child_Parent;
        private System.Windows.Forms.ComboBox cbb_Child_Parent;
        private System.Windows.Forms.TextBox tb_Child_Info;
        private System.Windows.Forms.GroupBox groupBox_Child_Info;
        private System.Windows.Forms.Button btn_Add_Child;
        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private DayCareDataSetTableAdapters.ParentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.TextBox tb_Parent_Relative_Relation;
        private DayCareDataSetTableAdapters.RelativesTableAdapter relativesTableAdapter;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
        private System.Windows.Forms.TextBox tb_Child_Age;
        private System.Windows.Forms.GroupBox groupBox_par;
        private System.Windows.Forms.GroupBox groupBox_Child;
    }
}