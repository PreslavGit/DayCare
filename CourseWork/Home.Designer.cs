namespace CourseWork
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addParKids = new System.Windows.Forms.ToolStripMenuItem();
            this.payFT = new System.Windows.Forms.ToolStripMenuItem();
            this.payMember = new System.Windows.Forms.ToolStripMenuItem();
            this.payFoodTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.Attendeds = new System.Windows.Forms.ToolStripMenuItem();
            this.присъствиеПоДниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бройХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заРодителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.присъствияПоДниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.присъствиеПоДецаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наДетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.присъствияПоКласИДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNew,
            this.payFT,
            this.Attendeds,
            this.справкиToolStripMenuItem,
            this.търсенеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1291, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddNew
            // 
            this.AddNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списъкToolStripMenuItem,
            this.addParKids});
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(146, 20);
            this.AddNew.Text = "Добавяне/Редактиране";
            // 
            // списъкToolStripMenuItem
            // 
            this.списъкToolStripMenuItem.Name = "списъкToolStripMenuItem";
            this.списъкToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.списъкToolStripMenuItem.Text = "Списък на децата";
            this.списъкToolStripMenuItem.Click += new System.EventHandler(this.списъкToolStripMenuItem_Click_1);
            // 
            // addParKids
            // 
            this.addParKids.Name = "addParKids";
            this.addParKids.Size = new System.Drawing.Size(170, 22);
            this.addParKids.Text = "Добавяне ";
            this.addParKids.Click += new System.EventHandler(this.addParKids_Click);
            // 
            // payFT
            // 
            this.payFT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payMember,
            this.payFoodTrans});
            this.payFT.Name = "payFT";
            this.payFT.Size = new System.Drawing.Size(71, 20);
            this.payFT.Text = "Плащане";
            // 
            // payMember
            // 
            this.payMember.Name = "payMember";
            this.payMember.Size = new System.Drawing.Size(116, 22);
            this.payMember.Text = "Период";
            this.payMember.Click += new System.EventHandler(this.payMember_Click);
            // 
            // payFoodTrans
            // 
            this.payFoodTrans.Name = "payFoodTrans";
            this.payFoodTrans.Size = new System.Drawing.Size(116, 22);
            this.payFoodTrans.Text = "Храна";
            this.payFoodTrans.Click += new System.EventHandler(this.payFoodTrans_Click);
            // 
            // Attendeds
            // 
            this.Attendeds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.присъствиеПоДниToolStripMenuItem,
            this.бройХраненияToolStripMenuItem});
            this.Attendeds.Name = "Attendeds";
            this.Attendeds.Size = new System.Drawing.Size(132, 20);
            this.Attendeds.Text = "Присъствена форма";
            // 
            // присъствиеПоДниToolStripMenuItem
            // 
            this.присъствиеПоДниToolStripMenuItem.Name = "присъствиеПоДниToolStripMenuItem";
            this.присъствиеПоДниToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.присъствиеПоДниToolStripMenuItem.Text = "Присъствия за деня";
            this.присъствиеПоДниToolStripMenuItem.Click += new System.EventHandler(this.присъствиеПоДниToolStripMenuItem_Click);
            // 
            // бройХраненияToolStripMenuItem
            // 
            this.бройХраненияToolStripMenuItem.Name = "бройХраненияToolStripMenuItem";
            this.бройХраненияToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.бройХраненияToolStripMenuItem.Text = "Хранения за деня";
            this.бройХраненияToolStripMenuItem.Click += new System.EventHandler(this.бройХраненияToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заРодителиToolStripMenuItem,
            this.присъствияПоДниToolStripMenuItem,
            this.присъствиеПоДецаToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // заРодителиToolStripMenuItem
            // 
            this.заРодителиToolStripMenuItem.Name = "заРодителиToolStripMenuItem";
            this.заРодителиToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.заРодителиToolStripMenuItem.Text = "За родители";
            this.заРодителиToolStripMenuItem.Click += new System.EventHandler(this.заРодителиToolStripMenuItem_Click);
            // 
            // присъствияПоДниToolStripMenuItem
            // 
            this.присъствияПоДниToolStripMenuItem.Name = "присъствияПоДниToolStripMenuItem";
            this.присъствияПоДниToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.присъствияПоДниToolStripMenuItem.Text = "Присъствия по дни";
            this.присъствияПоДниToolStripMenuItem.Click += new System.EventHandler(this.присъствияПоДниToolStripMenuItem_Click);
            // 
            // присъствиеПоДецаToolStripMenuItem
            // 
            this.присъствиеПоДецаToolStripMenuItem.Name = "присъствиеПоДецаToolStripMenuItem";
            this.присъствиеПоДецаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.присъствиеПоДецаToolStripMenuItem.Text = "Присъствия по деца";
            this.присъствиеПоДецаToolStripMenuItem.Click += new System.EventHandler(this.присъствиеПоДецаToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наДетеToolStripMenuItem,
            this.присъствияПоКласИДатаToolStripMenuItem});
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            // 
            // наДетеToolStripMenuItem
            // 
            this.наДетеToolStripMenuItem.Name = "наДетеToolStripMenuItem";
            this.наДетеToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.наДетеToolStripMenuItem.Text = "Посещения за последен период";
            this.наДетеToolStripMenuItem.Click += new System.EventHandler(this.наДетеToolStripMenuItem_Click);
            // 
            // присъствияПоКласИДатаToolStripMenuItem
            // 
            this.присъствияПоКласИДатаToolStripMenuItem.Name = "присъствияПоКласИДатаToolStripMenuItem";
            this.присъствияПоКласИДатаToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.присъствияПоКласИДатаToolStripMenuItem.Text = "Присъствия по клас и дата";
            this.присъствияПоКласИДатаToolStripMenuItem.Click += new System.EventHandler(this.присъствияПоКласИДатаToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1291, 583);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Занималня „Изгрев“";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddNew;
        private System.Windows.Forms.ToolStripMenuItem payFT;
        private System.Windows.Forms.ToolStripMenuItem payMember;
        private System.Windows.Forms.ToolStripMenuItem payFoodTrans;
        private System.Windows.Forms.ToolStripMenuItem addParKids;
        private System.Windows.Forms.ToolStripMenuItem Attendeds;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заРодителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem присъствияПоДниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem присъствиеПоДецаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наДетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem присъствияПоКласИДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem присъствиеПоДниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бройХраненияToolStripMenuItem;
    }
}

