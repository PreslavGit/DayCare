namespace CourseWork
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.dayCareDataSet = new CourseWork.DayCareDataSet();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ParentsTableAdapter();
            this.tableAdapterManager = new CourseWork.DayCareDataSetTableAdapters.TableAdapterManager();
            this.childrenTableAdapter = new CourseWork.DayCareDataSetTableAdapters.ChildrenTableAdapter();
            this.relativesTableAdapter = new CourseWork.DayCareDataSetTableAdapters.RelativesTableAdapter();
            this.parentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.parentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childrenDataGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relativesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPar = new System.Windows.Forms.Label();
            this.lblRel = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.relativesDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingNavigator)).BeginInit();
            this.parentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dayCareDataSet
            // 
            this.dayCareDataSet.DataSetName = "DayCareDataSet";
            this.dayCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "Parents";
            this.parentsBindingSource.DataSource = this.dayCareDataSet;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChildrenTableAdapter = this.childrenTableAdapter;
            this.tableAdapterManager.ParentsTableAdapter = this.parentsTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.RelativesTableAdapter = this.relativesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CourseWork.DayCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // childrenTableAdapter
            // 
            this.childrenTableAdapter.ClearBeforeFill = true;
            // 
            // relativesTableAdapter
            // 
            this.relativesTableAdapter.ClearBeforeFill = true;
            // 
            // parentsBindingNavigator
            // 
            this.parentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.parentsBindingNavigator.BindingSource = this.parentsBindingSource;
            this.parentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.parentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.parentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.parentsBindingNavigatorSaveItem});
            this.parentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.parentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.parentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.parentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.parentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.parentsBindingNavigator.Name = "parentsBindingNavigator";
            this.parentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.parentsBindingNavigator.Size = new System.Drawing.Size(994, 25);
            this.parentsBindingNavigator.TabIndex = 0;
            this.parentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // parentsBindingNavigatorSaveItem
            // 
            this.parentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parentsBindingNavigatorSaveItem.Image")));
            this.parentsBindingNavigatorSaveItem.Name = "parentsBindingNavigatorSaveItem";
            this.parentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.parentsBindingNavigatorSaveItem.Text = "Save Data";
            this.parentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.parentsBindingNavigatorSaveItem_Click);
            // 
            // parentsDataGridView
            // 
            this.parentsDataGridView.AutoGenerateColumns = false;
            this.parentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.parentsDataGridView.DataSource = this.parentsBindingSource;
            this.parentsDataGridView.Location = new System.Drawing.Point(32, 57);
            this.parentsDataGridView.Name = "parentsDataGridView";
            this.parentsDataGridView.Size = new System.Drawing.Size(443, 208);
            this.parentsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Име";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // childrenBindingSource
            // 
            this.childrenBindingSource.DataMember = "FK__Children__Parent__5165187F";
            this.childrenBindingSource.DataSource = this.parentsBindingSource;
            // 
            // childrenDataGridView
            // 
            this.childrenDataGridView.AutoGenerateColumns = false;
            this.childrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13});
            this.childrenDataGridView.DataSource = this.childrenBindingSource;
            this.childrenDataGridView.Location = new System.Drawing.Point(32, 324);
            this.childrenDataGridView.Name = "childrenDataGridView";
            this.childrenDataGridView.Size = new System.Drawing.Size(766, 220);
            this.childrenDataGridView.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Име";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn11.HeaderText = "Години";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn12.HeaderText = "Клас";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Meals";
            this.dataGridViewTextBoxColumn14.HeaderText = "Храна";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Info";
            this.dataGridViewTextBoxColumn13.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // relativesBindingSource
            // 
            this.relativesBindingSource.DataMember = "FK__Relatives__Paren__4E88ABD4";
            this.relativesBindingSource.DataSource = this.parentsBindingSource;
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPar.Location = new System.Drawing.Point(12, 36);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(75, 18);
            this.lblPar.TabIndex = 4;
            this.lblPar.Text = "Родител";
            // 
            // lblRel
            // 
            this.lblRel.AutoSize = true;
            this.lblRel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRel.Location = new System.Drawing.Point(508, 36);
            this.lblRel.Name = "lblRel";
            this.lblRel.Size = new System.Drawing.Size(78, 18);
            this.lblRel.TabIndex = 5;
            this.lblRel.Text = "Роднина";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChild.Location = new System.Drawing.Point(12, 294);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(185, 18);
            this.lblChild.TabIndex = 6;
            this.lblChild.Text = "Информация за деца";
            // 
            // relativesDataGridView
            // 
            this.relativesDataGridView.AutoGenerateColumns = false;
            this.relativesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relativesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.relativesDataGridView.DataSource = this.relativesBindingSource;
            this.relativesDataGridView.Location = new System.Drawing.Point(526, 57);
            this.relativesDataGridView.Name = "relativesDataGridView";
            this.relativesDataGridView.Size = new System.Drawing.Size(272, 208);
            this.relativesDataGridView.TabIndex = 3;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Excel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Excel.Location = new System.Drawing.Point(867, 494);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(100, 50);
            this.btn_Excel.TabIndex = 7;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Relation";
            this.dataGridViewTextBoxColumn19.HeaderText = "Роднина";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn20.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblRel);
            this.Controls.Add(this.lblPar);
            this.Controls.Add(this.relativesDataGridView);
            this.Controls.Add(this.childrenDataGridView);
            this.Controls.Add(this.parentsBindingNavigator);
            this.Controls.Add(this.parentsDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Data";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingNavigator)).EndInit();
            this.parentsBindingNavigator.ResumeLayout(false);
            this.parentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DayCareDataSet dayCareDataSet;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private DayCareDataSetTableAdapters.ParentsTableAdapter parentsTableAdapter;
        private DayCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator parentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton parentsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView parentsDataGridView;
        private DayCareDataSetTableAdapters.ChildrenTableAdapter childrenTableAdapter;
        private System.Windows.Forms.BindingSource childrenBindingSource;
        private DayCareDataSetTableAdapters.RelativesTableAdapter relativesTableAdapter;
        private System.Windows.Forms.DataGridView childrenDataGridView;
        private System.Windows.Forms.BindingSource relativesBindingSource;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Label lblRel;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.DataGridView relativesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}