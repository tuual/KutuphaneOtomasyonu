namespace KutuphaneOtomasyonu
{
    partial class frmKitapListeleme
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtKitapSayfa = new TextBox();
            label4 = new Label();
            txtKitapTema = new TextBox();
            label3 = new Label();
            txtKitapyazari = new TextBox();
            label2 = new Label();
            txtKitapAdi = new TextBox();
            btnKitapKaldirma = new Button();
            btnKitapGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Size = new Size(1511, 513);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 513);
            panel1.Name = "panel1";
            panel1.Size = new Size(1511, 126);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Kitap Listeleme İşlemleri";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtKitapSayfa);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtKitapTema);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtKitapyazari);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtKitapAdi);
            panel2.Controls.Add(btnKitapKaldirma);
            panel2.Controls.Add(btnKitapGuncelle);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(888, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 513);
            panel2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Düzgün", "Yıpranmış", "Sorunlu Sayfalar" });
            comboBox1.Location = new Point(370, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(370, 193);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 20;
            label6.Text = "Kitap Durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(370, 112);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 19;
            label5.Text = "Kitap Sayfa Sayısı";
            // 
            // txtKitapSayfa
            // 
            txtKitapSayfa.Location = new Point(370, 138);
            txtKitapSayfa.Multiline = true;
            txtKitapSayfa.Name = "txtKitapSayfa";
            txtKitapSayfa.Size = new Size(231, 34);
            txtKitapSayfa.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 239);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 17;
            label4.Text = "Kitap Teması";
            // 
            // txtKitapTema
            // 
            txtKitapTema.Location = new Point(33, 265);
            txtKitapTema.Multiline = true;
            txtKitapTema.Name = "txtKitapTema";
            txtKitapTema.Size = new Size(231, 34);
            txtKitapTema.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 15;
            label3.Text = "Kitap Yazarı";
            // 
            // txtKitapyazari
            // 
            txtKitapyazari.Location = new Point(33, 182);
            txtKitapyazari.Multiline = true;
            txtKitapyazari.Name = "txtKitapyazari";
            txtKitapyazari.Size = new Size(231, 34);
            txtKitapyazari.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 75);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 13;
            label2.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(33, 101);
            txtKitapAdi.Multiline = true;
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(231, 34);
            txtKitapAdi.TabIndex = 12;
            // 
            // btnKitapKaldirma
            // 
            btnKitapKaldirma.BackColor = Color.Blue;
            btnKitapKaldirma.FlatStyle = FlatStyle.Flat;
            btnKitapKaldirma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKitapKaldirma.ForeColor = Color.White;
            btnKitapKaldirma.Location = new Point(33, 422);
            btnKitapKaldirma.Name = "btnKitapKaldirma";
            btnKitapKaldirma.Size = new Size(173, 70);
            btnKitapKaldirma.TabIndex = 8;
            btnKitapKaldirma.Text = "Kitap Verisi Kaldırma";
            btnKitapKaldirma.UseVisualStyleBackColor = false;
            btnKitapKaldirma.Click += btnKitapKaldirma_Click;
            // 
            // btnKitapGuncelle
            // 
            btnKitapGuncelle.BackColor = Color.Blue;
            btnKitapGuncelle.FlatStyle = FlatStyle.Flat;
            btnKitapGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKitapGuncelle.ForeColor = Color.White;
            btnKitapGuncelle.Location = new Point(315, 425);
            btnKitapGuncelle.Name = "btnKitapGuncelle";
            btnKitapGuncelle.Size = new Size(173, 67);
            btnKitapGuncelle.TabIndex = 7;
            btnKitapGuncelle.Text = "Kitap Bilgi Güncelleme";
            btnKitapGuncelle.UseVisualStyleBackColor = false;
            btnKitapGuncelle.Click += btnKitapGuncelle_Click;
            // 
            // frmKitapListeleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 639);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmKitapListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Listeleme İşlemleri";
            Load += frmKitapListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnKitapKaldirma;
        private Button btnKitapGuncelle;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private TextBox txtKitapSayfa;
        private Label label4;
        private TextBox txtKitapTema;
        private Label label3;
        private TextBox txtKitapyazari;
        private Label label2;
        private TextBox txtKitapAdi;
    }
}