namespace TextEditor
{
    partial class Text_Editor
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
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSurnameWithInitialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countWordOccurrencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsCountTextBox = new System.Windows.Forms.TextBox();
            this.loadNewsButton = new System.Windows.Forms.Button();
            this.newsListBox = new System.Windows.Forms.ListBox();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRichTextBox.Location = new System.Drawing.Point(16, 33);
            this.inputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(382, 404);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputRichTextBox.Location = new System.Drawing.Point(406, 33);
            this.outputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(382, 404);
            this.outputRichTextBox.TabIndex = 1;
            this.outputRichTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewStaToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSpacesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeSpacesToolStripMenuItem
            // 
            this.removeSpacesToolStripMenuItem.Name = "removeSpacesToolStripMenuItem";
            this.removeSpacesToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.removeSpacesToolStripMenuItem.Text = "Remove Spaces";
            this.removeSpacesToolStripMenuItem.Click += new System.EventHandler(this.removeSpacesToolStripMenuItem_Click);
            // 
            // viewStaToolStripMenuItem
            // 
            this.viewStaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem});
            this.viewStaToolStripMenuItem.Name = "viewStaToolStripMenuItem";
            this.viewStaToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewStaToolStripMenuItem.Text = "View";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findSurnameWithInitialsToolStripMenuItem,
            this.countWordOccurrencesToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // findSurnameWithInitialsToolStripMenuItem
            // 
            this.findSurnameWithInitialsToolStripMenuItem.Name = "findSurnameWithInitialsToolStripMenuItem";
            this.findSurnameWithInitialsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.findSurnameWithInitialsToolStripMenuItem.Text = "Find Surname with Initials";
            this.findSurnameWithInitialsToolStripMenuItem.Click += new System.EventHandler(this.findSurnameWithInitialsToolStripMenuItem_Click);
            // 
            // countWordOccurrencesToolStripMenuItem
            // 
            this.countWordOccurrencesToolStripMenuItem.Name = "countWordOccurrencesToolStripMenuItem";
            this.countWordOccurrencesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.countWordOccurrencesToolStripMenuItem.Text = "Count Word Occurrences";
            this.countWordOccurrencesToolStripMenuItem.Click += new System.EventHandler(this.countWordOccurrencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // newsCountTextBox
            // 
            this.newsCountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsCountTextBox.Location = new System.Drawing.Point(795, 33);
            this.newsCountTextBox.Multiline = true;
            this.newsCountTextBox.Name = "newsCountTextBox";
            this.newsCountTextBox.Size = new System.Drawing.Size(85, 30);
            this.newsCountTextBox.TabIndex = 3;
            this.newsCountTextBox.Tag = "";
            // 
            // loadNewsButton
            // 
            this.loadNewsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadNewsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loadNewsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadNewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadNewsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadNewsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadNewsButton.Location = new System.Drawing.Point(886, 33);
            this.loadNewsButton.Name = "loadNewsButton";
            this.loadNewsButton.Size = new System.Drawing.Size(242, 30);
            this.loadNewsButton.TabIndex = 4;
            this.loadNewsButton.Text = "Load News";
            this.loadNewsButton.UseVisualStyleBackColor = false;
            this.loadNewsButton.Click += new System.EventHandler(this.loadNewsButton_Click);
            // 
            // newsListBox
            // 
            this.newsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newsListBox.FormattingEnabled = true;
            this.newsListBox.ItemHeight = 23;
            this.newsListBox.Location = new System.Drawing.Point(795, 82);
            this.newsListBox.Name = "newsListBox";
            this.newsListBox.Size = new System.Drawing.Size(333, 303);
            this.newsListBox.TabIndex = 5;
            this.newsListBox.SelectedIndexChanged += new System.EventHandler(this.newsListBox_SelectedIndexChanged);
            // 
            // previousPageButton
            // 
            this.previousPageButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.previousPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previousPageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousPageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.previousPageButton.Location = new System.Drawing.Point(793, 400);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(156, 38);
            this.previousPageButton.TabIndex = 7;
            this.previousPageButton.Text = "Previous";
            this.previousPageButton.UseVisualStyleBackColor = false;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPageButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.nextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextPageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextPageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextPageButton.Location = new System.Drawing.Point(974, 400);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(156, 38);
            this.nextPageButton.TabIndex = 7;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = false;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 468);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.newsListBox);
            this.Controls.Add(this.loadNewsButton);
            this.Controls.Add(this.newsCountTextBox);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Text_Editor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSurnameWithInitialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countWordOccurrencesToolStripMenuItem;
        private System.Windows.Forms.TextBox newsCountTextBox;
        private System.Windows.Forms.Button loadNewsButton;
        private System.Windows.Forms.ListBox newsListBox;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button nextPageButton;
    }
}