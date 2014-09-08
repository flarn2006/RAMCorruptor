using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RAMCorruptor
{
    public partial class SelectProcessForm : Form
    {
        private class ProcessListViewItem : ListViewItem
        {
            private Process process;

            public ProcessListViewItem(Process process)
            {
                this.process = process;
                Text = process.Id.ToString();
                SubItems.Add(process.ProcessName);
                SubItems.Add(process.MainWindowTitle);
            }

            public Process Process
            {
                get { return process; }
            }
        }

        private class ColumnSorter : Comparer<ListViewItem>
        {
            private int col;
            private bool descending;

            public ColumnSorter(int initialColumn, bool descending = false)
            {
                this.col = initialColumn;
                this.descending = descending;
            }

            public ColumnSorter() : this(0) { }

            public override int Compare(ListViewItem x, ListViewItem y)
            {
                int result;

                if (col == 0) {
                    // First column is the PID, which is numeric
                    int a = 0, b = 0;
                    Int32.TryParse(x.Text, out a);
                    Int32.TryParse(y.Text, out b);
                    result = a - b;
                } else {
                    result = x.SubItems[col].Text.CompareTo(y.SubItems[col].Text);
                }

                return descending ? -result : result;
            }

            public void ColumnClicked(int column)
            {
                if (col == column) {
                    descending = !descending;
                } else {
                    col = column;
                    descending = false;
                }
            }
        }

        public SelectProcessForm()
        {
            InitializeComponent();
        }

        private void SelectProcessForm_Load(object sender, EventArgs e)
        {
            processList.ListViewItemSorter = new ColumnSorter(1);
            foreach (Process p in Process.GetProcesses()) {
                processList.Items.Add(new ProcessListViewItem(p));
            }
        }

        public static Process SelectProcess()
        {
            SelectProcessForm form = new SelectProcessForm();
            if (form.ShowDialog() == DialogResult.OK && form.processList.SelectedItems.Count > 0) {
                return ((ProcessListViewItem)form.processList.SelectedItems[0]).Process;
            } else {
                return null;
            }
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (processList.SelectedItems.Count > 0);
        }

        private void processList_ItemActivate(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void processList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ((ColumnSorter)processList.ListViewItemSorter).ColumnClicked(e.Column);
            processList.Sort();
        }
    }
}
