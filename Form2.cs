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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addAuthorbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "INSERT INTO AUTHOR (AUTHOR_NAME, AUTHOR_ID) VALUES (@AuthorName, @AuthorId)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", AddauthTxt.Text);
                    cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(addauthtxt2.Text));  // Assuming AddauthTxt is the TextBox for AUTHOR_ID
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Insertion was successfully completed");
        }

        private void UpdateAuthorbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "UPDATE AUTHOR SET AUTHOR_NAME = @AuthorName WHERE AUTHOR_ID = @AuthorId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", updateauthtxt1.Text);
                    cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(updateauthtxt2.Text));  // Assuming updateauthtxt2 is the TextBox for AUTHOR_ID
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Update was successfully completed");
        }

        private void removeAuthorBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "DELETE FROM AUTHOR WHERE AUTHOR_ID = @AuthorId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(removeauthtxt2.Text));  // Assuming removeauthtxt2 is the TextBox for AUTHOR_ID
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Deletion was successfully completed");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalSqlDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.finalSqlDataSet.BOOK);
            // TODO: This line of code loads data into the 'finalSqlDataSet.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.finalSqlDataSet.AUTHOR);

        }
        private void Form1btn_Click(Object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void bookAuthorformbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
                this.Hide();
        }
    }
}
