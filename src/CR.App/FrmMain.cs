using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CR.App
{
    public partial class FrmMain : Form
    {

        private List<string> _dataSource = new();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitEvent();
            InitControl();
            InitControlProperty();
            AddLog("程序初始化完成");
        }

        public void InitEvent()
        {
            btnChoose.Click += BtnChoose_Click;
            btnUpload.Click += BtnUpload_Click;
            btnCompare.Click += BtnCompare_Click;
            btnGenerate.Click += BtnGenerate_Click;
            btnClearLog.Click += BtnClearLog_Click;
        }

        /// <summary>
        /// 清空行为日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnClearLog_Click(object? sender, EventArgs e)
        {
            this.txtLog.Clear();
        }

        public void InitControl()
        {
            this.txtFilePath.PlaceholderText = "请选择数据源文件(.txt)";
            this.txtRepetitionContext.PlaceholderText = "无重复数据";
            this.txtLog.PlaceholderText = "操作日志 ...";
        }

        public void InitControlProperty()
        {
            this.txtLog.ReadOnly = true;
        }

        /// <summary>
        ///  选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnChoose_Click(object? sender, EventArgs e)
        {
            AddLog("正在选择数据源文件");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择数据源文件";
            ofd.Filter = "文本文件|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = ofd.FileName;
                AddLog("完成选择数据源文件");
            }
            else
            {
                AddLog("取消选择数据源文件");
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private async void BtnUpload_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePath.Text.Trim()))
            {
                MessageBox.Show("请选择数据源文件!!!", "提示信息");
                return;
            }

            string fileName = GetFileName(this.txtFilePath.Text.Trim());
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("请选择正确的数据源文件路径!!!", "提示信息");
                return;
            }

            AddLog($"正在上传文件【{fileName}】");
            _dataSource.Clear(); // 清空所有数据源
            string context = await File.ReadAllTextAsync(this.txtFilePath.Text.Trim());
            _dataSource.AddRange(context.Split("\r\n", StringSplitOptions.RemoveEmptyEntries));
            AddLog("文件上传完成");
        }

        /// <summary>
        /// 比较数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnCompare_Click(object? sender, EventArgs e)
        {
            if (!_dataSource.Any())
            {
                MessageBox.Show("请上传数据!!!", "提示信息");
                return;
            }
            txtRepetitionContext.Clear(); // 比较前清除所有内容
            AddLog($"正在比较数【{GetFileName(this.txtFilePath.Text.Trim())}】的据源");
            //比较逻辑
            CompareDataSource();


            AddLog("数据源比较完毕");
        }

        /// <summary>
        /// 生成默认模板数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private async void BtnGenerate_Click(object? sender, EventArgs e)
        {
            AddLog("正在下载模板数据");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("agjslgkngsg");
            sb.AppendLine("128jfgaskl5");
            sb.AppendLine("12519025jad");
            sb.AppendLine("sdjkgsadg92");
            sb.AppendLine("15298jkdfa9");
            sb.AppendLine("128jfgaskl5");


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的路径";
            sfd.FileName = "样例数据模板.txt";
            sfd.Filter = "文本文件|*.txt";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                await File.WriteAllTextAsync(filePath, sb.ToString());
            }

            AddLog("模板数据下载完成");
        }


        public void AddLog(string log)
        {
            this.txtLog.Invoke(() =>
            {
                this.txtLog.AppendText($"{log} ...");
                this.txtLog.AppendText("\r\n");
            });
        }

        public void CompareDataSource()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            _dataSource.ForEach(x =>
            {

                if (dict.ContainsKey(x))
                {
                    this.txtRepetitionContext.AppendText($"数据【{x}】重复了 \r\n");
                    dict[x]++;
                }
                else
                {
                    dict.Add(x, 1);
                }
            });

            this.txtRepetitionContext.AppendText($"总计: \r\n");

            var sumUpData = dict.Where(x => x.Value > 1);
            if (sumUpData.Any())
            {
                foreach (var x in sumUpData)
                {
                    this.txtRepetitionContext.AppendText($"数据【{x.Key}】重复了【{x.Value - 1}】次 \r\n");
                }
            }
            else
            {
                this.txtRepetitionContext.AppendText($"数据源无重复数据");
            }
        }


        public string GetFileName(string filePath)
        {
            bool isFilePath = Path.HasExtension(filePath) && !Path.GetInvalidPathChars().Intersect(filePath).Any();
            if (!isFilePath) return string.Empty;
            return Path.GetFileName(filePath);
        }
    }
}
