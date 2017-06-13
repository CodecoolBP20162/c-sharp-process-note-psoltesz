namespace ProcessNote
{
    partial class ProcessNotePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessListPanel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsPanel = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseSidePanelButton = new System.Windows.Forms.Button();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddCommentButton = new System.Windows.Forms.Button();
            this.CommentContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.ProcessListPanel.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ProcessListPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ProcessListPanel.Location = new System.Drawing.Point(12, 12);
            this.ProcessListPanel.Name = "listView1";
            this.ProcessListPanel.Size = new System.Drawing.Size(597, 453);
            this.ProcessListPanel.TabIndex = 4;
            this.ProcessListPanel.UseCompatibleStateImageBehavior = false;
            this.ProcessListPanel.View = System.Windows.Forms.View.Details;
            this.ProcessListPanel.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.ProcessListPanel.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process name";
            this.columnHeader1.Width = 416;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(492, 482);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.DetailsPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.DetailsPanel.FullRowSelect = true;
            this.DetailsPanel.Location = new System.Drawing.Point(639, 12);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(319, 137);
            this.DetailsPanel.TabIndex = 8;
            this.DetailsPanel.UseCompatibleStateImageBehavior = false;
            this.DetailsPanel.View = System.Windows.Forms.View.Details;
            this.DetailsPanel.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 135;
            // 
            // CloseSidePanelButton
            // 
            this.CloseSidePanelButton.Location = new System.Drawing.Point(740, 155);
            this.CloseSidePanelButton.Name = "CloseSidePanelButton";
            this.CloseSidePanelButton.Size = new System.Drawing.Size(113, 28);
            this.CloseSidePanelButton.TabIndex = 9;
            this.CloseSidePanelButton.Text = "Close panel";
            this.CloseSidePanelButton.UseVisualStyleBackColor = true;
            this.CloseSidePanelButton.Visible = false;
            this.CloseSidePanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseSidePanelButton_MouseClick);
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(636, 213);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(78, 17);
            this.CommentsLabel.TabIndex = 10;
            this.CommentsLabel.Text = "Comments:";
            this.CommentsLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(639, 269);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 89);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(763, 364);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 40);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveButton_MouseClick);
            // 
            // AddCommentButton
            // 
            this.AddCommentButton.Location = new System.Drawing.Point(740, 269);
            this.AddCommentButton.Name = "AddCommentButton";
            this.AddCommentButton.Size = new System.Drawing.Size(113, 37);
            this.AddCommentButton.TabIndex = 13;
            this.AddCommentButton.Text = "Add comment";
            this.AddCommentButton.UseVisualStyleBackColor = true;
            this.AddCommentButton.Visible = false;
            this.AddCommentButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddCommentButton_MouseClick_1);
            // 
            // CommentContentLabel
            // 
            this.CommentContentLabel.AutoSize = true;
            this.CommentContentLabel.Location = new System.Drawing.Point(749, 213);
            this.CommentContentLabel.Name = "CommentContentLabel";
            this.CommentContentLabel.Size = new System.Drawing.Size(0, 17);
            this.CommentContentLabel.TabIndex = 14;
            // 
            // ProcessNotePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 523);
            this.Controls.Add(this.CommentContentLabel);
            this.Controls.Add(this.AddCommentButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.CloseSidePanelButton);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ProcessListPanel);
            this.Name = "ProcessNotePanel";
            this.Text = "ProcessNote";
            this.Load += new System.EventHandler(this.ProcessNotePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ProcessListPanel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DetailsPanel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button CloseSidePanelButton;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddCommentButton;
        private System.Windows.Forms.Label CommentContentLabel;
    }
}

