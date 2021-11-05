using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace school
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        veritabani veri = new veritabani();

        private void ograncilerilistele()
        {
            DataTable dt = veri.veriAl("Select * from ogrenciSorgu");

            dataGridView1.DataSource = dt;
        }

        private void odevlistele()
        {
            DataTable dt = veri.veriAl("Select * from odevSorgu");

            dataGridView2.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            ograncilerilistele();

            DataTable dtsinif = veri.veriAl("Select * from siniflar");
            combosinif.DisplayMember = "sinif";
            combosinif.ValueMember = "id";
            combosinif.DataSource = dtsinif;

            DataTable dtders = veri.veriAl("Select * from dersler");
            comboders.DisplayMember = "ad";
            comboders.ValueMember = "ders_id";
            comboders.DataSource = dtders;

            DataTable dtnum = veri.veriAl("Select * from ogrenciler");
            comboOgrNum.DisplayMember = "numara";
            comboOgrNum.ValueMember = "id";
            comboOgrNum.DataSource = dtnum;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("Insert into ogrenciler(ad,soyad,numara,sinifid) values(@ad, @soyad, @numara, @sinifid)");

            cmd.Parameters.AddWithValue("@ad", textad.Text);
            cmd.Parameters.AddWithValue("@soyad", textsoyad.Text);
            cmd.Parameters.AddWithValue("@numara", textnumara.Text);
            cmd.Parameters.AddWithValue("@sinifid", combosinif.SelectedValue.ToString());

            int sonuc = veri.kayitIslem(cmd);

            if (sonuc > 0)
            {
                ograncilerilistele();

                MessageBox.Show("Kayit Basarili");
            }
            else {

                MessageBox.Show("Kayit Yapilamadi");
            }
          
        }
        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("Insert into odevler(ogr_id, ders_id, puan) values (@ogr_id, @ders_id, @puan )");

            cmd.Parameters.AddWithValue("@ogr_id", comboOgrNum.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@ders_id", comboders.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@puan", textPuan.Text);

            int sonuc = veri.kayitIslem(cmd);

            if (sonuc > 0)
            {
                odevlistele();

                MessageBox.Show("Kayit Basarili");
            }
            else
            {

                MessageBox.Show("Kayit Yapilamadi");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Secim yapiniz.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            OleDbCommand cmd = new OleDbCommand("Delete from ogrenciler where id=@id");
            cmd.Parameters.AddWithValue("@id", id);

            int sonuc = veri.kayitIslem(cmd);

            if (sonuc > 0)
            {
                ograncilerilistele();

                MessageBox.Show("Kayit Silindi");
            }
            else
            {
                MessageBox.Show("Kayit Silinemedi");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textnumara.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            combosinif.Text = dataGridView1.Rows[e.RowIndex].Cells["sinif"].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Secim yapiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            OleDbCommand cmd = new OleDbCommand("Update ogrenciler set ad=@ad, soyad=@soyad, numara=@numara, sinifid=@sinifid where id=@id");
            cmd.Parameters.AddWithValue("@ad", textad.Text);
            cmd.Parameters.AddWithValue("@soyad", textsoyad.Text);
            cmd.Parameters.AddWithValue("@numara", textnumara.Text);
            cmd.Parameters.AddWithValue("@sinifid", combosinif.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@id", id);

            int sonuc = veri.kayitIslem(cmd);

            if (sonuc > 0)
            {
                ograncilerilistele();

                MessageBox.Show("Kayit Güncellendi");
            }
            else
            {

                MessageBox.Show("Kayit Güncellenemedi");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxogradfiltre_TextChanged(object sender, EventArgs e)
        {
            string adfiltre = textBoxogradfiltre.Text;

            string sql = string.Format("Select * from ogrenciSorgu where ad like '%{0}%'", adfiltre);

            DataTable dtfiltre = veri.veriAl(sql);

            dataGridView1.DataSource = dtfiltre;
        }

        private void buttonnumfiltre_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Select * from ogrenciSorgu where numara = {0}", textBoxogrnumfiltre.Text);

            DataTable dtfiltre = veri.veriAl(sql);

            dataGridView1.DataSource = dtfiltre;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void combosinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiltre2_TextChanged(object sender, EventArgs e)
        {
            string adfiltre = textBoxFiltre2.Text;

            string sql = string.Format("Select * from odevSorgu where ad like '%{0}%'", adfiltre);

            DataTable dtfiltre = veri.veriAl(sql);

            dataGridView2.DataSource = dtfiltre;
        }

        private void btnNumFiltre2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Select * from odevSorgu where numara = {0}", textBoxNumFiltre2.Text);

            DataTable dtfiltre = veri.veriAl(sql);

            dataGridView2.DataSource = dtfiltre;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdevListe_Click(object sender, EventArgs e)
        {
            odevlistele();
        }

        
    }
}
