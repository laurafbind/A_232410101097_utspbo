namespace A_232410101097_utspbo.VIEW
{
    partial class DASHBOARD_ADMIN
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tambah = new Button();
            id_tugas = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            deadline = new DataGridViewTextBoxColumn();
            nama_tugas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(76, 33);
            label1.TabIndex = 0;
            label1.Text = "Task";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_tugas, Column1, deskripsi, deadline, nama_tugas });
            dataGridView1.Location = new Point(2, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(795, 360);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tambah
            // 
            tambah.Location = new Point(676, 42);
            tambah.Name = "tambah";
            tambah.Size = new Size(112, 34);
            tambah.TabIndex = 2;
            tambah.Text = "tambah";
            tambah.UseVisualStyleBackColor = true;
            // 
            // id_tugas
            // 
            id_tugas.HeaderText = "id_tugas";
            id_tugas.MinimumWidth = 8;
            id_tugas.Name = "id_tugas";
            id_tugas.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "tanggal_tugas";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "deskripsi";
            deskripsi.MinimumWidth = 8;
            deskripsi.Name = "deskripsi";
            deskripsi.Width = 150;
            // 
            // deadline
            // 
            deadline.HeaderText = "deadline";
            deadline.MinimumWidth = 8;
            deadline.Name = "deadline";
            deadline.Width = 150;
            // 
            // nama_tugas
            // 
            nama_tugas.HeaderText = "nama_tugas";
            nama_tugas.MinimumWidth = 8;
            nama_tugas.Name = "nama_tugas";
            nama_tugas.Width = 150;
            // 
            // DASHBOARD_ADMIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(tambah);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DASHBOARD_ADMIN";
            Text = "DASHBOARD_ADMIN";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button tambah;
        private DataGridViewTextBoxColumn id_tugas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn deskripsi;
        private DataGridViewTextBoxColumn deadline;
        private DataGridViewTextBoxColumn nama_tugas;
    }
}