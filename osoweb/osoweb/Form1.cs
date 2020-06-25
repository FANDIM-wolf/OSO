using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osoweb
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //add tab

            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true; // we see all mistakes
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("New page");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);// web controls browser
            i += 1;


        }
        // to add new tab , do not remove this function
        void web_DocumentCompleted(object sender,WebBrowserDocumentCompletedEventArgs e)
        {
            // throw new NotImplementedException();
            //name  of page
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //function go
            if (toolStripTextBox1.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
            else
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {  
            //function back
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //function forward
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //function refresh page
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {   //remove page
            if(tabControl1.TabPages.Count>1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i--;
            }
            else
            {
                Application.Exit();

            }
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
        }

       
    }
}
