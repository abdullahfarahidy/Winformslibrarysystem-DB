namespace WindowsFormsApp1
{
    partial class Form2
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
            this.addAuthorbtn = new System.Windows.Forms.Button();
            this.UpdateAuthorbtn = new System.Windows.Forms.Button();
            this.removeAuthorBtn = new System.Windows.Forms.Button();
            this.Form1btn = new System.Windows.Forms.Button();
            this.ShowDAbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddauthTxt = new System.Windows.Forms.TextBox();
            this.addauthtxt2 = new System.Windows.Forms.TextBox();
            this.updateauthtxt2 = new System.Windows.Forms.TextBox();
            this.updateauthtxt1 = new System.Windows.Forms.TextBox();
            this.removeauthtxt2 = new System.Windows.Forms.TextBox();
            this.removeauthtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aUTHORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTH0RIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalSqlDataSet = new WindowsFormsApp1.finalSqlDataSet();
            this.aUTHORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTHORTableAdapter = new WindowsFormsApp1.finalSqlDataSetTableAdapters.AUTHORTableAdapter();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new WindowsFormsApp1.finalSqlDataSetTableAdapters.BOOKTableAdapter();
            this.aUTHORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookAuthorformbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addAuthorbtn
            // 
            this.addAuthorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorbtn.Location = new System.Drawing.Point(2, 36);
            this.addAuthorbtn.Name = "addAuthorbtn";
            this.addAuthorbtn.Size = new System.Drawing.Size(176, 55);
            this.addAuthorbtn.TabIndex = 0;
            this.addAuthorbtn.Text = "Add Author";
            this.addAuthorbtn.UseVisualStyleBackColor = true;
            this.addAuthorbtn.Click += new System.EventHandler(this.addAuthorbtn_Click);
            // 
            // UpdateAuthorbtn
            // 
            this.UpdateAuthorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAuthorbtn.Location = new System.Drawing.Point(2, 124);
            this.UpdateAuthorbtn.Name = "UpdateAuthorbtn";
            this.UpdateAuthorbtn.Size = new System.Drawing.Size(176, 55);
            this.UpdateAuthorbtn.TabIndex = 1;
            this.UpdateAuthorbtn.Text = "Update Author";
            this.UpdateAuthorbtn.UseVisualStyleBackColor = true;
            this.UpdateAuthorbtn.Click += new System.EventHandler(this.UpdateAuthorbtn_Click);
            // 
            // removeAuthorBtn
            // 
            this.removeAuthorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAuthorBtn.Location = new System.Drawing.Point(2, 211);
            this.removeAuthorBtn.Name = "removeAuthorBtn";
            this.removeAuthorBtn.Size = new System.Drawing.Size(176, 55);
            this.removeAuthorBtn.TabIndex = 2;
            this.removeAuthorBtn.Text = "remove Author";
            this.removeAuthorBtn.UseVisualStyleBackColor = true;
            this.removeAuthorBtn.Click += new System.EventHandler(this.removeAuthorBtn_Click);
            // 
            // Form1btn
            // 
            this.Form1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1btn.Location = new System.Drawing.Point(2, 301);
            this.Form1btn.Name = "Form1btn";
            this.Form1btn.Size = new System.Drawing.Size(176, 55);
            this.Form1btn.TabIndex = 3;
            this.Form1btn.Text = "Student Form";
            this.Form1btn.UseVisualStyleBackColor = true;
            this.Form1btn.Click += new System.EventHandler(this.Form1btn_Click);
            // 
            // ShowDAbtn
            // 
            this.ShowDAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDAbtn.Location = new System.Drawing.Point(987, 390);
            this.ShowDAbtn.Name = "ShowDAbtn";
            this.ShowDAbtn.Size = new System.Drawing.Size(141, 55);
            this.ShowDAbtn.TabIndex = 4;
            this.ShowDAbtn.Text = "Show Data";
            this.ShowDAbtn.UseVisualStyleBackColor = true;
            this.ShowDAbtn.Click += new System.EventHandler(this.Form2_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author Name";
            // 
            // AddauthTxt
            // 
            this.AddauthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddauthTxt.Location = new System.Drawing.Point(206, 46);
            this.AddauthTxt.Name = "AddauthTxt";
            this.AddauthTxt.Size = new System.Drawing.Size(145, 34);
            this.AddauthTxt.TabIndex = 7;
            // 
            // addauthtxt2
            // 
            this.addauthtxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addauthtxt2.Location = new System.Drawing.Point(393, 46);
            this.addauthtxt2.Name = "addauthtxt2";
            this.addauthtxt2.Size = new System.Drawing.Size(153, 34);
            this.addauthtxt2.TabIndex = 8;
            // 
            // updateauthtxt2
            // 
            this.updateauthtxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateauthtxt2.Location = new System.Drawing.Point(393, 134);
            this.updateauthtxt2.Name = "updateauthtxt2";
            this.updateauthtxt2.Size = new System.Drawing.Size(153, 34);
            this.updateauthtxt2.TabIndex = 10;
            // 
            // updateauthtxt1
            // 
            this.updateauthtxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateauthtxt1.Location = new System.Drawing.Point(206, 134);
            this.updateauthtxt1.Name = "updateauthtxt1";
            this.updateauthtxt1.Size = new System.Drawing.Size(145, 34);
            this.updateauthtxt1.TabIndex = 9;
            // 
            // removeauthtxt2
            // 
            this.removeauthtxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeauthtxt2.Location = new System.Drawing.Point(393, 221);
            this.removeauthtxt2.Name = "removeauthtxt2";
            this.removeauthtxt2.Size = new System.Drawing.Size(153, 34);
            this.removeauthtxt2.TabIndex = 12;
            // 
            // removeauthtxt
            // 
            this.removeauthtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeauthtxt.Location = new System.Drawing.Point(206, 221);
            this.removeauthtxt.Name = "removeauthtxt";
            this.removeauthtxt.Size = new System.Drawing.Size(145, 34);
            this.removeauthtxt.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aUTHORNAMEDataGridViewTextBoxColumn,
            this.aUTH0RIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aUTHORBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(567, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 374);
            this.dataGridView1.TabIndex = 13;
            // 
            // aUTHORNAMEDataGridViewTextBoxColumn
            // 
            this.aUTHORNAMEDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR_NAME";
            this.aUTHORNAMEDataGridViewTextBoxColumn.HeaderText = "AUTHOR_NAME";
            this.aUTHORNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUTHORNAMEDataGridViewTextBoxColumn.Name = "aUTHORNAMEDataGridViewTextBoxColumn";
            this.aUTHORNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aUTH0RIDDataGridViewTextBoxColumn
            // 
            this.aUTH0RIDDataGridViewTextBoxColumn.DataPropertyName = "AUTH0R_ID";
            this.aUTH0RIDDataGridViewTextBoxColumn.HeaderText = "AUTH0R_ID";
            this.aUTH0RIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUTH0RIDDataGridViewTextBoxColumn.Name = "aUTH0RIDDataGridViewTextBoxColumn";
            this.aUTH0RIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // aUTHORBindingSource2
            // 
            this.aUTHORBindingSource2.DataMember = "AUTHOR";
            this.aUTHORBindingSource2.DataSource = this.finalSqlDataSetBindingSource;
            // 
            // finalSqlDataSetBindingSource
            // 
            this.finalSqlDataSetBindingSource.DataSource = this.finalSqlDataSet;
            this.finalSqlDataSetBindingSource.Position = 0;
            // 
            // finalSqlDataSet
            // 
            this.finalSqlDataSet.DataSetName = "finalSqlDataSet";
            this.finalSqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUTHORBindingSource
            // 
            this.aUTHORBindingSource.DataMember = "AUTHOR";
            this.aUTHORBindingSource.DataSource = this.finalSqlDataSet;
            // 
            // aUTHORTableAdapter
            // 
            this.aUTHORTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.finalSqlDataSet;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // aUTHORBindingSource1
            // 
            this.aUTHORBindingSource1.DataMember = "AUTHOR";
            this.aUTHORBindingSource1.DataSource = this.finalSqlDataSet;
            // 
            // bookAuthorformbtn
            // 
            this.bookAuthorformbtn.Location = new System.Drawing.Point(2, 376);
            this.bookAuthorformbtn.Name = "bookAuthorformbtn";
            this.bookAuthorformbtn.Size = new System.Drawing.Size(196, 46);
            this.bookAuthorformbtn.TabIndex = 14;
            this.bookAuthorformbtn.Text = "Book authors ";
            this.bookAuthorformbtn.UseVisualStyleBackColor = true;
            this.bookAuthorformbtn.Click += new System.EventHandler(this.bookAuthorformbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 448);
            this.Controls.Add(this.bookAuthorformbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeauthtxt2);
            this.Controls.Add(this.removeauthtxt);
            this.Controls.Add(this.updateauthtxt2);
            this.Controls.Add(this.updateauthtxt1);
            this.Controls.Add(this.addauthtxt2);
            this.Controls.Add(this.AddauthTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowDAbtn);
            this.Controls.Add(this.Form1btn);
            this.Controls.Add(this.removeAuthorBtn);
            this.Controls.Add(this.UpdateAuthorbtn);
            this.Controls.Add(this.addAuthorbtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalSqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAuthorbtn;
        private System.Windows.Forms.Button UpdateAuthorbtn;
        private System.Windows.Forms.Button removeAuthorBtn;
        private System.Windows.Forms.Button Form1btn;
        private System.Windows.Forms.Button ShowDAbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddauthTxt;
        private System.Windows.Forms.TextBox addauthtxt2;
        private System.Windows.Forms.TextBox updateauthtxt2;
        private System.Windows.Forms.TextBox updateauthtxt1;
        private System.Windows.Forms.TextBox removeauthtxt2;
        private System.Windows.Forms.TextBox removeauthtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private finalSqlDataSet finalSqlDataSet;
        private System.Windows.Forms.BindingSource aUTHORBindingSource;
        private finalSqlDataSetTableAdapters.AUTHORTableAdapter aUTHORTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private finalSqlDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource aUTHORBindingSource1;
        private System.Windows.Forms.BindingSource finalSqlDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTH0RIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aUTHORBindingSource2;
        private System.Windows.Forms.Button bookAuthorformbtn;
    }
}