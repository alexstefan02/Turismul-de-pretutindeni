namespace Turismul_de_pretutindeni
{
    partial class FrmVacanta
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.AdminToolsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAdminOption = new System.Windows.Forms.ToolStripMenuItem();
            this.AddVacationEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.MyVacationsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountTab = new System.Windows.Forms.ToolStripMenuItem();
            this.DeconectareOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ieșireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShowOption = new System.Windows.Forms.CheckBox();
            this.butonRezervare = new System.Windows.Forms.Button();
            this.btnPoster = new System.Windows.Forms.Button();
            this.timerSlideShow = new System.Windows.Forms.Timer(this.components);
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.ShowVacation = new System.Windows.Forms.PictureBox();
            this.DescriptionLocation = new System.Windows.Forms.Label();
            this.PriceLocation = new System.Windows.Forms.Label();
            this.SeatsLocation = new System.Windows.Forms.Label();
            this.NameLocation = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowVacation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminToolsTab,
            this.MyVacationsTab,
            this.AccountTab});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(795, 31);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // AdminToolsTab
            // 
            this.AdminToolsTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAdminOption,
            this.AddVacationEditor});
            this.AdminToolsTab.Enabled = false;
            this.AdminToolsTab.Name = "AdminToolsTab";
            this.AdminToolsTab.Size = new System.Drawing.Size(47, 27);
            this.AdminToolsTab.Text = "File";
            // 
            // AddAdminOption
            // 
            this.AddAdminOption.Name = "AddAdminOption";
            this.AddAdminOption.Size = new System.Drawing.Size(243, 28);
            this.AddAdminOption.Text = "Adauga Admin Nou";
            this.AddAdminOption.Click += new System.EventHandler(this.AddAdminOption_Click);
            // 
            // AddVacationEditor
            // 
            this.AddVacationEditor.Name = "AddVacationEditor";
            this.AddVacationEditor.Size = new System.Drawing.Size(243, 28);
            this.AddVacationEditor.Text = "Adauga Vacante Noi";
            this.AddVacationEditor.Click += new System.EventHandler(this.AddVacationEditor_Click);
            // 
            // MyVacationsTab
            // 
            this.MyVacationsTab.Name = "MyVacationsTab";
            this.MyVacationsTab.Size = new System.Drawing.Size(138, 27);
            this.MyVacationsTab.Text = "Vacanțele mele";
            this.MyVacationsTab.Click += new System.EventHandler(this.MyVacationsTab_Click);
            // 
            // AccountTab
            // 
            this.AccountTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeconectareOption,
            this.ieșireToolStripMenuItem});
            this.AccountTab.Name = "AccountTab";
            this.AccountTab.Size = new System.Drawing.Size(183, 27);
            this.AccountTab.Text = "demo@example.com";
            // 
            // DeconectareOption
            // 
            this.DeconectareOption.Name = "DeconectareOption";
            this.DeconectareOption.Size = new System.Drawing.Size(182, 28);
            this.DeconectareOption.Text = "Deconectare";
            this.DeconectareOption.Click += new System.EventHandler(this.DeconectareOption_Click);
            // 
            // ieșireToolStripMenuItem
            // 
            this.ieșireToolStripMenuItem.Name = "ieșireToolStripMenuItem";
            this.ieșireToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.ieșireToolStripMenuItem.Text = "Ieșire";
            this.ieșireToolStripMenuItem.Click += new System.EventHandler(this.ieșireToolStripMenuItem_Click);
            // 
            // SlideShowOption
            // 
            this.SlideShowOption.Appearance = System.Windows.Forms.Appearance.Button;
            this.SlideShowOption.AutoSize = true;
            this.SlideShowOption.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideShowOption.Location = new System.Drawing.Point(15, 335);
            this.SlideShowOption.Name = "SlideShowOption";
            this.SlideShowOption.Size = new System.Drawing.Size(88, 33);
            this.SlideShowOption.TabIndex = 0;
            this.SlideShowOption.Text = "Autoplay";
            this.SlideShowOption.UseVisualStyleBackColor = true;
            this.SlideShowOption.CheckedChanged += new System.EventHandler(this.SlideShowOption_CheckedChanged);
            // 
            // butonRezervare
            // 
            this.butonRezervare.Location = new System.Drawing.Point(41, 171);
            this.butonRezervare.Name = "butonRezervare";
            this.butonRezervare.Size = new System.Drawing.Size(155, 23);
            this.butonRezervare.TabIndex = 6;
            this.butonRezervare.Text = "Rezervă";
            this.butonRezervare.UseVisualStyleBackColor = true;
            this.butonRezervare.Click += new System.EventHandler(this.butonRezervare_Click);
            // 
            // btnPoster
            // 
            this.btnPoster.Location = new System.Drawing.Point(41, 200);
            this.btnPoster.Name = "btnPoster";
            this.btnPoster.Size = new System.Drawing.Size(155, 23);
            this.btnPoster.TabIndex = 7;
            this.btnPoster.Text = "Poster";
            this.btnPoster.UseVisualStyleBackColor = true;
            this.btnPoster.Click += new System.EventHandler(this.btnPoster_Click);
            // 
            // timerSlideShow
            // 
            this.timerSlideShow.Interval = 2000;
            this.timerSlideShow.Tick += new System.EventHandler(this.timerSlideShow_Tick);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = global::Turismul_de_pretutindeni.Properties.Resources.prev;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(689, 328);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 40);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Turismul_de_pretutindeni.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(735, 328);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ShowVacation
            // 
            this.ShowVacation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowVacation.Location = new System.Drawing.Point(0, 0);
            this.ShowVacation.Name = "ShowVacation";
            this.ShowVacation.Size = new System.Drawing.Size(275, 233);
            this.ShowVacation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowVacation.TabIndex = 3;
            this.ShowVacation.TabStop = false;
            // 
            // DescriptionLocation
            // 
            this.DescriptionLocation.BackColor = System.Drawing.Color.White;
            this.DescriptionLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLocation.ForeColor = System.Drawing.Color.Black;
            this.DescriptionLocation.Location = new System.Drawing.Point(0, 46);
            this.DescriptionLocation.Name = "DescriptionLocation";
            this.DescriptionLocation.Size = new System.Drawing.Size(243, 185);
            this.DescriptionLocation.TabIndex = 16;
            this.DescriptionLocation.Text = "label4";
            this.DescriptionLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLocation
            // 
            this.PriceLocation.BackColor = System.Drawing.Color.White;
            this.PriceLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLocation.ForeColor = System.Drawing.Color.Green;
            this.PriceLocation.Location = new System.Drawing.Point(23, 83);
            this.PriceLocation.Name = "PriceLocation";
            this.PriceLocation.Size = new System.Drawing.Size(173, 57);
            this.PriceLocation.TabIndex = 19;
            this.PriceLocation.Text = "label2";
            this.PriceLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeatsLocation
            // 
            this.SeatsLocation.BackColor = System.Drawing.Color.Transparent;
            this.SeatsLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLocation.ForeColor = System.Drawing.Color.DarkOrange;
            this.SeatsLocation.Location = new System.Drawing.Point(89, 10);
            this.SeatsLocation.Name = "SeatsLocation";
            this.SeatsLocation.Size = new System.Drawing.Size(61, 22);
            this.SeatsLocation.TabIndex = 18;
            this.SeatsLocation.Text = "label3";
            // 
            // NameLocation
            // 
            this.NameLocation.BackColor = System.Drawing.Color.White;
            this.NameLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLocation.ForeColor = System.Drawing.Color.Black;
            this.NameLocation.Location = new System.Drawing.Point(2, 10);
            this.NameLocation.Name = "NameLocation";
            this.NameLocation.Size = new System.Drawing.Size(215, 36);
            this.NameLocation.TabIndex = 17;
            this.NameLocation.Text = "label1";
            this.NameLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ShowVacation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(760, 233);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.NameLocation);
            this.splitContainer2.Panel1.Controls.Add(this.DescriptionLocation);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.btnPoster);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.PriceLocation);
            this.splitContainer2.Panel2.Controls.Add(this.butonRezervare);
            this.splitContainer2.Panel2.Controls.Add(this.SeatsLocation);
            this.splitContainer2.Size = new System.Drawing.Size(481, 233);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Capacitate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Preț ofertă";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vizualizare ofertă";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmVacanta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 376);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.SlideShowOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmVacanta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacanta";
            this.Load += new System.EventHandler(this.FrmVacanta_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowVacation)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AdminToolsTab;
        private System.Windows.Forms.ToolStripMenuItem AddAdminOption;
        private System.Windows.Forms.ToolStripMenuItem AddVacationEditor;
        private System.Windows.Forms.ToolStripMenuItem MyVacationsTab;
        private System.Windows.Forms.ToolStripMenuItem AccountTab;
        private System.Windows.Forms.ToolStripMenuItem DeconectareOption;
        private System.Windows.Forms.CheckBox SlideShowOption;
        private System.Windows.Forms.PictureBox ShowVacation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Timer timerSlideShow;
        private System.Windows.Forms.Button butonRezervare;
        private System.Windows.Forms.ToolStripMenuItem ieșireToolStripMenuItem;
        private System.Windows.Forms.Button btnPoster;
        private System.Windows.Forms.Label DescriptionLocation;
        private System.Windows.Forms.Label PriceLocation;
        private System.Windows.Forms.Label SeatsLocation;
        private System.Windows.Forms.Label NameLocation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}