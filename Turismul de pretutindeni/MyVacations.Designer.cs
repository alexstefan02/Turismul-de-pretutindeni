namespace Turismul_de_pretutindeni
{
    partial class MyVacations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeVacantaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInceputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSfarsitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPersoaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeVacantaDataGridViewTextBoxColumn,
            this.dataInceputDataGridViewTextBoxColumn,
            this.dataSfarsitDataGridViewTextBoxColumn,
            this.nrPersoaneDataGridViewTextBoxColumn,
            this.pretTotalDataGridViewTextBoxColumn,
            this.deleteAction});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numeVacantaDataGridViewTextBoxColumn
            // 
            this.numeVacantaDataGridViewTextBoxColumn.DataPropertyName = "NumeVacanta";
            this.numeVacantaDataGridViewTextBoxColumn.HeaderText = "Vacanța";
            this.numeVacantaDataGridViewTextBoxColumn.Name = "numeVacantaDataGridViewTextBoxColumn";
            this.numeVacantaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInceputDataGridViewTextBoxColumn
            // 
            this.dataInceputDataGridViewTextBoxColumn.DataPropertyName = "DataInceput";
            this.dataInceputDataGridViewTextBoxColumn.HeaderText = "Dată început";
            this.dataInceputDataGridViewTextBoxColumn.Name = "dataInceputDataGridViewTextBoxColumn";
            this.dataInceputDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSfarsitDataGridViewTextBoxColumn
            // 
            this.dataSfarsitDataGridViewTextBoxColumn.DataPropertyName = "DataSfarsit";
            this.dataSfarsitDataGridViewTextBoxColumn.HeaderText = "Dată sfârșit";
            this.dataSfarsitDataGridViewTextBoxColumn.Name = "dataSfarsitDataGridViewTextBoxColumn";
            this.dataSfarsitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrPersoaneDataGridViewTextBoxColumn
            // 
            this.nrPersoaneDataGridViewTextBoxColumn.DataPropertyName = "NrPersoane";
            this.nrPersoaneDataGridViewTextBoxColumn.HeaderText = "Nr. de persoane";
            this.nrPersoaneDataGridViewTextBoxColumn.Name = "nrPersoaneDataGridViewTextBoxColumn";
            this.nrPersoaneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretTotalDataGridViewTextBoxColumn
            // 
            this.pretTotalDataGridViewTextBoxColumn.DataPropertyName = "PretTotal";
            this.pretTotalDataGridViewTextBoxColumn.HeaderText = "Preț";
            this.pretTotalDataGridViewTextBoxColumn.Name = "pretTotalDataGridViewTextBoxColumn";
            this.pretTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteAction
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Șterge";
            this.deleteAction.DefaultCellStyle = dataGridViewCellStyle3;
            this.deleteAction.HeaderText = "Șterge";
            this.deleteAction.Name = "deleteAction";
            this.deleteAction.ReadOnly = true;
            // 
            // MyVacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 356);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyVacations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyVacations";
            this.Load += new System.EventHandler(this.MyVacations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeVacantaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInceputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSfarsitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPersoaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteAction;

    }
}