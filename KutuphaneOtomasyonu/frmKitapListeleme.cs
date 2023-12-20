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
    public partial class frmKitapListeleme : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        int id;
        public frmKitapListeleme()
        {
            InitializeComponent();
        }
        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM kitaplar";
            con = new MySqlConnection("Server=localhost; Database=Kutuphane; Uid=root; Pwd=''");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(readQuery, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView kontrolüne verileri yükle
                dataGridView1.DataSource = dataTable;
            }



        }
        private void frmKitapListeleme_Load(object sender, EventArgs e)
        {
            tableUpdate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(selectRow.Cells["ID"].Value);


            }
        }

        private void btnKitapKaldirma_Click(object sender, EventArgs e)
        {
            String query = "Delete From kitaplar WHERE ID=" + id;


            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Seçili Kitap Silindi");
            con.Close();
            tableUpdate();

        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                String updateQuery = "UPDATE kitaplar set kitapadi=@kitapadi,kitapyazari=@kitapyazari,kitaptemasi=@kitaptemasi,kitapsayfa=@kitapsayfa,kitapdurum=@kitapdurum WHERE ID=" + id;
                con.Open();
                cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                cmd.Parameters.AddWithValue("@kitapyazari", txtKitapyazari.Text);
                cmd.Parameters.AddWithValue("@kitaptemasi", txtKitapTema.Text);
                cmd.Parameters.AddWithValue("@kitapsayfa", txtKitapSayfa.Text);
                cmd.Parameters.AddWithValue("@kitapdurum", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                tableUpdate();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    
}
}
