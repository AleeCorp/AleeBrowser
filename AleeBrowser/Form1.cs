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
            MessageBox.Show("Please note that this software is still working progress so don't expect things to work.");

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
            Form2 f2 = new Form2();
            f2.ShowDialog();
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
            browser.Load(textBox1.Text);

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        private void browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
           
            
            }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
