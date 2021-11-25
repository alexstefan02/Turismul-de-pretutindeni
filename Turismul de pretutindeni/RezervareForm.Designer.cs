namespace Turismul_de_pretutindeni
{
    partial class RezervareForm
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
            this.detaliiLocation = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NumeLocatie = new System.Windows.Forms.Label();
            this.ImaginePrezentare = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disponibilitate = new System.Windows.Forms.Label();
            this.SinglePrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataLocatie = new System.Windows.Forms.Label();
            this.nrTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PretTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BoxConfirm = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.AvaliableSeats = new System.Windows.Forms.Label();
            this.detaliiLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaginePrezentare)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.BoxConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // detaliiLocation
            // 
            this.detaliiLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detaliiLocation.Controls.Add(this.splitContainer1);
            this.detaliiLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.detaliiLocation.Location = new System.Drawing.Point(465, 0);
            this.detaliiLocation.Name = "detaliiLocation";
            this.detaliiLocation.Size = new System.Drawing.Size(410, 461);
            this.detaliiLocation.TabIndex = 0;
            this.detaliiLocation.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AvaliableSeats);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.NumeLocatie);
            this.splitContainer1.Panel1.Controls.Add(this.ImaginePrezentare);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.disponibilitate);
            this.splitContainer1.Panel1.Controls.Add(this.SinglePrice);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.DataLocatie);
            this.splitContainer1.Panel2.Controls.Add(this.nrTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.PretTotal);
            this.splitContainer1.Size = new System.Drawing.Size(404, 440);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 3;
            // 
            // NumeLocatie
            // 
            this.NumeLocatie.AutoSize = true;
            this.NumeLocatie.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeLocatie.Location = new System.Drawing.Point(171, 196);
            this.NumeLocatie.Name = "NumeLocatie";
            this.NumeLocatie.Size = new System.Drawing.Size(69, 27);
            this.NumeLocatie.TabIndex = 4;
            this.NumeLocatie.Text = "label1";
            // 
            // ImaginePrezentare
            // 
            this.ImaginePrezentare.Location = new System.Drawing.Point(-5, -7);
            this.ImaginePrezentare.Name = "ImaginePrezentare";
            this.ImaginePrezentare.Size = new System.Drawing.Size(406, 200);
            this.ImaginePrezentare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImaginePrezentare.TabIndex = 3;
            this.ImaginePrezentare.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preț per persoana";
            // 
            // disponibilitate
            // 
            this.disponibilitate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibilitate.Location = new System.Drawing.Point(103, 237);
            this.disponibilitate.Name = "disponibilitate";
            this.disponibilitate.Size = new System.Drawing.Size(40, 20);
            this.disponibilitate.TabIndex = 11;
            this.disponibilitate.Text = "DA";
            this.disponibilitate.Visible = false;
            // 
            // SinglePrice
            // 
            this.SinglePrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePrice.Location = new System.Drawing.Point(161, 266);
            this.SinglePrice.Name = "SinglePrice";
            this.SinglePrice.Size = new System.Drawing.Size(87, 20);
            this.SinglePrice.TabIndex = 9;
            this.SinglePrice.Text = "X Lei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Disponibil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preț total";
            this.label6.Visible = false;
            // 
            // DataLocatie
            // 
            this.DataLocatie.AutoSize = true;
            this.DataLocatie.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLocatie.Location = new System.Drawing.Point(13, 49);
            this.DataLocatie.Name = "DataLocatie";
            this.DataLocatie.Size = new System.Drawing.Size(70, 19);
            this.DataLocatie.TabIndex = 5;
            this.DataLocatie.Text = "perioada";
            this.DataLocatie.Visible = false;
            // 
            // nrTotal
            // 
            this.nrTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTotal.Location = new System.Drawing.Point(194, 11);
            this.nrTotal.Name = "nrTotal";
            this.nrTotal.Size = new System.Drawing.Size(54, 20);
            this.nrTotal.TabIndex = 13;
            this.nrTotal.Text = "X";
            this.nrTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Număr total persoane:";
            // 
            // PretTotal
            // 
            this.PretTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(77)))), ((int)(((byte)(16)))));
            this.PretTotal.Location = new System.Drawing.Point(191, 99);
            this.PretTotal.Name = "PretTotal";
            this.PretTotal.Size = new System.Drawing.Size(204, 37);
            this.PretTotal.TabIndex = 8;
            this.PretTotal.Text = "10000 LEI";
            this.PretTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PretTotal.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnStartCheck);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alege perioada";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.Location = new System.Drawing.Point(223, 170);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(217, 23);
            this.btnStartCheck.TabIndex = 0;
            this.btnStartCheck.Text = "Verifică disponibilitatea";
            this.btnStartCheck.UseVisualStyleBackColor = true;
            this.btnStartCheck.Click += new System.EventHandler(this.btnStartCheck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cate persoane vor merge?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Perioada";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(240, 65);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 5, 11, 1, 2, 8, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2019, 5, 11, 1, 2, 8, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 65);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 5, 11, 1, 2, 8, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 11, 1, 2, 8, 0);
            // 
            // BoxConfirm
            // 
            this.BoxConfirm.Controls.Add(this.btnPrint);
            this.BoxConfirm.Controls.Add(this.btnConfirm);
            this.BoxConfirm.Location = new System.Drawing.Point(199, 365);
            this.BoxConfirm.Name = "BoxConfirm";
            this.BoxConfirm.Size = new System.Drawing.Size(253, 77);
            this.BoxConfirm.TabIndex = 2;
            this.BoxConfirm.TabStop = false;
            this.BoxConfirm.Text = "Finalizare";
            this.BoxConfirm.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(23, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Printare";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(144, 35);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirmă";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Locuri disponibile:";
            // 
            // AvaliableSeats
            // 
            this.AvaliableSeats.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaliableSeats.Location = new System.Drawing.Point(360, 238);
            this.AvaliableSeats.Name = "AvaliableSeats";
            this.AvaliableSeats.Size = new System.Drawing.Size(35, 20);
            this.AvaliableSeats.TabIndex = 13;
            this.AvaliableSeats.Text = "99";
            this.AvaliableSeats.Visible = false;
            // 
            // RezervareForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 461);
            this.Controls.Add(this.BoxConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detaliiLocation);
            this.Name = "RezervareForm";
            this.Text = "RezervareForm";
            this.Load += new System.EventHandler(this.RezervareForm_Load);
            this.detaliiLocation.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImaginePrezentare)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BoxConfirm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detaliiLocation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label DataLocatie;
        private System.Windows.Forms.Label NumeLocatie;
        private System.Windows.Forms.PictureBox ImaginePrezentare;
        private System.Windows.Forms.Label PretTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SinglePrice;
        private System.Windows.Forms.Label disponibilitate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nrTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.GroupBox BoxConfirm;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label AvaliableSeats;
        private System.Windows.Forms.Label label3;



    }
}