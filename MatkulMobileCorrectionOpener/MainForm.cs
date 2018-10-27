using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MatkulMobileCorrectionOpener
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (IsDirectory(file))
                {
                    txtRoot.Text = "Root : " + file;

                    Search(".xml", file);
                    Search(".java", file);
                }
                else
                {
                    MessageBox.Show("You Should Drop A Directory!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsDirectory(string file)
        {
            return FileAttributes.Directory == (File.GetAttributes(file) & FileAttributes.Directory);
        }

        private void Search(string fileExtensionToFind, string path)
        {
            StringBuilder patternBuilder = new StringBuilder();
            for (int i = 0; i < skipList.Items.Count; i++)
            {
                patternBuilder.Append(skipList.Items[i]);
                if (i < skipList.Items.Count - 1)
                    patternBuilder.Append("|");
            }

            List<string> files = new List<string>();
            files.AddRange(Directory.GetFiles(path, "*" + fileExtensionToFind, SearchOption.AllDirectories)
                .Where(x => Regex.IsMatch(x, patternBuilder.ToString()) == false)
                .Select(x => x).ToList());

            foreach (string file in files)
            {
                if (Path.GetExtension(file) == fileExtensionToFind)
                {
                    string filename = Path.GetFileName(file);
                    mainTab.TabPages.Add(filename);

                    RichTextBox fileContent = new RichTextBox()
                    {
                        Dock = DockStyle.Fill
                    };
                    fileContent.Text = File.ReadAllText(file);
                    int lastTabIndex = mainTab.TabPages.Count - 1;
                    mainTab.TabPages[lastTabIndex].Controls.Add(fileContent);
                }
            }
        }

        private void btnAddFileToSkip_Click(object sender, System.EventArgs e)
        {
            skipList.Items.Add(txtSkipName.Text);
        }
    }
}
