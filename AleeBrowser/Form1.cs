using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;

namespace AleeBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void Form1_Load(object sender, EventArgs e)
        {

            browser = new CefSharp.WinForms.ChromiumWebBrowser("http://alee14.ga");
            {
                Dock = DockStyle.Fill;
                Size = new Size(934, 459);
                Location = new Point(18, 47);

            };
            this.panel1.Controls.Add(browser);
                  // webBrowser1.Navigate("http://alee14.ga");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser is created by: AleeCorp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }
        private void NavigateToPage()
        {
            button3.Enabled = false;
            textBox1.Enabled = false;
            toolStripProgressBar1.Text = "Navigation has started";
            browser.Load(textBox1.Text);

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        private void browser_DocumentCompleted(object sender, ChromiumWebBrowser.DocumentCompletedEventArgs e)
        {
            button3.Enabled = true;
            textBox1.Enabled = true;
            toolStripProgressBar1.Text = "Navigation Complete";
        }

        private void browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            
            }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  foreach( HtmlElement image in browser.Document.Images)
          //  {
          //      image.SetAttribute("src", "https://yt3.ggpht.com/-Iuf1v4-SSSM/AAAAAAAAAAI/AAAAAAAAAAA/89IYeQw--wU/s900-c-k-no-mo-rj-c0xffffff/photo.jpg");
         //   }
        }
    }
        }
// This project was made in May 8th 2017
// And here's the "before convert" file of AleeBrowser https://www.dropbox.com/s/16q7ay6otd4njw4/AleeBrowser.exe?dl=0
