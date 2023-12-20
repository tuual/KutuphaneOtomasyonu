using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmKitapEkleme : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        public frmKitapEkleme()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=kutuphane; Uid=root; Pwd=''");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String query = "Insert Into kitaplar(kitapadi,kitapyazari,kitaptemasi,kitapsayfa,kitapdurum) VALUES(@kitapadi,@kitapyazari,@kitaptemasi,@kitapsayfa,@kitapdurum)";
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@kitapyazari", txtKitapyazari.Text);
            cmd.Parameters.AddWithValue("@kitaptemasi", txtKitapTema.Text);
            cmd.Parameters.AddWithValue("@kitapsayfa", txtKitapSayfa.Text);
            cmd.Parameters.AddWithValue("@kitapdurum", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ekleme başarılı");
            con.Close();
        }
    }
}
