namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLICATIONYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet2 = new WindowsFormsApp1.finalSqlDataSet2();
            this.bOOKTableAdapter = new WindowsFormsApp1.finalSqlDataSet2TableAdapters.BOOKTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Author ID to find related Books";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "FindBooks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(418, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 38);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 336);
            this.dataGridView1.TabIndex = 3;
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
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.finalSqlDataSet2BindingSource;
            // 
            // finalSqlDataSet2BindingSource
            // 
            this.finalSqlDataSet2BindingSource.DataSource = this.finalSqlDataSet2;
            this.finalSqlDataSet2BindingSource.Position = 0;
            // 
            // finalSqlDataSet2
            // 
            this.finalSqlDataSet2.DataSetName = "finalSqlDataSet2";
            this.finalSqlDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(776, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource finalSqlDataSet2BindingSource;
        private finalSqlDataSet2 finalSqlDataSet2;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private finalSqlDataSet2TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLICATIONYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}