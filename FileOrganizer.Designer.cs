// <copyright file="Organizer.cs" company="AlinaP">
// Copyright (c) AlinaP. All rights reserved.
// </copyright>

using System.Windows.Forms;

namespace FileOrganizer
{
    partial class FileOrganizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            PathTextBox = new TextBox();
            BrowseButton = new Button();
            OrganizeButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // PathTextBox
            // 
            PathTextBox.Location = new System.Drawing.Point(16, 18);
            PathTextBox.Margin = new Padding(4, 5, 4, 5);
            PathTextBox.Name = "PathTextBox";
            PathTextBox.Size = new System.Drawing.Size(265, 27);
            PathTextBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new System.Drawing.Point(291, 15);
            BrowseButton.Margin = new Padding(4, 5, 4, 5);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new System.Drawing.Size(100, 35);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // OrganizeButton
            // 
            OrganizeButton.Location = new System.Drawing.Point(16, 58);
            OrganizeButton.Margin = new Padding(4, 5, 4, 5);
            OrganizeButton.Name = "OrganizeButton";
            OrganizeButton.Size = new System.Drawing.Size(100, 35);
            OrganizeButton.TabIndex = 2;
            OrganizeButton.Text = "Organize";
            OrganizeButton.UseVisualStyleBackColor = true;
            OrganizeButton.Click += OrganizeButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new System.Drawing.Point(124, 58);
            ExitButton.Margin = new Padding(4, 5, 4, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(100, 35);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FileOrganizer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(413, 120);
            Controls.Add(ExitButton);
            Controls.Add(OrganizeButton);
            Controls.Add(BrowseButton);
            Controls.Add(PathTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FileOrganizer";
            Text = "File Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button OrganizeButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

