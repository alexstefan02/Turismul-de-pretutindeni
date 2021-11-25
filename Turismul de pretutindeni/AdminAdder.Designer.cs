namespace Turismul_de_pretutindeni
{
    partial class AdminAdder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAdder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.tutorialPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.startPlaying = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPlayer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.btnTransform);
            this.groupBox1.Location = new System.Drawing.Point(393, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panou administrator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selectează utilizator";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(54, 47);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(272, 24);
            this.comboBox.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(221, 90);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(105, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Înregistrare";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(54, 90);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(153, 23);
            this.btnTransform.TabIndex = 0;
            this.btnTransform.Text = "Transformă în admin";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(12, 252);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(75, 23);
            this.btnRevoke.TabIndex = 1;
            this.btnRevoke.Text = "Ieșire";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // tutorialPlayer
            // 
            this.tutorialPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tutorialPlayer.Enabled = true;
            this.tutorialPlayer.Location = new System.Drawing.Point(3, 18);
            this.tutorialPlayer.Name = "tutorialPlayer";
            this.tutorialPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tutorialPlayer.OcxState")));
            this.tutorialPlayer.Size = new System.Drawing.Size(350, 213);
            this.tutorialPlayer.TabIndex = 0;
            // 
            // startPlaying
            // 
            this.startPlaying.Enabled = true;
            this.startPlaying.Tick += new System.EventHandler(this.startPlaying_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tutorialPlayer);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutorial";
            // 
            // AdminAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRevoke);
            this.Name = "AdminAdder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAdder";
            this.Load += new System.EventHandler(this.AdminAdder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialPlayer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer tutorialPlayer;
        private System.Windows.Forms.Timer startPlaying;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}