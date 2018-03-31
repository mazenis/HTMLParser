namespace HTMLParser
{
    partial class Form1
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
            this.butBadMethod = new System.Windows.Forms.Button();
            this.butBetterMethod = new System.Windows.Forms.Button();
            this.butClean = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butTheBestMethod = new System.Windows.Forms.Button();
            this.butBad1Method = new System.Windows.Forms.Button();
            this.butViewInTxt = new System.Windows.Forms.Button();
            this.butBestMethod = new System.Windows.Forms.Button();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResulte = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butFWords = new System.Windows.Forms.Button();
            this.DGViewFrequancy = new System.Windows.Forms.DataGridView();
            this.butLonWord = new System.Windows.Forms.Button();
            this.lblTheLongestWord = new System.Windows.Forms.Label();
            this.butLetterFrequency = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFrequancy)).BeginInit();
            this.SuspendLayout();
            // 
            // butBadMethod
            // 
            this.butBadMethod.Location = new System.Drawing.Point(9, 3);
            this.butBadMethod.Name = "butBadMethod";
            this.butBadMethod.Size = new System.Drawing.Size(75, 23);
            this.butBadMethod.TabIndex = 0;
            this.butBadMethod.Text = "Bad";
            this.butBadMethod.UseVisualStyleBackColor = true;
            this.butBadMethod.Click += new System.EventHandler(this.button1_Click);
            // 
            // butBetterMethod
            // 
            this.butBetterMethod.Location = new System.Drawing.Point(7, 74);
            this.butBetterMethod.Name = "butBetterMethod";
            this.butBetterMethod.Size = new System.Drawing.Size(75, 23);
            this.butBetterMethod.TabIndex = 1;
            this.butBetterMethod.Text = "Better";
            this.butBetterMethod.UseVisualStyleBackColor = true;
            this.butBetterMethod.Click += new System.EventHandler(this.button2_Click);
            // 
            // butClean
            // 
            this.butClean.Location = new System.Drawing.Point(9, 312);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(75, 23);
            this.butClean.TabIndex = 2;
            this.butClean.Text = "Clean";
            this.butClean.UseVisualStyleBackColor = true;
            this.butClean.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butTheBestMethod);
            this.panel1.Controls.Add(this.butBad1Method);
            this.panel1.Controls.Add(this.butViewInTxt);
            this.panel1.Controls.Add(this.butBestMethod);
            this.panel1.Controls.Add(this.butBetterMethod);
            this.panel1.Controls.Add(this.butBadMethod);
            this.panel1.Controls.Add(this.butClean);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 346);
            this.panel1.TabIndex = 5;
            // 
            // butTheBestMethod
            // 
            this.butTheBestMethod.Location = new System.Drawing.Point(7, 174);
            this.butTheBestMethod.Name = "butTheBestMethod";
            this.butTheBestMethod.Size = new System.Drawing.Size(75, 51);
            this.butTheBestMethod.TabIndex = 5;
            this.butTheBestMethod.Text = "The Best";
            this.butTheBestMethod.UseVisualStyleBackColor = true;
            this.butTheBestMethod.Click += new System.EventHandler(this.button7_Click);
            // 
            // butBad1Method
            // 
            this.butBad1Method.Location = new System.Drawing.Point(9, 32);
            this.butBad1Method.Name = "butBad1Method";
            this.butBad1Method.Size = new System.Drawing.Size(75, 23);
            this.butBad1Method.TabIndex = 4;
            this.butBad1Method.Text = "Bad1";
            this.butBad1Method.UseVisualStyleBackColor = true;
            this.butBad1Method.Click += new System.EventHandler(this.button6_Click);
            // 
            // butViewInTxt
            // 
            this.butViewInTxt.Location = new System.Drawing.Point(9, 246);
            this.butViewInTxt.Name = "butViewInTxt";
            this.butViewInTxt.Size = new System.Drawing.Size(75, 45);
            this.butViewInTxt.TabIndex = 3;
            this.butViewInTxt.Text = "View in txtBox";
            this.butViewInTxt.UseVisualStyleBackColor = true;
            this.butViewInTxt.Visible = false;
            this.butViewInTxt.Click += new System.EventHandler(this.butViewInTxt_Click);
            // 
            // butBestMethod
            // 
            this.butBestMethod.Location = new System.Drawing.Point(9, 120);
            this.butBestMethod.Name = "butBestMethod";
            this.butBestMethod.Size = new System.Drawing.Size(75, 34);
            this.butBestMethod.TabIndex = 0;
            this.butBestMethod.Text = "Best";
            this.butBestMethod.UseVisualStyleBackColor = true;
            this.butBestMethod.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(193, 2);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(81, 24);
            this.cmbBox.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Show (Limited)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(367, 24);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "https://en.wikipedia.org";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "---";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Location = new System.Drawing.Point(-2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(1266, 691);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "---";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.txtResulte);
            this.panel2.Location = new System.Drawing.Point(103, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 699);
            this.panel2.TabIndex = 8;
            // 
            // txtResulte
            // 
            this.txtResulte.Location = new System.Drawing.Point(0, 3);
            this.txtResulte.Multiline = true;
            this.txtResulte.Name = "txtResulte";
            this.txtResulte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResulte.Size = new System.Drawing.Size(1288, 689);
            this.txtResulte.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbBox);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(385, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 31);
            this.panel3.TabIndex = 9;
            // 
            // butFWords
            // 
            this.butFWords.Location = new System.Drawing.Point(5, 407);
            this.butFWords.Name = "butFWords";
            this.butFWords.Size = new System.Drawing.Size(85, 47);
            this.butFWords.TabIndex = 11;
            this.butFWords.Text = "Word\'s Frequency";
            this.butFWords.UseVisualStyleBackColor = true;
            this.butFWords.Visible = false;
            this.butFWords.Click += new System.EventHandler(this.butFWords_Click);
            // 
            // DGViewFrequancy
            // 
            this.DGViewFrequancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewFrequancy.Location = new System.Drawing.Point(1375, 41);
            this.DGViewFrequancy.Name = "DGViewFrequancy";
            this.DGViewFrequancy.RowTemplate.Height = 26;
            this.DGViewFrequancy.Size = new System.Drawing.Size(216, 699);
            this.DGViewFrequancy.TabIndex = 12;
            // 
            // butLonWord
            // 
            this.butLonWord.Location = new System.Drawing.Point(5, 460);
            this.butLonWord.Name = "butLonWord";
            this.butLonWord.Size = new System.Drawing.Size(84, 54);
            this.butLonWord.TabIndex = 13;
            this.butLonWord.Text = "Longest word";
            this.butLonWord.UseVisualStyleBackColor = true;
            this.butLonWord.Visible = false;
            this.butLonWord.Click += new System.EventHandler(this.butLonWord_Click);
            // 
            // lblTheLongestWord
            // 
            this.lblTheLongestWord.AutoSize = true;
            this.lblTheLongestWord.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTheLongestWord.ForeColor = System.Drawing.Color.Blue;
            this.lblTheLongestWord.Location = new System.Drawing.Point(1061, 11);
            this.lblTheLongestWord.Name = "lblTheLongestWord";
            this.lblTheLongestWord.Size = new System.Drawing.Size(26, 17);
            this.lblTheLongestWord.TabIndex = 14;
            this.lblTheLongestWord.Text = "---";
            // 
            // butLetterFrequency
            // 
            this.butLetterFrequency.Location = new System.Drawing.Point(5, 533);
            this.butLetterFrequency.Name = "butLetterFrequency";
            this.butLetterFrequency.Size = new System.Drawing.Size(82, 62);
            this.butLetterFrequency.TabIndex = 15;
            this.butLetterFrequency.Text = "Letter\'s Frequency";
            this.butLetterFrequency.UseVisualStyleBackColor = true;
            this.butLetterFrequency.Click += new System.EventHandler(this.butLetterFrequency_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 742);
            this.Controls.Add(this.butLetterFrequency);
            this.Controls.Add(this.lblTheLongestWord);
            this.Controls.Add(this.butLonWord);
            this.Controls.Add(this.DGViewFrequancy);
            this.Controls.Add(this.butFWords);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFrequancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBadMethod;
        private System.Windows.Forms.Button butBetterMethod;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butBestMethod;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResulte;
        private System.Windows.Forms.Button butViewInTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butBad1Method;
        private System.Windows.Forms.Button butTheBestMethod;
        private System.Windows.Forms.Button butFWords;
        private System.Windows.Forms.DataGridView DGViewFrequancy;
        private System.Windows.Forms.Button butLonWord;
        private System.Windows.Forms.Label lblTheLongestWord;
        private System.Windows.Forms.Button butLetterFrequency;
    }
}