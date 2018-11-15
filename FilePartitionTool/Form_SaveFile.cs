using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilePartitionTool
{
    public partial class Form_SaveFile : Form
    {
        public Form_SaveFile()
        {
            InitializeComponent();
        }

        private void textBox_FileName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form_SaveFile_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_FileName.Text != "")
            {
                Form_Main form_main = (Form_Main)this.Owner;
                form_main.SaveRuleFile(textBox_FileName.Text);
                form_main.button_Save_Enable();
                this.Close();
            }
            else
            {
                MessageBox.Show("FileName is Empty");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Main form_main = (Form_Main)this.Owner;
            form_main.button_Save_Enable();
            this.Close();
        }
    }
}
