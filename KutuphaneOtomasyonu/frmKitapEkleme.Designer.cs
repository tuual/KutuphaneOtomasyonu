namespace KutuphaneOtomasyonu
{
    partial class frmKitapEkleme
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtKitapSayfa = new TextBox();
            btnEkle = new Button();
            label4 = new Label();
            txtKitapTema = new TextBox();
            label3 = new Label();
            txtKitapyazari = new TextBox();
            label2 = new Label();
            txtKitapAdi = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 126);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 0;
            label1.Text = "Kitap Ekleme İşlemi";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtKitapSayfa);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtKitapTema);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtKitapyazari);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtKitapAdi);
            panel2.Location = new Point(224, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 522);
            panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Düzgün", "Yıpranmış", "Sorunlu Sayfalar" });
            comboBox1.Location = new Point(455, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(455, 207);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 10;
            label6.Text = "Kitap Durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(455, 126);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 8;
            label5.Text = "Kitap Sayfa Sayısı";
            // 
            // txtKitapSayfa
            // 
            txtKitapSayfa.Location = new Point(455, 152);
            txtKitapSayfa.Multiline = true;
            txtKitapSayfa.Name = "txtKitapSayfa";
            txtKitapSayfa.Size = new Size(231, 34);
            txtKitapSayfa.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Blue;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(346, 421);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(173, 49);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Kitap Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 238);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 5;
            label4.Text = "Kitap Teması";
            // 
            // txtKitapTema
            // 
            txtKitapTema.Location = new Point(113, 264);
            txtKitapTema.Multiline = true;
            txtKitapTema.Name = "txtKitapTema";
            txtKitapTema.Size = new Size(231, 34);
            txtKitapTema.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 155);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 3;
            label3.Text = "Kitap Yazarı";
            // 
            // txtKitapyazari
            // 
            txtKitapyazari.Location = new Point(113, 181);
            txtKitapyazari.Multiline = true;
            txtKitapyazari.Name = "txtKitapyazari";
            txtKitapyazari.Size = new Size(231, 34);
            txtKitapyazari.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(113, 100);
            txtKitapAdi.Multiline = true;
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(231, 34);
            txtKitapAdi.TabIndex = 0;
            // 
            // frmKitapEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1218, 686);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmKitapEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ekleme İşlemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private TextBox txtKitapSayfa;
        private Button btnEkle;
        private Label label4;
        private TextBox txtKitapTema;
        private Label label3;
        private TextBox txtKitapyazari;
        private Label label2;
        private TextBox txtKitapAdi;
    }
}