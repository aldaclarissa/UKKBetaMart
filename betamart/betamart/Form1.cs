using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Apakah kamu yakin akan menghapus data ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    produkBindingSource.RemoveCurrent();
            }
        }

        private void btngambar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbaru_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                txtnama.Focus();
                this.data.Produk.AddProdukRow(this.data.Produk.NewProdukRow());
                produkBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                produkBindingSource.ResetBindings(false);
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtnama.Focus();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            produkBindingSource.ResetBindings(false);
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                produkBindingSource.EndEdit();
                produkTableAdapter.Update(this.data.Produk);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                produkBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data.Produk' table. You can move, or remove it, as needed.
            this.produkTableAdapter.Fill(this.data.Produk);
            produkBindingSource.DataSource = this.data.Produk;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
