namespace CourseWork
{
    partial class Meal
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
            this.dgMeal = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            this.btnMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMeal
            // 
            this.dgMeal.AllowUserToAddRows = false;
            this.dgMeal.AutoGenerateColumns = false;
            this.dgMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.mealsDataGridViewTextBoxColumn,
            this.Ate,
            this.id});
            this.dgMeal.DataSource = this.childrenBindingSource;
            this.dgMeal.Location = new System.Drawing.Point(55, 12);
            this.dgMeal.Name = "dgMeal";
            this.dgMeal.Size = new System.Drawing.Size(348, 311);
            this.dgMeal.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mealsDataGridViewTextBoxColumn
            // 
            this.mealsDataGridViewTextBoxColumn.DataPropertyName = "Meals";
            this.mealsDataGridViewTextBoxColumn.HeaderText = "Платени";
            this.mealsDataGridViewTextBoxColumn.Name = "mealsDataGridViewTextBoxColumn";
            // 
            // Ate
            // 
            this.Ate.HeaderText = "Ял";
            this.Ate.Name = "Ate";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // btnMeal
            // 
            this.btnMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMeal.Location = new System.Drawing.Point(175, 347);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(113, 53);
            this.btnMeal.TabIndex = 1;
            this.btnMeal.Text = "Отбелязване";
            this.btnMeal.UseVisualStyleBackColor = true;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.dgMeal);
            this.Name = "Meal";
            this.Text = "Хранения за деня";
            this.Load += new System.EventHandler(this.Meal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMeal;
        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}