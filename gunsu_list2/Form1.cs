﻿using System;
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

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

        
        
        }

        private void button2_Click(object sender, EventArgs e) //グリッドビュー作成
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
