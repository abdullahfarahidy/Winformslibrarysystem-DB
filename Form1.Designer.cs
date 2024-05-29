using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addBookbtn = new System.Windows.Forms.Button();
            this.UpdateBookbtn = new System.Windows.Forms.Button();
            this.removeBookbtn = new System.Windows.Forms.Button();
            this.ShowDatabtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLICATIONYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet1 = new WindowsFormsApp1.finalSqlDataSet1();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet = new WindowsFormsApp1.finalSqlDataSet();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.Bookidlable = new System.Windows.Forms.Label();
            this.Bookisbnlabel = new System.Windows.Forms.Label();
            this.BTitlelabel = new System.Windows.Forms.Label();
            this.BEditionlabel = new System.Windows.Forms.Label();
            this.pubyearlabel = new System.Windows.Forms.Label();
            this.Bookquantlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.form2 = new System.Windows.Forms.Button();
            this.bOOKTableAdapter = new WindowsFormsApp1.finalSqlDataSetTableAdapters.BOOKTableAdapter();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new WindowsFormsApp1.finalSqlDataSet1TableAdapters.ADMINTableAdapter();
            this.bOOKTableAdapter1 = new WindowsFormsApp1.finalSqlDataSet1TableAdapters.BOOKTableAdapter();
            this.finalSqlDataSet2 = new WindowsFormsApp1.finalSqlDataSet2();
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter2 = new WindowsFormsApp1.finalSqlDataSet2TableAdapters.BOOKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookbtn
            // 
            this.addBookbtn.Location = new System.Drawing.Point(716, 20);
            this.addBookbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBookbtn.Name = "addBookbtn";
            this.addBookbtn.Size = new System.Drawing.Size(113, 33);
            this.addBookbtn.TabIndex = 0;
            this.addBookbtn.Text = "AddBook";
            this.addBookbtn.UseVisualStyleBackColor = true;
            this.addBookbtn.Click += new System.EventHandler(this.addBookbtn_Click);
            // 
            // UpdateBookbtn
            // 
            this.UpdateBookbtn.Location = new System.Drawing.Point(716, 119);
            this.UpdateBookbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBookbtn.Name = "UpdateBookbtn";
            this.UpdateBookbtn.Size = new System.Drawing.Size(113, 34);
            this.UpdateBookbtn.TabIndex = 1;
            this.UpdateBookbtn.Text = "UpdateBook";
            this.UpdateBookbtn.UseVisualStyleBackColor = true;
            this.UpdateBookbtn.Click += new System.EventHandler(this.UpdateBookbtn_Click);
            // 
            // removeBookbtn
            // 
            this.removeBookbtn.Location = new System.Drawing.Point(716, 72);
            this.removeBookbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBookbtn.Name = "removeBookbtn";
            this.removeBookbtn.Size = new System.Drawing.Size(113, 33);
            this.removeBookbtn.TabIndex = 2;
            this.removeBookbtn.Text = "removeBook";
            this.removeBookbtn.UseVisualStyleBackColor = true;
            this.removeBookbtn.Click += new System.EventHandler(this.removeBookbtn_Click);
            // 
            // ShowDatabtn
            // 
            this.ShowDatabtn.Location = new System.Drawing.Point(806, 192);
            this.ShowDatabtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDatabtn.Name = "ShowDatabtn";
            this.ShowDatabtn.Size = new System.Drawing.Size(103, 35);
            this.ShowDatabtn.TabIndex = 3;
            this.ShowDatabtn.Text = "show Data";
            this.ShowDatabtn.UseVisualStyleBackColor = true;
            this.ShowDatabtn.Click += new System.EventHandler(this.ShowDatabtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKIDDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.eDITIONDataGridViewTextBoxColumn,
            this.pUBLICATIONYEARDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.aUTHERIDDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(788, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID_";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID_";
            this.bOOKIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN_";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN_";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE_";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE_";
            this.tITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eDITIONDataGridViewTextBoxColumn
            // 
            this.eDITIONDataGridViewTextBoxColumn.DataPropertyName = "EDITION_";
            this.eDITIONDataGridViewTextBoxColumn.HeaderText = "EDITION_";
            this.eDITIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDITIONDataGridViewTextBoxColumn.Name = "eDITIONDataGridViewTextBoxColumn";
            this.eDITIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // pUBLICATIONYEARDataGridViewTextBoxColumn
            // 
            this.pUBLICATIONYEARDataGridViewTextBoxColumn.DataPropertyName = "PUBLICATION_YEAR_";
            this.pUBLICATIONYEARDataGridViewTextBoxColumn.HeaderText = "PUBLICATION_YEAR_";
            this.pUBLICATIONYEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pUBLICATIONYEARDataGridViewTextBoxColumn.Name = "pUBLICATIONYEARDataGridViewTextBoxColumn";
            this.pUBLICATIONYEARDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY_";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY_";
            this.qUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // aUTHERIDDataGridViewTextBoxColumn
            // 
            this.aUTHERIDDataGridViewTextBoxColumn.DataPropertyName = "AUTHER_ID";
            this.aUTHERIDDataGridViewTextBoxColumn.HeaderText = "AUTHER_ID";
            this.aUTHERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUTHERIDDataGridViewTextBoxColumn.Name = "aUTHERIDDataGridViewTextBoxColumn";
            this.aUTHERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID_";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "A_ID_";
            this.aIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.finalSqlDataSet1BindingSource;
            // 
            // finalSqlDataSet1BindingSource
            // 
            this.finalSqlDataSet1BindingSource.DataSource = this.finalSqlDataSet1;
            this.finalSqlDataSet1BindingSource.Position = 0;
            // 
            // finalSqlDataSet1
            // 
            this.finalSqlDataSet1.DataSetName = "finalSqlDataSet1";
            this.finalSqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.finalSqlDataSet;
            // 
            // finalSqlDataSet
            // 
            this.finalSqlDataSet.DataSetName = "finalSqlDataSet";
            this.finalSqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(135, 119);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(86, 34);
            this.textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(245, 119);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(86, 34);
            this.textBox14.TabIndex = 21;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(355, 119);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(86, 34);
            this.textBox15.TabIndex = 20;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(465, 119);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(86, 34);
            this.textBox16.TabIndex = 19;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(575, 119);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(117, 34);
            this.textBox17.TabIndex = 18;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(25, 119);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(86, 34);
            this.textBox18.TabIndex = 17;
            // 
            // Bookidlable
            // 
            this.Bookidlable.AutoSize = true;
            this.Bookidlable.Location = new System.Drawing.Point(41, 3);
            this.Bookidlable.Name = "Bookidlable";
            this.Bookidlable.Size = new System.Drawing.Size(50, 16);
            this.Bookidlable.TabIndex = 23;
            this.Bookidlable.Text = "BookId";
            // 
            // Bookisbnlabel
            // 
            this.Bookisbnlabel.AutoSize = true;
            this.Bookisbnlabel.Location = new System.Drawing.Point(146, 3);
            this.Bookisbnlabel.Name = "Bookisbnlabel";
            this.Bookisbnlabel.Size = new System.Drawing.Size(64, 16);
            this.Bookisbnlabel.TabIndex = 24;
            this.Bookisbnlabel.Text = "Bookisbn";
            // 
            // BTitlelabel
            // 
            this.BTitlelabel.AutoSize = true;
            this.BTitlelabel.Location = new System.Drawing.Point(265, 2);
            this.BTitlelabel.Name = "BTitlelabel";
            this.BTitlelabel.Size = new System.Drawing.Size(33, 16);
            this.BTitlelabel.TabIndex = 25;
            this.BTitlelabel.Text = "Title";
            // 
            // BEditionlabel
            // 
            this.BEditionlabel.AutoSize = true;
            this.BEditionlabel.Location = new System.Drawing.Point(369, 2);
            this.BEditionlabel.Name = "BEditionlabel";
            this.BEditionlabel.Size = new System.Drawing.Size(47, 16);
            this.BEditionlabel.TabIndex = 26;
            this.BEditionlabel.Text = "edition";
            // 
            // pubyearlabel
            // 
            this.pubyearlabel.AutoSize = true;
            this.pubyearlabel.Location = new System.Drawing.Point(474, 2);
            this.pubyearlabel.Name = "pubyearlabel";
            this.pubyearlabel.Size = new System.Drawing.Size(60, 16);
            this.pubyearlabel.TabIndex = 27;
            this.pubyearlabel.Text = "PubYear";
            // 
            // Bookquantlabel
            // 
            this.Bookquantlabel.AutoSize = true;
            this.Bookquantlabel.Location = new System.Drawing.Point(613, 2);
            this.Bookquantlabel.Name = "Bookquantlabel";
            this.Bookquantlabel.Size = new System.Drawing.Size(53, 16);
            this.Bookquantlabel.TabIndex = 28;
            this.Bookquantlabel.Text = "quantity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 34);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(245, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 34);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(355, 71);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 34);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(465, 71);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 34);
            this.textBox4.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(575, 71);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 34);
            this.textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(25, 71);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 34);
            this.textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(135, 21);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 34);
            this.textBox7.TabIndex = 40;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(245, 21);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(86, 34);
            this.textBox8.TabIndex = 39;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(355, 21);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(86, 34);
            this.textBox9.TabIndex = 38;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(465, 19);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(86, 34);
            this.textBox10.TabIndex = 37;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(575, 20);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(117, 34);
            this.textBox11.TabIndex = 36;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(25, 20);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(86, 34);
            this.textBox12.TabIndex = 35;
            // 
            // form2
            // 
            this.form2.Location = new System.Drawing.Point(806, 253);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(103, 34);
            this.form2.TabIndex = 41;
            this.form2.Text = "Author Form";
            this.form2.UseVisualStyleBackColor = true;
            this.form2.Click += new System.EventHandler(this.form2_Click);
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.finalSqlDataSet1BindingSource;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKTableAdapter1
            // 
            this.bOOKTableAdapter1.ClearBeforeFill = true;
            // 
            // finalSqlDataSet2
            // 
            this.finalSqlDataSet2.DataSetName = "finalSqlDataSet2";
            this.finalSqlDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.finalSqlDataSet2;
            // 
            // bOOKTableAdapter2
            // 
            this.bOOKTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 504);
            this.Controls.Add(this.form2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Bookquantlabel);
            this.Controls.Add(this.pubyearlabel);
            this.Controls.Add(this.BEditionlabel);
            this.Controls.Add(this.BTitlelabel);
            this.Controls.Add(this.Bookisbnlabel);
            this.Controls.Add(this.Bookidlable);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowDatabtn);
            this.Controls.Add(this.removeBookbtn);
            this.Controls.Add(this.UpdateBookbtn);
            this.Controls.Add(this.addBookbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addBookbtn;
        private Button UpdateBookbtn;
        private Button removeBookbtn;
        private Button ShowDatabtn;
        private DataGridView dataGridView1;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private Label Bookidlable;
        private Label Bookisbnlabel;
        private Label BTitlelabel;
        private Label BEditionlabel;
        private Label pubyearlabel;
        private Label Bookquantlabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button form2;
        private finalSqlDataSet finalSqlDataSet;
        private BindingSource bOOKBindingSource;
        private finalSqlDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private BindingSource finalSqlDataSet1BindingSource;
        private finalSqlDataSet1 finalSqlDataSet1;
        private BindingSource aDMINBindingSource;
        private finalSqlDataSet1TableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private BindingSource bOOKBindingSource1;
        private finalSqlDataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter1;
        private DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eDITIONDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pUBLICATIONYEARDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aUTHERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private finalSqlDataSet2 finalSqlDataSet2;
        private BindingSource bOOKBindingSource2;
        private finalSqlDataSet2TableAdapters.BOOKTableAdapter bOOKTableAdapter2;
    }
}
