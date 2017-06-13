using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class ProcessNotePanel : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private Timer timer;
        private PerformanceCounter totalCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter totalMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        private PerformanceCounter currentCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private Process currentProcess = Process.GetCurrentProcess();
        private double memUsage;
        // initializing comment class
        List<Comment> comments = new List<Comment>();

        public ProcessNotePanel()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            ProcessListPanel.ListViewItemSorter = lvwColumnSorter;
            // double buffering
            DoubleBuffered = true;
            //hiding header
            DetailsPanel.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void ProcessNotePanel_Load(object sender, EventArgs e)
        {
            ProcessListPanel.View = View.Details;
            // listing processes
            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                ProcessListPanel.Items.Add(item);
            }
            ProcessListPanel.AllowColumnReorder = true;
            ProcessListPanel.FullRowSelect = true;
            Controls.Add(ProcessListPanel);
            // initializing side panel
            ListViewItem cpuUsage = new ListViewItem("CPU usage: ");
            ListViewItem memUsage = new ListViewItem("Memory usage: ");
            ListViewItem startTime = new ListViewItem("Starting time: ");
            ListViewItem runningTime = new ListViewItem("Running time: ");
            ListViewItem threadNumber = new ListViewItem("Threads: ");
            cpuUsage.SubItems.Add("");
            DetailsPanel.Items.Add(cpuUsage);
            memUsage.SubItems.Add("");
            DetailsPanel.Items.Add(memUsage);
            startTime.SubItems.Add("");
            DetailsPanel.Items.Add(startTime);
            runningTime.SubItems.Add("");
            DetailsPanel.Items.Add(runningTime);
            threadNumber.SubItems.Add("");
            DetailsPanel.Items.Add(threadNumber);
            // Loop through and size each column header to fit the column header text.
            foreach (ColumnHeader ch in ProcessListPanel.Columns)
            {
                ch.Width = -2;
            }

            // setting up the timer to update stuff
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Total CPU usage: " + totalCPUCounter.NextValue().ToString() + "% -- RAM: " + totalMemCounter.NextValue().ToString() + " MB free from 6144 MB";
            CommentContentLabel.Text = GetCommentContent(currentProcess.Id);
            //current process cpu usage
            DetailsPanel.Items[0].SubItems[1].Text = string.Format(("{0:F1} %"), currentCPUCounter.NextValue());
            // current process memory usage
            memUsage = (currentProcess.WorkingSet64 / 1024f) / 1024f;
            DetailsPanel.Items[1].SubItems[1].Text = string.Format(("{0:F1} MB"), memUsage);
            DetailsPanel.Items[3].SubItems[1].Text = (DateTime.Now - currentProcess.StartTime).ToString("h'h 'm'm 's's'");
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                } else {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // Perform the sort with these new sort options.
            ProcessListPanel.Sort();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMost)
            {
                TopMost = false;
            } else {
                TopMost = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            DetailsPanel.Visible = true;
            CloseSidePanelButton.Visible = true;
            AddCommentButton.Visible = true;
            SaveButton.Visible = false;
            textBox1.Visible = false;
            // comment labels
            CommentsLabel.Visible = true;
            CommentContentLabel.Text = GetCommentContent(currentProcess.Id);
            CommentContentLabel.Visible = true;
            // listing process details
            int processId;
            bool selected = Int32.TryParse(ProcessListPanel.SelectedItems[0].SubItems[1].Text, out processId);
            currentProcess = Process.GetProcessById(processId);
            // current process cpu usage
            currentCPUCounter = new PerformanceCounter("Process", "% Processor Time", currentProcess.ProcessName);
            DetailsPanel.Items[2].SubItems[1].Text = currentProcess.StartTime.ToString();
            DetailsPanel.Items[3].SubItems[1].Text = (DateTime.Now - currentProcess.StartTime).ToString("h'h 'm'm 's's'");
            DetailsPanel.Items[4].SubItems[1].Text = currentProcess.Threads.Count.ToString();
        }

        private void CloseSidePanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            DetailsPanel.Visible = false;
            AddCommentButton.Visible = false;
            CloseSidePanelButton.Visible = false;
            CommentContentLabel.Visible = false;
            CommentsLabel.Visible = false;
        }

        private void CloseCommentButton_MouseClick(object sender, MouseEventArgs e)
        {
            SaveButton.Visible = false;
            CommentsLabel.Visible = false;
            textBox1.Visible = false;
            AddCommentButton.Visible = true;
        }

        private void AddCommentButton_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            SaveButton.Visible = true;
            CommentsLabel.Visible = true;
            textBox1.Visible = true;
            AddCommentButton.Visible = false;
            CloseSidePanelButton.Visible = true;
        }

        private void SaveButton_MouseClick(object sender, MouseEventArgs e)
        {
            Comment comment = new Comment(currentProcess.Id, textBox1.Text);
            comments.Add(comment);
            CommentContentLabel.Text = textBox1.Text;
            CommentContentLabel.Visible = true;
            MessageBox.Show("Comment saved successfully.");
            textBox1.Visible = false;
            SaveButton.Visible = false;
        }

        private string GetCommentContent(int ID)
        {
            foreach (Comment comment in comments)
            {
                if (comment.getID() == ID)
                {
                    return comment.getContent();
                }
            }
            return "";
        }
    }
}
