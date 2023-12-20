using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
  
    public partial class frmUyeEkleme : Form
    {
        private MySqlCommand cmd;
        private MySqlConnection con;
        public frmUyeEkleme()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=kutuphane; Uid=root; Pwd=''");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO uyeler(uyeadi,uyetelno,uyetcno) VALUES (@uyeadi,@uyetelno,@uyetcno)";
            cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@uyeadi", txyUyeadi.Text);
            cmd.Parameters.AddWithValue("@uyetelno", txtTelno.Text);
            cmd.Parameters.AddWithValue("@uyetcno", txtTcno.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ekleme başarılı.");
            con.Close();
        }
    }
}
