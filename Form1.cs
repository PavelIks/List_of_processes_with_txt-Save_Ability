using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startClick(object sender, EventArgs e)
        {
            foreach (var item in Process.GetProcesses())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = $"ID: { item.Id} Name: {item.ProcessName} Thread num: {item.Threads} Handle num: {item.HandleCount}";
                processLV.Items.Add(lvi);
            }
        }

        private void killProcessClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = saveFileDialog.FileName;

            foreach (var item in processLV.Items)
            {
                System.IO.File.AppendAllText(filename,item.ToString());
                System.IO.File.AppendAllText(filename, "\n");
            }
            MessageBox.Show("Файл сохранен");
        }

        private void exitClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}