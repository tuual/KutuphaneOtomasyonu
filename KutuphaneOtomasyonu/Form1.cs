namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void emanetKitapListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �yeEkleme��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeEkleme frmUyeEkleme = new frmUyeEkleme();
            frmUyeEkleme.Show();

        }

        private void �yeListeleme��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeListeleme frmUyeListeleme = new frmUyeListeleme();
            frmUyeListeleme.Show();
        }

        private void kitapEkleme��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapEkleme frmKitapEkleme = new frmKitapEkleme();
            frmKitapEkleme.Show();
        }

        private void kitapListeleme��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapListeleme frmKitapListeleme = new frmKitapListeleme();  
            frmKitapListeleme.Show();
        }
    }
}