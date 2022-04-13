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
using System.Threading;

namespace Tel.Rehberi
{
    public partial class FrmLogin : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM giris where kAdi = @usr AND sifre = @pw";

            con = new SqlConnection("server = DESKTOP-RJFIMHU;Initial Catalog = rehber;Integrated Security = True");

            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@usr", txt_id.Text);
            cmd.Parameters.AddWithValue("@pw", mtxt_pw.Text);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read()){
                var result = dr.GetString(4);
                var frm = new FrmRehber();
                frm.selam = "Merhaba " + result;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");
            }

            con.Close();

        }
    }
}
