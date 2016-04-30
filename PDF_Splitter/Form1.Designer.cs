namespace PDF_Splitter
{
    partial class frmMain
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
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.txtSourceLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.butSourceFind = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.butOutputFind = new MetroFramework.Controls.MetroButton();
            this.txtOutputLocation = new MetroFramework.Controls.MetroTextBox();
            this.radioCombineFiles = new MetroFramework.Controls.MetroRadioButton();
            this.radioSplitFiles = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.textFileSize = new MetroFramework.Controls.MetroTextBox();
            this.tbFileSize = new MetroFramework.Controls.MetroTrackBar();
            this.radioSplitSize = new MetroFramework.Controls.MetroRadioButton();
            this.radioSplitPage = new MetroFramework.Controls.MetroRadioButton();
            this.progress = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSourceLocation
            // 
            this.txtSourceLocation.Lines = new string[0];
            this.txtSourceLocation.Location = new System.Drawing.Point(26, 91);
            this.txtSourceLocation.MaxLength = 32767;
            this.txtSourceLocation.Name = "txtSourceLocation";
            this.txtSourceLocation.PasswordChar = '\0';
            this.txtSourceLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSourceLocation.SelectedText = "";
            this.txtSourceLocation.Size = new System.Drawing.Size(323, 23);
            this.txtSourceLocation.TabIndex = 1;
            this.txtSourceLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSourceLocation.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Source Location";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // butSourceFind
            // 
            this.butSourceFind.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.butSourceFind.Highlight = true;
            this.butSourceFind.Location = new System.Drawing.Point(346, 91);
            this.butSourceFind.Name = "butSourceFind";
            this.butSourceFind.Size = new System.Drawing.Size(26, 23);
            this.butSourceFind.TabIndex = 3;
            this.butSourceFind.Text = "...";
            this.butSourceFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butSourceFind.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butSourceFind.UseSelectable = true;
            this.butSourceFind.UseStyleColors = true;
            this.butSourceFind.Click += new System.EventHandler(this.butSourceFind_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Output Location";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // butOutputFind
            // 
            this.butOutputFind.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.butOutputFind.Highlight = true;
            this.butOutputFind.Location = new System.Drawing.Point(346, 149);
            this.butOutputFind.Name = "butOutputFind";
            this.butOutputFind.Size = new System.Drawing.Size(26, 23);
            this.butOutputFind.TabIndex = 6;
            this.butOutputFind.Text = "...";
            this.butOutputFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butOutputFind.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.butOutputFind.UseSelectable = true;
            this.butOutputFind.UseStyleColors = true;
            this.butOutputFind.Click += new System.EventHandler(this.butOutputFind_Click);
            // 
            // txtOutputLocation
            // 
            this.txtOutputLocation.Lines = new string[0];
            this.txtOutputLocation.Location = new System.Drawing.Point(26, 149);
            this.txtOutputLocation.MaxLength = 32767;
            this.txtOutputLocation.Name = "txtOutputLocation";
            this.txtOutputLocation.PasswordChar = '\0';
            this.txtOutputLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOutputLocation.SelectedText = "";
            this.txtOutputLocation.Size = new System.Drawing.Size(323, 23);
            this.txtOutputLocation.TabIndex = 5;
            this.txtOutputLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtOutputLocation.UseSelectable = true;
            // 
            // radioCombineFiles
            // 
            this.radioCombineFiles.AutoSize = true;
            this.radioCombineFiles.Location = new System.Drawing.Point(26, 194);
            this.radioCombineFiles.Name = "radioCombineFiles";
            this.radioCombineFiles.Size = new System.Drawing.Size(98, 15);
            this.radioCombineFiles.TabIndex = 8;
            this.radioCombineFiles.Text = "Combine Files";
            this.radioCombineFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioCombineFiles.UseSelectable = true;
            // 
            // radioSplitFiles
            // 
            this.radioSplitFiles.AutoSize = true;
            this.radioSplitFiles.Location = new System.Drawing.Point(26, 215);
            this.radioSplitFiles.Name = "radioSplitFiles";
            this.radioSplitFiles.Size = new System.Drawing.Size(72, 15);
            this.radioSplitFiles.TabIndex = 9;
            this.radioSplitFiles.Text = "Split Files";
            this.radioSplitFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioSplitFiles.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.radioSplitSize);
            this.metroPanel1.Controls.Add(this.radioSplitPage);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(46, 236);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(326, 146);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.textFileSize);
            this.metroPanel2.Controls.Add(this.tbFileSize);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(22, 43);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(289, 100);
            this.metroPanel2.TabIndex = 13;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // textFileSize
            // 
            this.textFileSize.Enabled = false;
            this.textFileSize.Lines = new string[0];
            this.textFileSize.Location = new System.Drawing.Point(14, 43);
            this.textFileSize.MaxLength = 32767;
            this.textFileSize.Name = "textFileSize";
            this.textFileSize.PasswordChar = '\0';
            this.textFileSize.ReadOnly = true;
            this.textFileSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textFileSize.SelectedText = "";
            this.textFileSize.Size = new System.Drawing.Size(267, 23);
            this.textFileSize.TabIndex = 11;
            this.textFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFileSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textFileSize.UseSelectable = true;
            // 
            // tbFileSize
            // 
            this.tbFileSize.BackColor = System.Drawing.Color.Transparent;
            this.tbFileSize.Location = new System.Drawing.Point(14, 14);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(267, 23);
            this.tbFileSize.TabIndex = 2;
            this.tbFileSize.Text = "tbFileSize";
            this.tbFileSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // radioSplitSize
            // 
            this.radioSplitSize.AutoSize = true;
            this.radioSplitSize.Location = new System.Drawing.Point(3, 24);
            this.radioSplitSize.Name = "radioSplitSize";
            this.radioSplitSize.Size = new System.Drawing.Size(63, 15);
            this.radioSplitSize.TabIndex = 12;
            this.radioSplitSize.Text = "Per Size";
            this.radioSplitSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioSplitSize.UseSelectable = true;
            // 
            // radioSplitPage
            // 
            this.radioSplitPage.AutoSize = true;
            this.radioSplitPage.Location = new System.Drawing.Point(3, 3);
            this.radioSplitPage.Name = "radioSplitPage";
            this.radioSplitPage.Size = new System.Drawing.Size(108, 15);
            this.radioSplitPage.TabIndex = 11;
            this.radioSplitPage.Text = "On No Of Pages";
            this.radioSplitPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioSplitPage.UseSelectable = true;
            // 
            // progress
            // 
            this.progress.Enabled = false;
            this.progress.Location = new System.Drawing.Point(104, 392);
            this.progress.Name = "progress";
            this.progress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.Size = new System.Drawing.Size(253, 23);
            this.progress.TabIndex = 11;
            this.progress.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 422);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.radioSplitFiles);
            this.Controls.Add(this.radioCombineFiles);
            this.Controls.Add(this.butOutputFind);
            this.Controls.Add(this.txtOutputLocation);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.butSourceFind);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSourceLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "PDF File Utilities";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroTextBox txtSourceLocation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton butSourceFind;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton butOutputFind;
        private MetroFramework.Controls.MetroTextBox txtOutputLocation;
        private MetroFramework.Controls.MetroRadioButton radioCombineFiles;
        private MetroFramework.Controls.MetroRadioButton radioSplitFiles;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTrackBar tbFileSize;
        private MetroFramework.Controls.MetroRadioButton radioSplitSize;
        private MetroFramework.Controls.MetroRadioButton radioSplitPage;
        private MetroFramework.Controls.MetroTextBox textFileSize;
        private MetroFramework.Controls.MetroProgressBar progress;

    }
}

