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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections;
namespace FilePartitionTool
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        private void dirFiles(string _entryPath)
        {
            //DirectoryInfo dirInfo = new DirectoryInfo(_entryPath);
            //if (dirInfo.Exists == false) return;

            //// DirectoryInfo.GetFileSystemInfos() 會回傳 Directory 和 File 兩種類型檔案，
            //// 相當於執行 DirectoryInfo.GetFiles 和 DirectoryInfo.GetDirectories
            //foreach (FileSystemInfo info in dirInfo.GetFileSystemInfos())
            //{
            //    dirFiles(info.FullName);
            //}
        }

        private void listBox_DirList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox_DirList_DragDrop(object sender, DragEventArgs e)
        {
            string[] entriesPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string entryPath in entriesPath)
            {
                if (Directory.Exists(entryPath))
                {
                    listBox_DirList.Items.Add(entryPath);
                }
            }
        }
        public void RuleList_Add(string rule)
        {
            string[] temp = rule.Split(',');
            if (!RuleList.Contains(temp[0]))
            {
                listBox_RuleList.Items.Add(rule);
            }
        }
        public void RuleAdd_ButtonEnable()
        {
            button_AddRule.Enabled = true;
        }
        private void button_AddRule_Click(object sender, EventArgs e)
        {
            button_AddRule.Enabled = false;
            Form_RuleAdd form_rule = new Form_RuleAdd();
            form_rule.Location = this.Location;
            form_rule.Owner = this;
            form_rule.Show();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LoadRuleFile();
        }
        Hashtable RuleFile = new Hashtable();
        private void LoadRuleFile()
        {
            listBox_RuleFile.Items.Clear();
            string[] rulefile;
            rulefile = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.rule");
            foreach (string temp in rulefile)
            {
                var rule = Regex.Match(temp, @"[\\](?<rule_name>[^.\\]+)[.]rule");
                listBox_RuleFile.Items.Add(rule.Groups["rule_name"].Value.ToString());
                try
                {
                    RuleFile.Add(rule.Groups["rule_name"].Value.ToString(), temp);
                }
                catch
                {

                }
            }
        }

        private void button_DelRule_Click(object sender, EventArgs e)
        {
            if (listBox_RuleList.Items.Count > 0 && listBox_RuleList.SelectedIndex >= 0)
            {
                var item = listBox_RuleList.Items[listBox_RuleList.SelectedIndex];
                listBox_RuleList.Items.Remove(item);
                string[] temp = item.ToString().Split(',');
                RuleList.Remove(temp[0]);
            }
        }
        public void SaveRuleFile(string filename)
        {
            if (listBox_RuleList.Items.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + filename + ".rule"))
                {
                    foreach (var item in listBox_RuleList.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
                LoadRuleFile();
            }
        }
        public void button_Save_Enable()
        {
            button_Save.Enabled = true;
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            button_Save.Enabled = false;
            Form_SaveFile form_savefile = new Form_SaveFile();
            form_savefile.Owner = this;
            form_savefile.Show();
        }
        Hashtable RuleList = new Hashtable();
        private void listBox_RuleFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_RuleFile.Items.Count > 0 && listBox_RuleFile.SelectedIndex >= 0)
            {
                RuleList.Clear();
                listBox_RuleList.Items.Clear();
                string key = listBox_RuleFile.Items[listBox_RuleFile.SelectedIndex].ToString();
                using(StreamReader sr = new StreamReader((string)RuleFile[key]))
                {
                    string rule = string.Empty;
                    while((rule = sr.ReadLine()) != null)
                    {
                        string[] temp = rule.Split(',');
                        if(temp.Length == 2)
                        {
                            if (!RuleList.Contains(temp[0]))
                            {
                                RuleList.Add(temp[0], temp[1]);
                                listBox_RuleList.Items.Add(temp[0] + "," + temp[1]);
                            }
                        }
                    }
                }
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            List<string> items = new List<string>();
            foreach(var item in listBox_DirList.Items)
            {
                items.Add(item.ToString());
            }

            Parallel.ForEach(items, (item) =>
            {
                string[] files = Directory.GetFiles(@item.ToString());
                foreach(string file in files)
                {
                    string[] temp = file.Split('.');
                    if (!RuleList.Contains(temp[temp.Length - 1]))
                    {
                        if (Directory.Exists(@item.ToString() + "\\" + temp[temp.Length - 1]))
                        {
                            string[] filename = file.Split('\\');
                            string sourdir = item.ToString() + "\\" + filename[filename.Length - 1];
                            string destdir = item.ToString() + "\\" + temp[temp.Length - 1] + "\\" + filename[filename.Length - 1];
                            if (!File.Exists(destdir))
                            {
                                File.Move(sourdir, destdir);
                            }
                        }
                        else
                        {
                            string path = item.ToString() + "\\" + temp[temp.Length - 1];
                            Directory.CreateDirectory(path);
                            string[] filename = file.Split('\\');
                            string sourdir = item.ToString() + "\\" + filename[filename.Length - 1];
                            string destdir = item.ToString() + "\\" + temp[temp.Length - 1] + "\\" + filename[filename.Length - 1];
                            if (!File.Exists(destdir))
                            {
                                File.Move(sourdir, destdir);
                            }
                        }
                    }
                    else if(RuleList[temp[temp.Length - 1]].ToString()!="")
                    {
                        if (Directory.Exists(@item.ToString() + "\\" + RuleList[temp[temp.Length-1]]))
                        {
                            string[] filename = file.Split('\\');
                            string sourdir = item.ToString() + "\\"  + filename[filename.Length - 1];
                            string destdir = item.ToString() + "\\"  + RuleList[temp[temp.Length - 1]] + "\\"+ filename[filename.Length - 1];
                            if (!File.Exists(destdir))
                            {
                                File.Move(sourdir, destdir);
                            }
                        }
                        else
                        {
                            string[] filename = file.Split('\\');
                            string path = item.ToString() + "\\" + RuleList[temp[temp.Length - 1]];
                            Directory.CreateDirectory(path);
                            string sourdir = item.ToString() + "\\"  + filename[filename.Length - 1];
                            string destdir = item.ToString() + "\\" + RuleList[temp[temp.Length - 1]] + "\\" + filename[filename.Length - 1];
                            if (!File.Exists(destdir))
                            {
                                File.Move(sourdir,destdir);
                            }
                        }
                    }
                }
            });
            this.Enabled = true;
        }

        private void button_DelRuleFile_Click(object sender, EventArgs e)
        {
            if(listBox_RuleFile.Items.Count>0 && listBox_RuleFile.SelectedIndex >= 0)
            {
                string filename = listBox_RuleFile.Items[listBox_RuleFile.SelectedIndex].ToString();
                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + filename + ".rule"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + "\\" + filename + ".rule");
                }
                LoadRuleFile();
            }
        }
    }
}
