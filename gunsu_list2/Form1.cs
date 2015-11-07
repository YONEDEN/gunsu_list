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

            //DataTableを作成する
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            //文字列型のWeek列を追加する
            dt.Columns.Add("no.", typeof(int));
            dt.Columns.Add("掲載号", typeof(string));
            dt.Columns.Add("作品名", typeof(string));
            dt.Columns.Add("著者", typeof(string));
            dt.Columns.Add("著者作品番号", typeof(string));
            dt.Columns.Add("部門", typeof(string));
            dt.Columns.Add("ジャンル", typeof(string));
            dt.Columns.Add("連載回数", typeof(string));
            dt.Columns.Add("レビュー", typeof(string));
            //Week列に日曜日～土曜日のデータを追加する
            //dt.Rows.Add("日曜日");
            //dt.Rows.Add("月曜日");
            //dt.Rows.Add("火曜日");
            //DataGridViewにデータソースを設定する
            dataGridView1.DataSource = dt;
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
       　　　     //ComboBoxのリストに表示する項目を設定する
            style.Items.Add("ゲストコラム");
            style.Items.Add("連載");
            style.Items.Add("短編読切");
            style.Items.Add("掌編読切");
            style.Items.Add("コラボイラスト");
            style.Items.Add("イラスト");
            style.Items.Add("既刊紹介");
            style.Items.Add("表紙イラスト");
            style.Items.Add("表紙デザイン");
            style.Items.Add("編集");
 
            genre.Items.Add("小説");
            genre.Items.Add("詩集");
            genre.Items.Add("エッセイ");
            genre.Items.Add("ハウツー");
            genre.Items.Add("イラスト");
            genre.Items.Add("コミック");
            genre.Items.Add("翻訳");


            book.Items.Add("14年02月号");
            book.Items.Add("14年03月号");
            book.Items.Add("14年03月号");
            book.Items.Add("14年04月号");
            book.Items.Add("14年05月号");
            book.Items.Add("14年06月号");
            book.Items.Add("14年07月号");
            book.Items.Add("14年08月号");
            book.Items.Add("14年09月号");
            book.Items.Add("14年10月号");
            book.Items.Add("14年11月号");
            book.Items.Add("14年12月号");
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

        public void button1_Click(object sender, EventArgs e) //新規作品ボタン押し下げ
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            string book2 = book.Text +" " + style.Text +" "+ genre.Text;
         //   MessageBox.Show(book2,"選択");
            DataRow newrow = ds.Tables["table"].NewRow();
            newrow["掲載号"] = book;
            newrow["部門"] = style;
            ds.Tables["table"].Rows.Add(newrow);
        }
        
    }
}
