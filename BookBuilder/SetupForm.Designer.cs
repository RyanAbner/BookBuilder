﻿namespace BookBuilder
{
    partial class SetupForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.PagesBox = new System.Windows.Forms.NumericUpDown();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.AuthorBox1 = new System.Windows.Forms.TextBox();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.OpenBookButton = new System.Windows.Forms.Button();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesBox)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00847F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.99152F));
            this.tableLayoutPanel.Controls.Add(this.AuthorLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.TitleBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.DescriptionLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.DescriptionBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.PagesBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.PagesLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.AuthorBox1, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.AddAuthorButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.BottomPanel, 1, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(472, 256);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.AuthorLabel.Location = new System.Drawing.Point(3, 167);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(56, 15);
            this.AuthorLabel.TabIndex = 8;
            this.AuthorLabel.Text = "Author(s)";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 15);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(87, 3);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(382, 20);
            this.TitleBox.TabIndex = 2;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 57);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AcceptsReturn = true;
            this.DescriptionBox.AcceptsTab = true;
            this.DescriptionBox.Location = new System.Drawing.Point(87, 60);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionBox.Size = new System.Drawing.Size(382, 101);
            this.DescriptionBox.TabIndex = 7;
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(87, 33);
            this.PagesBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PagesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(69, 20);
            this.PagesBox.TabIndex = 4;
            this.PagesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PagesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.PagesLabel.Location = new System.Drawing.Point(3, 30);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(42, 15);
            this.PagesLabel.TabIndex = 5;
            this.PagesLabel.Text = "Pages";
            this.PagesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AuthorBox1
            // 
            this.AuthorBox1.Location = new System.Drawing.Point(87, 170);
            this.AuthorBox1.Name = "AuthorBox1";
            this.AuthorBox1.Size = new System.Drawing.Size(290, 20);
            this.AuthorBox1.TabIndex = 9;
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(87, 196);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorButton.TabIndex = 10;
            this.AddAuthorButton.Text = "Add...";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorBox);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.OpenBookButton);
            this.BottomPanel.Controls.Add(this.CreateBookButton);
            this.BottomPanel.Location = new System.Drawing.Point(87, 230);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(382, 23);
            this.BottomPanel.TabIndex = 12;
            // 
            // OpenBookButton
            // 
            this.OpenBookButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenBookButton.Location = new System.Drawing.Point(262, 0);
            this.OpenBookButton.Name = "OpenBookButton";
            this.OpenBookButton.Size = new System.Drawing.Size(117, 23);
            this.OpenBookButton.TabIndex = 12;
            this.OpenBookButton.Text = "Open Existing Book";
            this.OpenBookButton.UseVisualStyleBackColor = true;
            this.OpenBookButton.Click += new System.EventHandler(this.OpenExistingBook);
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateBookButton.Location = new System.Drawing.Point(138, 0);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Size = new System.Drawing.Size(75, 23);
            this.CreateBookButton.TabIndex = 11;
            this.CreateBookButton.Text = "Create Book";
            this.CreateBookButton.UseVisualStyleBackColor = true;
            this.CreateBookButton.Click += new System.EventHandler(this.GoToBuilder);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 290);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupFormClosed);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesBox)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.NumericUpDown PagesBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorBox1;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Button CreateBookButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button OpenBookButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}