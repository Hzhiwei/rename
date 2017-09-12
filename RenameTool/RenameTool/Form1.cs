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

namespace RenameTool
{
    public partial class rename : Form
    {
        private delegate void Delegate_OutputInfo(string Info, Color C);

        public rename()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(HelpKeyEvent);
        }

        //选择路径
        private void Path_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(FilePath != "")
            {
                fbd.SelectedPath = FilePath;
            }
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this.FilePath = fbd.SelectedPath;
                this.PathLabel.Text = FilePath;
                RefreshShowResult();
            }
        }

        //刷新ShowResult
        private bool RefreshShowResult()
        {
            DirectoryInfo dir;
            FileInfo[] allFiles;
            List<string> originFiles = new List<string>();

            filterFiles.Clear();

            try
            {
                dir = new DirectoryInfo(FilePath);
                allFiles = dir.GetFiles();   //所有文件名
                filterFiles = new List<string>(); //文件名

                this.InfoOutput.Text = "路径打开成功";
                this.InfoOutput.ForeColor = Color.Green;
            }
            catch
            {
                this.ShowResult.Clear();

                this.InfoOutput.Text = "路径打开失败";
                this.InfoOutput.ForeColor = Color.Red;

                return false;
            }

            foreach (FileInfo eachName in allFiles)
            {
                originFiles.Add(eachName.Name);
                filterFiles.Add(eachName.Name);
            }

            //筛选含有ABC的文件
            RegexFilter(this.filter.Text, ref filterFiles, ref filterFiles);
            if (this.KeyFilterA.Checked)
            {
                RegexFilter("\\w*" + this.keyAP.Text + this.keyA.Text + this.keyAA.Text + "\\w*", ref filterFiles, ref filterFiles);
            }
            if (this.KeyFilterB.Checked)
            {
                RegexFilter("\\w*" + this.keyBP.Text + this.keyB.Text + this.keyBA.Text + "\\w*", ref filterFiles, ref filterFiles);
            }
            if (this.KeyFilterC.Checked)
            {
                RegexFilter("\\w*" + this.keyCP.Text + this.keyC.Text + this.keyCA.Text + "\\w*", ref filterFiles, ref filterFiles);
            }

            List<List<string>> rules = new List<List<string>>(3);
            rules.Add(new List<string>());
            rules.Add(new List<string>());
            rules.Add(new List<string>());
            if (KeyFilterA.Checked)
            {
                rules[0].Add(keyAP.Text);
                rules[0].Add(keyA.Text);
                rules[0].Add(keyAA.Text);
            }
            else
            {
                rules[0].Add("");
                rules[0].Add("");
                rules[0].Add("");
            }
            if (KeyFilterB.Checked)
            {
                rules[1].Add(keyBP.Text);
                rules[1].Add(keyB.Text);
                rules[1].Add(keyBA.Text);
            }
            else
            {
                rules[1].Add("");
                rules[1].Add("");
                rules[1].Add("");
            }
            if (KeyFilterC.Checked)
            {
                rules[2].Add(keyBP.Text);
                rules[2].Add(keyB.Text);
                rules[2].Add(keyBA.Text);
            }
            else
            {
                rules[2].Add("");
                rules[2].Add("");
                rules[2].Add("");
            }

            string temp;
            int i, j;
            this.ShowResult.Clear();
            renameList.Clear();
            bool renameAble = true;
            int counter = (int)this.IndexStart.Value;
            foreach (string fileName in filterFiles)
            {
                temp = GetNewFileName(fileName, ref rules, this.NewNameRule.Text, counter++);
                //删除非法字符
                temp.Replace("/", "");
                temp.Replace("\\", "");
                temp.Replace(":", "");
                temp.Replace("*", "");
                temp.Replace("?", "");
                temp.Replace("\"", "");
                temp.Replace("|", "");
                temp.Replace("<", "");
                temp.Replace(">", "");
                //删除开头的空格
                while(true)
                {
                    if(temp.StartsWith(" "))
                    {
                        temp = temp.Remove(0, 1);
                    }
                    else
                    {
                        break;
                    }
                }
                //判断是否有文件重名，并以不同颜色显示
                if ((renameList.Contains(temp)) || (temp == ""))
                {
                    i = this.ShowResult.TextLength + fileName.Length;
                    j = temp.Length + "  -->  ".Length;
                    this.ShowResult.AppendText(fileName + "  -->  " + temp + "\n");
                    this.ShowResult.Select(i, j);
                    this.ShowResult.SelectionColor = Color.Red;
                    this.ShowResult.Refresh();
                    renameAble = false;
                }
                else if (originFiles.Contains(temp))
                {
                    i = this.ShowResult.TextLength + fileName.Length + "  -->  ".Length;
                    j = temp.Length;
                    this.ShowResult.AppendText(fileName + "  -->  " + temp + "\n");
                    this.ShowResult.Select(i, j);
                    this.ShowResult.SelectionColor = Color.Red;
                    this.ShowResult.Refresh();
                    renameAble = false;
                }
                else
                {
                    this.ShowResult.AppendText(fileName + "  -->  " + temp + "\n");
                    this.ShowResult.Refresh();
                }
                renameList.Add(temp);
            }

            this.Counter.Text = filterFiles.Count.ToString();

            this.RenameButton.Enabled = renameAble;

            return renameAble;
        }

        /// <summary>
        /// 正则表达式筛选,删除不符合指定正则表达式的字符串的
        /// </summary>
        /// <param name="RegexString">正则表达式字符串组</param>
        /// <param name="S">输入字符串组</param>
        /// <param name="O">输出字符串组</param>
        private void RegexFilter(
            string RegexString,
            ref List<string> S, 
            ref List<string> O
            )
        {
            List<string> _S;
            if(S == null)
            {
                return;
            }
            if(O == S)
            {
                _S = new List<string>(S);
            }
            else
            {
                _S = S;
            }
            O = new List<string>();

            Regex reg;
            Delegate_OutputInfo doi = new Delegate_OutputInfo(OutputInfo);
            try
            {
                reg = new Regex(RegexString);
                
                this.Invoke(doi, "...", Color.Green);

            }
            catch
            {
                this.Invoke(doi, "正则表达式有误", Color.Red);

                return;
            }

            foreach(string eachString in _S)
            {
                //存在匹配字符串
                if(reg.IsMatch(eachString))
                {
                    O.Add(eachString);
                }
            }
        }


        /// <summary>
        /// 提取字符串
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="ExtractString"></param>
        /// <param name="Keys"></param>
        private string ExtractKey(string Input, List<string>Keys)
        {
            string temp;
            Regex reg;
            Delegate_OutputInfo doi = new Delegate_OutputInfo(OutputInfo);
            try
            {
                reg = new Regex(Keys[0] + Keys[1] + Keys[2]);
;
                this.Invoke(doi, "...", Color.Green);
            }
            catch
            {
                this.Invoke(doi, "正则表达式有误", Color.Red);
                return "";
            }
            temp = reg.Match(Input).Value;
            reg = new Regex(Keys[0]);
            temp = temp.Remove(0, reg.Match(temp).Value.Length);
            reg = new Regex(Keys[1]);
            return reg.Match(temp).Value;
        }


        /// <summary>
        /// 按指定要求重命名文件
        /// </summary>
        /// <param name="Input">原文件名</param>
        /// <param name="Name">新文件名</param>
        /// <param name="KeySerial">关键正则表达式</param>
        /// <param name="New">新名称规则</param>
        private string GetNewFileName(string Input, ref List<List<string>> KeySerial, string New, int n)
        {
            string Name;
            Name = "";
            for(int index = 0; index < New.Length; index++)
            {
                if(New[index] != '\\')
                {
                    Name = Name + New[index];
                }
                else
                {
                    index++;
                    if(index >= New.Length)
                    {
                        return "";   //语法错误(\后无字符)
                    }
                    switch(New[index])
                    {
                        case 'A':
                        case 'a':
                            {
                                Name = Name + ExtractKey(Input, KeySerial[0]);
                                break;
                            }
                        case 'B':
                        case 'b':
                            {
                                Name = Name + ExtractKey(Input, KeySerial[1]);
                                break;
                            }
                        case 'C':
                        case 'c':
                            {
                                Name = Name + ExtractKey(Input, KeySerial[2]);
                                break;
                            }
                        case 'N':
                        case 'n':
                            {
                                if(this.CountMode.Checked)
                                {
                                    Name = Name + n.ToString();
                                }
                                break;
                            }
                    }
                }
            }
            return Name;
        }


        //路径
        string FilePath;

        List<string> filterFiles = new List<string>();

        List<string> renameList = new List<string>();


        private void KeyFilterA_CheckedChanged(object sender, EventArgs e)
        {
            this.keyAP.Enabled = KeyFilterA.Checked;
            this.keyA.Enabled = KeyFilterA.Checked;
            this.keyAA.Enabled = KeyFilterA.Checked;
        }

        private void KeyFilterB_CheckedChanged(object sender, EventArgs e)
        {
            this.keyBP.Enabled = KeyFilterB.Checked;
            this.keyB.Enabled = KeyFilterB.Checked;
            this.keyBA.Enabled = KeyFilterB.Checked;
        }

        private void KeyFilterC_CheckedChanged(object sender, EventArgs e)
        {
            this.keyCP.Enabled = KeyFilterC.Checked;
            this.keyC.Enabled = KeyFilterC.Checked;
            this.keyCA.Enabled = KeyFilterC.Checked;
        }

        private void RefreshResultTextBox(object sender, EventArgs e)
        {
            RefreshShowResult();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshShowResult();
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            FileInfo files;
            if (RefreshShowResult())
            {
                Delegate_OutputInfo doi = new Delegate_OutputInfo(OutputInfo);
                FileStream logFile;
                StreamWriter logFileWriter;

                if(File.Exists(FilePath + "\\RenameLog.txt"))
                {
                    logFile = new FileStream(FilePath + "\\RenameLog.txt", FileMode.Open, FileAccess.Write);
                }
                else
                {
                    logFile = new FileStream(FilePath + "\\RenameLog.txt", FileMode.Create, FileAccess.Write);
                }
                logFileWriter = new StreamWriter(logFile);
                logFile.Seek(0, SeekOrigin.End);
                logFileWriter.Write("\n----------------------------------------------\n");

                try
                {
                    for(int index = 0; index < filterFiles.Count; index++)
                    {
                        files = new FileInfo(FilePath + "\\" + filterFiles[index]);
                        files.MoveTo(FilePath + "\\" + renameList[index]);
                        logFileWriter.Write(DateTime.Now.ToString() + "    " + filterFiles[index] + " --> " + renameList[index] + "\n");
                    }
                    RefreshShowResult();
                    
                    this.Invoke(doi, "批量重命名成功", Color.Green);
                    logFileWriter.Write(DateTime.Now.ToString() + "    rename succeed\n\n");
                }
                catch
                {
                    RefreshShowResult();
                    this.Invoke(doi, "批量重命名未完全成功", Color.Red);
                    logFileWriter.Write(DateTime.Now.ToString() + "    rename abort\n\n");
                }

                logFileWriter.Close();
                logFile.Close();
            }
        }

        private void CountMode_CheckedChanged(object sender, EventArgs e)
        {
            this.IndexStart.Enabled = this.CountMode.Checked;
            RefreshShowResult();
        }
        
        private void HelpKeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                HelpForm helpF = new HelpForm();
                helpF.ShowDialog();
            }
        }

        private void OutputInfo(string Info, Color C)
        {
            this.InfoOutput.Text = Info;
            this.InfoOutput.ForeColor = C;
            this.InfoOutput.Refresh();
        }
    }
}
