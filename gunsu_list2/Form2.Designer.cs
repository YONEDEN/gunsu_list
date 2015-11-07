namespace gunsu_list2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auth_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.review_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_list = new gunsu_list2.Product_list();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book,
            this.p_number,
            this.p_name,
            this.author,
            this.auth_num,
            this.style,
            this.genre,
            this.series,
            this.review_text});
            this.dataGridView1.DataSource = this.productlistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(994, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // book
            // 
            this.book.HeaderText = "掲載号";
            this.book.Name = "book";
            // 
            // p_number
            // 
            this.p_number.HeaderText = "作品番号";
            this.p_number.Name = "p_number";
            // 
            // p_name
            // 
            this.p_name.HeaderText = "作品名";
            this.p_name.Name = "p_name";
            // 
            // author
            // 
            this.author.HeaderText = "著者名";
            this.author.Name = "author";
            // 
            // auth_num
            // 
            this.auth_num.HeaderText = "著者作品番号";
            this.auth_num.Name = "auth_num";
            // 
            // style
            // 
            this.style.HeaderText = "部門";
            this.style.Name = "style";
            // 
            // genre
            // 
            this.genre.HeaderText = "ジャンル";
            this.genre.Name = "genre";
            // 
            // series
            // 
            this.series.HeaderText = "連載回数";
            this.series.Name = "series";
            // 
            // review_text
            // 
            this.review_text.HeaderText = "レビュー";
            this.review_text.Name = "review_text";
            // 
            // productlistBindingSource
            // 
            this.productlistBindingSource.DataSource = this.product_list;
            this.productlistBindingSource.Position = 0;
            // 
            // product_list
            // 
            this.product_list.DataSetName = "Product_list";
            this.product_list.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 377);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn book;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn auth_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn review_text;
        private System.Windows.Forms.BindingSource productlistBindingSource;
        private Product_list product_list;
    }
}