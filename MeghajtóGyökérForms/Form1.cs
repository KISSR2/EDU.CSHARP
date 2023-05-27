using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

// Kiss Róbert - Neptun: J74B48

namespace MeghajtóGyökérForms
{
    public partial class Form1 : Form
    {
        private DriveInfo[] cboDrive = DriveInfo.GetDrives();
        public static string cboDriveC;
        public static string cboDriveList;
        public static string cboPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDriveFel();
        }

        private void Clear()
        {
            listBox.Items.Clear();
        }

        private void cboDriveFel()
        {
            foreach (DriveInfo di in cboDrive)
            {
                comboBox1.Items.Add(di.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPath = comboBox1.SelectedItem.ToString();
            DriveInfo ready = new DriveInfo(comboBox1.SelectedItem.ToString());
            if (ready.IsReady)
            {
                cboDriveC = comboBox1.SelectedItem.ToString();
                Clear();

                foreach (string dir in Directory.GetDirectories(cboDriveC))
                {
                    cboPath = cboDriveC;
                    listBox.Items.Add(DirectoryName(dir));
                }

                foreach (string file in Directory.GetFiles(cboDriveC))
                {
                    listBox.Items.Add(Path.GetFileName(file));
                }
            }
            else
            {
                Clear();
                MessageBox.Show("A meghajtó nem áll készen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboDriveList = listBox.SelectedItem.ToString();
                if (cboDriveList.StartsWith("["))
                {
                    Clear();
                    string path = directoryPath(cboDriveList);
                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        listBox.Items.Add(DirectoryName(dir));
                    }
                    foreach (string file in Directory.GetFiles(path))
                    {
                        listBox.Items.Add(Path.GetFileName(file));
                    }
                }
                else if (cboDriveList.EndsWith(".txt"))
                {
                    szoveg.Text = "";
                    using (FileStream txt = File.OpenRead(filePath(cboDriveList)))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);
                        while (txt.Read(b, 0, b.Length) > 0)
                        {
                            szoveg.AppendText(temp.GetString(b));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba történt a listából való kiválasztás során!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string directoryPath(string s)
        {
            if (cboPath.LastIndexOf(@"\") == cboPath.Length - 1)
            {
                s = s.Remove(s.IndexOf("["), 1);
                s = s.Remove(s.LastIndexOf("]"));
                cboPath = cboPath + s;
            }
            else
            {
                s = s.Remove(s.IndexOf("["), 1);
                s = s.Remove(s.LastIndexOf("]"));
                cboPath = cboPath + @"\" + s;
            }
            return cboPath;
        }

        public static string filePath(string s)
        {
            string n = cboPath + @"\" + s;
            return n;
        }

        public static string DirectoryName(string s)
        {
            string dirName;
            int talal = s.LastIndexOf(@"\");
            dirName = s.Substring(talal + 1);
            dirName = "[" + dirName + "]";
            return dirName;
        }
    }
}