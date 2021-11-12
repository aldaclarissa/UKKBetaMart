
namespace betamart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngambar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.produkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeProduksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalKadaluarsaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.produkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new betamart.Data();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbaru = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.produkTableAdapter = new betamart.DataTableAdapters.ProdukTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btngambar
            // 
            this.btngambar.BackColor = System.Drawing.Color.Thistle;
            this.btngambar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngambar.Location = new System.Drawing.Point(32, 257);
            this.btngambar.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btngambar.Name = "btngambar";
            this.btngambar.Size = new System.Drawing.Size(143, 30);
            this.btngambar.TabIndex = 0;
            this.btngambar.Text = "Pilih Gambar";
            this.btngambar.UseVisualStyleBackColor = false;
            this.btngambar.Click += new System.EventHandler(this.btngambar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produkIDDataGridViewTextBoxColumn,
            this.namaProdukDataGridViewTextBoxColumn,
            this.kodeProduksiDataGridViewTextBoxColumn,
            this.jumlahProdukDataGridViewTextBoxColumn,
            this.tanggalKadaluarsaDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dataGridView.DataSource = this.produkBindingSource;
            this.dataGridView.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView.Location = new System.Drawing.Point(71, 157);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 283);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // produkIDDataGridViewTextBoxColumn
            // 
            this.produkIDDataGridViewTextBoxColumn.DataPropertyName = "ProdukID";
            this.produkIDDataGridViewTextBoxColumn.HeaderText = "ProdukID";
            this.produkIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produkIDDataGridViewTextBoxColumn.Name = "produkIDDataGridViewTextBoxColumn";
            this.produkIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaProdukDataGridViewTextBoxColumn
            // 
            this.namaProdukDataGridViewTextBoxColumn.DataPropertyName = "NamaProduk";
            this.namaProdukDataGridViewTextBoxColumn.HeaderText = "NamaProduk";
            this.namaProdukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaProdukDataGridViewTextBoxColumn.Name = "namaProdukDataGridViewTextBoxColumn";
            this.namaProdukDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodeProduksiDataGridViewTextBoxColumn
            // 
            this.kodeProduksiDataGridViewTextBoxColumn.DataPropertyName = "KodeProduksi";
            this.kodeProduksiDataGridViewTextBoxColumn.HeaderText = "KodeProduksi";
            this.kodeProduksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeProduksiDataGridViewTextBoxColumn.Name = "kodeProduksiDataGridViewTextBoxColumn";
            this.kodeProduksiDataGridViewTextBoxColumn.Width = 150;
            // 
            // jumlahProdukDataGridViewTextBoxColumn
            // 
            this.jumlahProdukDataGridViewTextBoxColumn.DataPropertyName = "JumlahProduk";
            this.jumlahProdukDataGridViewTextBoxColumn.HeaderText = "JumlahProduk";
            this.jumlahProdukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahProdukDataGridViewTextBoxColumn.Name = "jumlahProdukDataGridViewTextBoxColumn";
            this.jumlahProdukDataGridViewTextBoxColumn.Width = 130;
            // 
            // tanggalKadaluarsaDataGridViewTextBoxColumn
            // 
            this.tanggalKadaluarsaDataGridViewTextBoxColumn.DataPropertyName = "TanggalKadaluarsa";
            this.tanggalKadaluarsaDataGridViewTextBoxColumn.HeaderText = "TanggalKadaluarsa";
            this.tanggalKadaluarsaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalKadaluarsaDataGridViewTextBoxColumn.Name = "tanggalKadaluarsaDataGridViewTextBoxColumn";
            this.tanggalKadaluarsaDataGridViewTextBoxColumn.Width = 150;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.MinimumWidth = 6;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.Width = 170;
            // 
            // produkBindingSource
            // 
            this.produkBindingSource.DataMember = "Produk";
            this.produkBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Produk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.txtexp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtjumlah);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtproduk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btngambar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(120, 444);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtexp
            // 
            this.txtexp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "TanggalKadaluarsa", true));
            this.txtexp.Location = new System.Drawing.Point(334, 227);
            this.txtexp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(238, 35);
            this.txtexp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tanggal Kadaluarsa";
            // 
            // txtjumlah
            // 
            this.txtjumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "JumlahProduk", true));
            this.txtjumlah.Location = new System.Drawing.Point(334, 154);
            this.txtjumlah.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(238, 35);
            this.txtjumlah.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jumlah Produk";
            // 
            // txtproduk
            // 
            this.txtproduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "KodeProduksi", true));
            this.txtproduk.Location = new System.Drawing.Point(334, 86);
            this.txtproduk.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtproduk.Name = "txtproduk";
            this.txtproduk.Size = new System.Drawing.Size(238, 35);
            this.txtproduk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kode Produksi";
            // 
            // txtnama
            // 
            this.txtnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produkBindingSource, "NamaProduk", true));
            this.txtnama.Location = new System.Drawing.Point(334, 16);
            this.txtnama.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(238, 35);
            this.txtnama.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.produkBindingSource, "Foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnbaru
            // 
            this.btnbaru.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbaru.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaru.Location = new System.Drawing.Point(816, 444);
            this.btnbaru.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnbaru.Name = "btnbaru";
            this.btnbaru.Size = new System.Drawing.Size(106, 53);
            this.btnbaru.TabIndex = 1;
            this.btnbaru.Text = "Baru";
            this.btnbaru.UseVisualStyleBackColor = false;
            this.btnbaru.Click += new System.EventHandler(this.btnbaru_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnubah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnubah.Location = new System.Drawing.Point(816, 530);
            this.btnubah.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(106, 53);
            this.btnubah.TabIndex = 2;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbatal.Location = new System.Drawing.Point(816, 620);
            this.btnbatal.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(106, 53);
            this.btnbatal.TabIndex = 3;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = false;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsimpan.Location = new System.Drawing.Point(816, 717);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(106, 53);
            this.btnsimpan.TabIndex = 4;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // produkTableAdapter
            // 
            this.produkTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(445, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "BetaMart";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(482, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1056, 949);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnbaru);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngambar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbaru;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnsimpan;
        private Data data;
        private System.Windows.Forms.BindingSource produkBindingSource;
        private DataTableAdapters.ProdukTableAdapter produkTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeProduksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKadaluarsaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
    }
}

