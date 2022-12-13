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

namespace MessangerFormApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDb;Integrated Security=True");
        public string Number;
        private void Form3_Load(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            // İsim ve numara yazdırıldı
            Lbl_Numara.Text = Number;
            con.Open();
            SqlCommand com = new SqlCommand("select * from Tbl_People where number = @p1", con);
            com.Parameters.AddWithValue("@p1", Lbl_Numara.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Lbl_Isim.Text = dr[1] + " " + dr[2];
            }
            else
            {
                MessageBox.Show("Bağlantı kurulamadı lütfen daha sonra tekrar denyin.", "Bigilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            con.Close();


            // Gelen kutusu
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "select (Tbl_People.FIRSTNAME + ' ' + Tbl_People.LASTNAME) as [Ad Soyad] ,  Tbl_Messager.TITLE as Başlık , Tbl_Messager.CONTENTT as Mesaj  from Tbl_Messager inner join Tbl_People on Tbl_Messager.SENDER = Tbl_People.NUMBER where RECEIVER =" + Number,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Dgv_Gelen.DataSource = dt;

            // Gönderilen Kutusu
            SqlDataAdapter da2 =
                new SqlDataAdapter(
                    "select (Tbl_People.FIRSTNAME + ' ' + Tbl_People.LASTNAME) AS [Ad Soyad], Tbl_Messager.TITLE AS Başlık, Tbl_Messager.CONTENTT AS Mesa From Tbl_Messager inner Join Tbl_People on Tbl_Messager.SENDER = Tbl_People.NUMBER where SENDER = " + Number, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Dgv_Gonderilen.DataSource = dt2;
        }

        private void Btn_Gonder_Click(object sender, EventArgs e)
        {
            if (Txt_Alici.Text == "" || Txt_Alici.Text == " ")
            {
                MessageBox.Show("Lütfen gönderici alanını ve mesaj alanını boş bırakmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand com =
                    new SqlCommand(
                        "insert into Tbl_Messager (SENDER,RECEIVER,TITLE,CONTENTT) values(@sender,@receiver,@title,@content)",
                        con);
                com.Parameters.AddWithValue("@sender", Number);
                com.Parameters.AddWithValue("@receiver", Txt_Alici.Text);
                com.Parameters.AddWithValue("@title", Txt_Baslik.Text);
                com.Parameters.AddWithValue("@content", Rtx_Mesaj.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Mesajınız başarılı bir şekilde gönderildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                List();
            }

        }

        private void Dgv_Gelen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = Dgv_Gelen.SelectedCells[0].RowIndex;
            Txt_Alici.Text = Dgv_Gelen.Rows[sec].Cells[0].Value.ToString();
            Txt_Baslik.Text = Dgv_Gelen.Rows[sec].Cells[1].Value.ToString();
            Rtx_Mesaj.Text = Dgv_Gelen.Rows[sec].Cells[2].Value.ToString();
        }

        private void Dgv_Gonderilen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = Dgv_Gonderilen.SelectedCells[0].RowIndex;
            Txt_Alici.Text = Dgv_Gonderilen.Rows[sec].Cells[0].Value.ToString();
            Txt_Baslik.Text = Dgv_Gonderilen.Rows[sec].Cells[1].Value.ToString();
            Rtx_Mesaj.Text = Dgv_Gonderilen.Rows[sec].Cells[2].Value.ToString();
        }
    }
}
