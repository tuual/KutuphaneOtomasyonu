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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyonu
{
    public partial class frmUyeListeleme : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        int id;
        public frmUyeListeleme()
        {
            InitializeComponent();
        }

        private void frmUyeListeleme_Load(object sender, EventArgs e)
        {
            tableUpdate();
        }

        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM uyeler";
            con = new MySqlConnection("Server=localhost; Database=Kutuphane; Uid=root; Pwd=''");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(readQuery, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView kontrolüne verileri yükle
                dataGridView1.DataSource = dataTable;
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(selectRow.Cells["ID"].Value);


            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                String updateQuery = "UPDATE uyeler set uyeadi=@uyeadi,uyetelno=@uyetelno,uyetcno=@uyetcno WHERE ID=" + id;
                con.Open();
                cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@uyeadi", txyUyeadi.Text);
                cmd.Parameters.AddWithValue("@uyetelno", txtTelno.Text);
                cmd.Parameters.AddWithValue("@uyetcno", txtTcno.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnKaldirma_Click(object sender, EventArgs e)
        {
            String query = "Delete From uyeler WHERE ID=" + id;
            
                
                    con.Open();
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçili Üye Silindi");
                    con.Close();
                    tableUpdate();
                
            }
        }
    }

