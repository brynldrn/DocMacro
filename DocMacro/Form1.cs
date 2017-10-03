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
using Ionic.Zip;

namespace DocMacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click Listener for the Document Upload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "Microsoft Word Files | *.doc; *.docx";
            if(ofd1.ShowDialog() == DialogResult.OK)
            {
                fileLabel.Text = ofd1.FileName;
            }
        }

        /// <summary>
        /// Converts the accepted doc file to zip
        /// </summary>
        /// <param name="fileName"></param>
        private void convertToZip(String fileName)
        {
            File.Move(fileName, Path.ChangeExtension(fileName, ".zip"));
            string file = ofd1.FileName;
            string path = file.Replace(ofd1.SafeFileName, "");
            readZip(Path.ChangeExtension(fileName, ".zip"), path + "extracted");
        }


        /// <summary>
        /// Convert button listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            convertToZip(ofd1.FileName);
        }

        private void readZip(string zipToUnpack, string unpackDirectory)
        {
            using (ZipFile zip1 = ZipFile.Read(zipToUnpack))
            {
                // here, we extract every entry, but we could extract conditionally
                // based on entry name, size, date, checkbox status, etc.  
                foreach (ZipEntry e in zip1)
                {
                    if (e.ToString().Contains("word/document.xml"))
                    {
                        e.Extract(unpackDirectory, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }
        }
    }
}
