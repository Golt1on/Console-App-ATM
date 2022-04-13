using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tel.Rehberi
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public string selam;

        void nocek()
        {
            con = new SqlConnection("server = DESKTOP-RJFIMHU;Initial Catalog = rehber;Integrated Security = True");
            da = new SqlDataAdapter("Select * from telrehber", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "telrehber");
            dtg_rehber.DataSource = ds.Tables["telrehber"];
            con.Close();
        }

        private void dtg_rehber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmRehber_Load(object sender, EventArgs e)
        {
            lbl_merhaba.Text = selam;
            nocek();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into telrehber(ad,soyad,telefon) values ('" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_telno.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            nocek();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update telrehber set ad = '" + txt_ad.Text + "',soyad='" + txt_soyad.Text + "',telefon='" + txt_telno.Text + "'where id='" + txt_sira.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            nocek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from telrehber where id=" + txt_sira.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            nocek();
        }
    }
}
