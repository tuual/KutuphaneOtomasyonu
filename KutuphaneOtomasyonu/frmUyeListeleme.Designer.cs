namespace KutuphaneOtomasyonu
{
    partial class frmUyeListeleme
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            txtTcno = new TextBox();
            label3 = new Label();
            txtTelno = new TextBox();
            label2 = new Label();
            txyUyeadi = new TextBox();
            btnKaldirma = new Button();
            btnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 516);
            panel1.Name = "panel1";
            panel1.Size = new Size(1431, 126);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 0;
            label1.Text = "Üye Listeleme İşlemleri";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTcno);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTelno);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txyUyeadi);
            panel2.Controls.Add(btnKaldirma);
            panel2.Controls.Add(btnGuncelle);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(848, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 516);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 310);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 14;
            label4.Text = "Üye TCNO";
            // 
            // txtTcno
            // 
            txtTcno.Location = new Point(176, 336);
            txtTcno.Multiline = true;
            txtTcno.Name = "txtTcno";
            txtTcno.Size = new Size(231, 34);
            txtTcno.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(176, 227);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 12;
            label3.Text = "Üye Telefon Numarası";
            // 
            // txtTelno
            // 
            txtTelno.Location = new Point(176, 253);
            txtTelno.Multiline = true;
            txtTelno.Name = "txtTelno";
            txtTelno.Size = new Size(231, 34);
            txtTelno.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 146);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 10;
            label2.Text = "Üye Adı Soyadı";
            // 
            // txyUyeadi
            // 
            txyUyeadi.Location = new Point(176, 172);
            txyUyeadi.Multiline = true;
            txyUyeadi.Name = "txyUyeadi";
            txyUyeadi.Size = new Size(231, 34);
            txyUyeadi.TabIndex = 9;
            // 
            // btnKaldirma
            // 
            btnKaldirma.BackColor = Color.Blue;
            btnKaldirma.FlatStyle = FlatStyle.Flat;
            btnKaldirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaldirma.ForeColor = Color.White;
            btnKaldirma.Location = new Point(90, 430);
            btnKaldirma.Name = "btnKaldirma";
            btnKaldirma.Size = new Size(173, 49);
            btnKaldirma.TabIndex = 8;
            btnKaldirma.Text = "Üye Kaldırma";
            btnKaldirma.UseVisualStyleBackColor = false;
            btnKaldirma.Click += btnKaldirma_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Blue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(366, 430);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 49);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Üye Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(848, 516);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmUyeListeleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1431, 642);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmUyeListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Listeleme İşlemleri";
            Load += frmUyeListeleme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnKaldirma;
        private Button btnGuncelle;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtTcno;
        private Label label3;
        private TextBox txtTelno;
        private Label label2;
        private TextBox txyUyeadi;
    }
}