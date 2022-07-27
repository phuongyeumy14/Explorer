using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;          
            }
        }
    }
}
