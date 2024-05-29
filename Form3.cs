using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.bOOKTableAdapter.Fill(this.finalSqlDataSet2.BOOK);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "SELECT * from BOOK  WHERE A_ID_=@AuthorId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(textBox1.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("you can now see matching books");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
