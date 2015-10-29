using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileManager
{
    public partial class MainForm : Form
    {
        private FileUtilites _fileUtils;
        protected FileUtilites Utils
        {
            get
            {
                if (_fileUtils == null)
                    _fileUtils = new FileUtilites();
                return _fileUtils;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine(Thread.CurrentThread.Name);
        }

        private void chooseSavePathButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                savePathTextBox.Text = saveFile.FileName;
                
            }
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                directoryNameTextBox.Text = fb.SelectedPath;
                DirectoryInfo dInfo = new DirectoryInfo(fb.SelectedPath);
                StartSearchInThread(dInfo);

                Console.WriteLine(Utils.XElem.LastNode);
                Console.WriteLine("Hi from Main {0}", Thread.CurrentThread.Name);
                

            }
        }
        private void writeButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo tempSavePath = new DirectoryInfo(savePathTextBox.Text.ToString());
            fileTreeView.Nodes.Add(Utils.NodeOfTree);
            StartWriteToXml(tempSavePath);
        }

        private void StartSearchInThread(DirectoryInfo dInfo)
        {
            Utils.XElemList = new List<XElement>();
            Thread thread = new Thread(DirSearch);
            thread.Name = "fileSearchThread";
            thread.IsBackground = true;
            thread.Start(dInfo);
            thread.Join();
            
            thread.Abort();
            MessageBox.Show("Поток завершает свою работу");

        }
        private void StartWriteToXml(DirectoryInfo dInfo)
        {
            Thread thread = new Thread(WriteToXml);
            thread.Name = "xmlWriterThread";
            thread.IsBackground = true;
            thread.Start(dInfo.FullName);
            
        }
        private void WriteToXml(object xmlPath)
        {
            MessageBox.Show(Thread.CurrentThread.Name);
            XDocument doc = new XDocument();
            doc.Add(Utils.XElem);
            Console.WriteLine(doc);
            doc.Save((string)xmlPath);
        }

        private void ShowTree()
        {
            var temp = Utils.NodeOfTree;
            fileTreeView.Nodes.Add(temp);
        }

        private void DirSearch(object Dir)
        {
            DirectoryInfo dirInfo = (DirectoryInfo)Dir;
            var info = new XElement("dir", new XAttribute("name", dirInfo.Name), new XAttribute("CreationTime", dirInfo.CreationTime));
            Utils.XElemList.Add(info);
            var directoryNode = new TreeNode(dirInfo.Name);
            foreach (var s in dirInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(s.Name));
                info.Add(new XElement("file", new XAttribute("name", s.Name), new XAttribute("size", s.Length), new XAttribute("CreationTime", s.CreationTime)));
                
            }

            foreach (var item in dirInfo.GetDirectories())
            {

                DirSearch(item);
                directoryNode.Nodes.Add(Utils.NodeOfTree);
                info.Add(Utils.XElem);
                

            }

            Utils.NodeOfTree = directoryNode;
            
            Utils.XElem = info;
            
                
            

        }

        
    }
}
