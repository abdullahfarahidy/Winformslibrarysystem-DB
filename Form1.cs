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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'finalSqlDataSet2.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter2.Fill(this.finalSqlDataSet2.BOOK);

            this.bOOKTableAdapter.Fill(this.finalSqlDataSet.BOOK);


        }

        private void addBookbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "INSERT INTO BOOK (BOOK_ID_, ISBN_, TITLE_, EDITION_, PUBLICATION_YEAR_, QUANTITY_) VALUES (@BookId, @ISBN, @Title, @Edition, @PublicationYear, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(textBox12.Text));
                    cmd.Parameters.AddWithValue("@ISBN", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Title", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Edition", textBox9.Text);
                    cmd.Parameters.AddWithValue("@PublicationYear", Convert.ToInt32(textBox10.Text));
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox11.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Insertion was successfully completed");
        }

        private void removeBookbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "DELETE FROM BOOK WHERE BOOK_ID_ = @BookId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(textBox6.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Deletion was successfully completed");
        }

        private void UpdateBookbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VCAH6IJ\\SQLEXPRESS;Initial Catalog=finalSql;Integrated Security=True"))
            {
                string query = "UPDATE BOOK SET ISBN_ = @ISBN, TITLE_ = @Title, EDITION_ = @Edition, PUBLICATION_YEAR_ = @PublicationYear, QUANTITY_ = @Quantity WHERE BOOK_ID_ = @BookId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ISBN", textBox13.Text);
                    cmd.Parameters.AddWithValue("@Title", textBox14.Text);
                    cmd.Parameters.AddWithValue("@Edition", textBox15.Text);
                    cmd.Parameters.AddWithValue("@PublicationYear", Convert.ToInt32(textBox16.Text));
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox17.Text));
                    cmd.Parameters.AddWithValue("@BookId", Convert.ToInt32(textBox18.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Update was successfully completed");
        }


        private void ShowDatabtn_Click(object sender, EventArgs e)
        {
            this.bOOKTableAdapter.Fill(this.finalSqlDataSet.BOOK);
        }
        private void form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        
    }
}
