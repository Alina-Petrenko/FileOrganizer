// <copyright file="Organizer.cs" company="AlinaP">
// Copyright (c) AlinaP. All rights reserved.
// </copyright>

using System;
using System.Windows.Forms;

namespace FileOrganizer
{
    /// <summary>
    /// Represents the main form of the File Organizer application.
    /// </summary>
    public partial class FileOrganizer : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOrganizer"/> class.
        /// </summary>
        public FileOrganizer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        /// <summary>
        /// Event handler for the "Organize" button click.
        /// Attempts to organize files in the specified directory and displays a success message or an error message.
        /// </summary>
        private void OrganizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = PathTextBox.Text;
                var organizer = new Organizer(path);
                organizer.Organize();
                MessageBox.Show("Organized!", "File Organizer");
            }
            catch
            {
                MessageBox.Show("It looks like you entered an incorrect path. Try again!", "File Organizer");
            }
        }

        /// <summary>
        /// Event handler for the "Exit" button click.
        /// Closes the application.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event handler for the "Browse" button click.
        /// Opens a folder dialog to allow the user to select a folder for organization.
        /// </summary>
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    PathTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
