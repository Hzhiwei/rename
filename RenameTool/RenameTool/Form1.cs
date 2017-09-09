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
        public rename()
        {
            InitializeComponent();
        }

        //选择路径
        private void Path_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this.FilePath = fbd.SelectedPath;
                this.PathLabel.Text = FilePath;
                RefreshShowResult();
            }
        }

        //刷新ShowResult
        private void RefreshShowResult()
        {
            this.ShowResult.Clear();

            DirectoryInfo dir = new DirectoryInfo(FilePath);
            FileInfo[] allFiles = dir.GetFiles();   //所有文件名
            List<string> filterFiles = new List<string>(); //筛选后的文件名
            List<string> filterAFiles = new List<string>(); //A筛选后的文件名
            List<string> filterBFiles = new List<string>(); //B筛选后的文件名
            List<string> filterCFiles = new List<string>(); //C筛选后的文件名

            //初步筛选
            Regex filterRegex = new Regex(this.filter.Text);    //筛选正则表达式
            string fileName;
            foreach(FileInfo eachName in allFiles)
            {
                fileName = filterRegex.Match(eachName.Name).Value;
                if (fileName != "")
                {
                    filterFiles.Add(eachName.Name);
                    this.ShowResult.AppendText(eachName.Name + '\n');
                }
            }

            //根据ABC正则表达式筛选

        }

        /// <summary>
        /// 正则表达式筛选（用于最后
        /// </summary>
        /// <param name="S">输入字符串组</param>
        /// <param name="Reg">正则表达式</param>
        /// <param name="Befor">匹配字符串前面的字符串</param>
        /// <param name="Match">匹配的字符串</param>
        /// <param name="After">匹配字符串后面的字符串</param>
        private void RegexFilter(
            string RegexString,
            ref List<string> S, 
            out List<string> Befor,
            out List<string> Match,
            out List<string> After
            )
        {
            //输入数据初始化
            Befor = new List<string>();
            Match = new List<string>();
            After = new List<string>();

            Match matchString;
            Regex reg = new Regex(RegexString);
            foreach(string eachString in S)
            {
                matchString = reg.Match(eachString);
                //存在匹配字符串
                if(matchString.Value != "")
                {
                    Befor.Add(eachString.Substring(0, matchString.Index));
                    Match.Add(matchString.Value);
                    Match.Add(eachString.Substring(matchString.Index + matchString.Value.Length, eachString.Length - 1));
                }
            }
        }




        //路径
        string FilePath;
    }
}
