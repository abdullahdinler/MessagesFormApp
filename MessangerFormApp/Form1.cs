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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDb;Integrated Security=True");
        private void Btn_Kayit_Click(object sender, EventArgs e)
        {
            Frm2();
        }

        private void Frm2()
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            if (Mtb_Number.Text == "" || Mtb_Number.Text == " ")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Bigilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("select * from Tbl_People where number = @p1 and password = @p2", con);
                com.Parameters.AddWithValue("@p1", Mtb_Number.Text);
                com.Parameters.AddWithValue("@p2", Txt_Password.Text);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    Form3 frm3 = new Form3();
                    frm3.Number = Mtb_Number.Text;
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı. Kayıt formuna yönlendirileceksiniz.", "Bigilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Frm2(); // Kayıt eşlesmedi ve kayıt olması için form 2 yönlendirildi.
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
