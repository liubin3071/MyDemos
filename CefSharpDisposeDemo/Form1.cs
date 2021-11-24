using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
namespace CefSharpDisposeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private object _lock = new object();
        private void CreateBtn_Click(object sender, EventArgs e)
        {

            lock (_lock)
            {
                DisposeBrowserPanels();
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        var panel = new Panel();
                        panel.Dock = DockStyle.Fill;
                        var browser = new CefSharp.WinForms.ChromiumWebBrowser("http://baidu.com");
                        browser.Dock = DockStyle.Fill;
                        browser.Parent = panel;
                        tableLayoutPanel1.Controls.Add(panel, col, row);
                    }
                }
            }
        }

        private void DisposeBrowsers()
        {
            var panels = new List<Panel>();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                panels.Add((Panel)item);
            }
            tableLayoutPanel1.Controls.Clear();
            foreach (var item in panels)
            {
                var browser = item.Controls[0];
                item.Controls.Clear();
                browser.Dispose();
                item.Dispose();
            }
        }
        private void DisposeBrowserPanels()
        {
            var panels = new List<Panel>();
            
            foreach (var item in tableLayoutPanel1.Controls)
            {
                panels.Add((Panel)item);
            }
            tableLayoutPanel1.Controls.Clear();
            foreach (var item in panels)
            {
                item.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var currentPid = Process.GetCurrentProcess();
            SubProcessNumLabel.Text = "sub process num:" + Process.GetProcessesByName("CefSharp.BrowserSubprocess").Count().ToString();
        }

        private void DsposeBtn_Click(object sender, EventArgs e)
        {
            DisposeBrowsers();
        }

        private void DisposeParentBtn_Click(object sender, EventArgs e)
        {
            DisposeBrowserPanels();
        }
    }      
}