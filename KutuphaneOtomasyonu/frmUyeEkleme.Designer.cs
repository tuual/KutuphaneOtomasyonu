namespace KutuphaneOtomasyonu
{
    partial class frmUyeEkleme
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
            btnEkle = new Button();
            label4 = new Label();
            txtTcno = new TextBox();
            label3 = new Label();
            txtTelno = new TextBox();
            label2 = new Label();
            txyUyeadi = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 126);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 0;
            label1.Text = "Üye Ekleme İşlemi";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTcno);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTelno);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txyUyeadi);
            panel2.Location = new Point(238, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 362);
            panel2.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Blue;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(206, 288);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(173, 49);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Üye Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(178, 204);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 5;
            label4.Text = "Üye TCNO";
            // 
            // txtTcno
            // 
            txtTcno.Location = new Point(178, 230);
            txtTcno.Multiline = true;
            txtTcno.Name = "txtTcno";
            txtTcno.Size = new Size(231, 34);
            txtTcno.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 121);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 3;
            label3.Text = "Üye Telefon Numarası";
            // 
            // txtTelno
            // 
            txtTelno.Location = new Point(178, 147);
            txtTelno.Multiline = true;
            txtTelno.Name = "txtTelno";
            txtTelno.Size = new Size(231, 34);
            txtTelno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 40);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 1;
            label2.Text = "Üye Adı Soyadı";
            // 
            // txyUyeadi
            // 
            txyUyeadi.Location = new Point(178, 66);
            txyUyeadi.Multiline = true;
            txyUyeadi.Name = "txyUyeadi";
            txyUyeadi.Size = new Size(231, 34);
            txyUyeadi.TabIndex = 0;
            // 
            // frmUyeEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 598);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUyeEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekleme";
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
        private Label label4;
        private TextBox txtTcno;
        private Label label3;
        private TextBox txtTelno;
        private Label label2;
        private TextBox txyUyeadi;
        private Button btnEkle;
    }
}