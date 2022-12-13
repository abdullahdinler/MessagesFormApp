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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDb;Integrated Security=True");
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            Frm1();
        }

        private void Frm1()
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Btn_Kayit_Click(object sender, EventArgs e)
        {
            
            if (Txt_Name.Text == "" || Txt_Name.Text == " ")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.","Bigilendirme",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
                SqlCommand com =
                    new SqlCommand(
                        "insert into Tbl_People (firstname,lastname,number,password) values(@p1,@p2,@p3,@p4)", con);
                com.Parameters.AddWithValue("@p1", Txt_Name.Text);
                com.Parameters.AddWithValue("@p2", Txt_LastName.Text);
                com.Parameters.AddWithValue("@p3", Mtb_Number.Text);
                com.Parameters.AddWithValue("@p4", Mtb_Password.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başaralı bir şekilde yapıldı. Giriş formuna yönlendiridiniz.", "Bigilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Frm1();
            }
        }
    }
}
