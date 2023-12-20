namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            üyeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            üyeEklemeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            üyeListelemeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapEklemeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapListelemeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 143);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(948, 111);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 1;
            label2.Text = "Furkan Demirel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 54);
            label1.Name = "label1";
            label1.Size = new Size(485, 37);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyonu Admin Paneli";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { üyeİşlemleriToolStripMenuItem, kitapİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1087, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            üyeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { üyeEklemeİşlemleriToolStripMenuItem, üyeListelemeİşlemleriToolStripMenuItem });
            üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            üyeİşlemleriToolStripMenuItem.Size = new Size(108, 24);
            üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            // 
            // üyeEklemeİşlemleriToolStripMenuItem
            // 
            üyeEklemeİşlemleriToolStripMenuItem.Name = "üyeEklemeİşlemleriToolStripMenuItem";
            üyeEklemeİşlemleriToolStripMenuItem.Size = new Size(244, 26);
            üyeEklemeİşlemleriToolStripMenuItem.Text = "Üye Ekleme İşlemleri";
            üyeEklemeİşlemleriToolStripMenuItem.Click += üyeEklemeİşlemleriToolStripMenuItem_Click;
            // 
            // üyeListelemeİşlemleriToolStripMenuItem
            // 
            üyeListelemeİşlemleriToolStripMenuItem.Name = "üyeListelemeİşlemleriToolStripMenuItem";
            üyeListelemeİşlemleriToolStripMenuItem.Size = new Size(244, 26);
            üyeListelemeİşlemleriToolStripMenuItem.Text = "Üye Listeleme İşlemleri";
            üyeListelemeİşlemleriToolStripMenuItem.Click += üyeListelemeİşlemleriToolStripMenuItem_Click;
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEklemeİşlemleriToolStripMenuItem, kitapListelemeİşlemleriToolStripMenuItem });
            kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            kitapİşlemleriToolStripMenuItem.Size = new Size(114, 24);
            kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemeri";
            // 
            // kitapEklemeİşlemleriToolStripMenuItem
            // 
            kitapEklemeİşlemleriToolStripMenuItem.Name = "kitapEklemeİşlemleriToolStripMenuItem";
            kitapEklemeİşlemleriToolStripMenuItem.Size = new Size(254, 26);
            kitapEklemeİşlemleriToolStripMenuItem.Text = "Kitap Ekleme İşlemleri";
            kitapEklemeİşlemleriToolStripMenuItem.Click += kitapEklemeİşlemleriToolStripMenuItem_Click;
            // 
            // kitapListelemeİşlemleriToolStripMenuItem
            // 
            kitapListelemeİşlemleriToolStripMenuItem.Name = "kitapListelemeİşlemleriToolStripMenuItem";
            kitapListelemeİşlemleriToolStripMenuItem.Size = new Size(254, 26);
            kitapListelemeİşlemleriToolStripMenuItem.Text = "Kitap Listeleme İşlemleri";
            kitapListelemeİşlemleriToolStripMenuItem.Click += kitapListelemeİşlemleriToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 553);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem üyeEklemeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem üyeListelemeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapEklemeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapListelemeİşlemleriToolStripMenuItem;
    }
}