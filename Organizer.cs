// <copyright file="Organizer.cs" company="AlinaP">
// Copyright (c) AlinaP. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileOrganizer
{
    /// <summary>
    /// Defines functionaltity for organizing files in a specified directory into subdirectories based on their types.
    /// </summary>
    public class Organizer
    {
        /// <summary>
        /// The target directory path where files will be organized.
        /// </summary>
        private readonly string path;

        /// <summary>
        /// A dictionary that maps subdirectory names to lists of file types/extensions to be organized within each subdirectory.
        /// </summary>
        private readonly Dictionary<string, List<string>> directories = new()
        {
            ["Videos"] = Constants.VideoTypes,
            ["Images"] = Constants.ImageTypes,
            ["Audios"] = Constants.AudioTypes,
            ["Documents"] = Constants.DocTypes,
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Organizer"/> class with the specified target directory path.
        /// </summary>
        /// <param name="path">The path to the directory containing the files to be organized.</param>
        public Organizer(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Organizes the files in the target directory into subdirectories based on their types.
        /// </summary>
        public void Organize()
        {
            foreach (var directory in directories.Keys)
            {
                string destinationDirectory = Path.Combine(path, directory);

                foreach (var type in directories[directory])
                {
                    var files = Directory.GetFiles(path, $"*{type}");

                    if (files.Any() && !Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    foreach (var file in files)
                    {
                        var name = Path.GetFileName(file);
                        string destinationPath = Path.Combine(destinationDirectory, name);

                        File.Move(file, destinationPath);
                    }
                }
            }
        }
    }
}