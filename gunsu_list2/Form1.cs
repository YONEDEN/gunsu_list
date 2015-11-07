using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunsu_list2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        //private DataGridView dataGridView1 = DataGridView();

        
        
        }

        public void button2_Click(object sender, EventArgs e) //グリッドビュー作成
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  string book2 =((Form1)this.Owner).book.Text;
          //  ((Form1)this.Owner).dgv.Rows.Add(book2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
