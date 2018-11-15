using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePartitionTool
{
    public partial class Form_RuleAdd : Form
    {
        public Form_RuleAdd()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能輸入英文和數字
            if ((e.KeyChar >= (Char)48 && e.KeyChar <= (Char)57) ||
                (e.KeyChar >= (Char)65 && e.KeyChar <= (Char)90) ||
                (e.KeyChar >= (Char)97 && e.KeyChar <= (Char)122) ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8 )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能輸入檔名允許的字元
            if ((e.KeyChar >= (Char)48 && e.KeyChar <= (Char)57) ||
                (e.KeyChar >= (Char)64 && e.KeyChar <= (Char)91) ||
                (e.KeyChar >= (Char)97 && e.KeyChar <= (Char)123) ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8 ||
               e.KeyChar == (Char)93 || e.KeyChar == (Char)95 || e.KeyChar == (Char)125)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_FileNameExtension.Text != "")
            {
                string rule = textBox_FileNameExtension.Text + "," + textBox_NewName.Text;
                Form_Main main = (Form_Main)this.Owner;
                main.RuleList_Add(rule);
            }
            else
            {
                MessageBox.Show("輸入副檔名空白", "輸入副檔名空白", MessageBoxButtons.OK);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Main main = (Form_Main)this.Owner;
            main.RuleAdd_ButtonEnable();
            this.Close();
        }

        private void Form_RuleAdd_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
