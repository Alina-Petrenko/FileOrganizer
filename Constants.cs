// <copyright file="StoreActions.cs" company="AlinaP">
// Copyright (c) AlinaP. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace FileOrganizer
{
    /// <summary>
    /// Privides constants for organazing.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Gets a list of video file extensions.
        /// </summary>
        public static List<string> VideoTypes { get; } = new List<string>
        {
            ".mp4",
            ".mov",
            ".wmp",
            ".avi"
        };

        /// <summary>
        /// Gets a list of image file extensions.
        /// </summary>
        public static List<string> ImageTypes { get; } = new List<string>
        {
            ".jpeg",
            ".jpg",
            ".png",
            ".gif",
            ".tiff",
            ".ai",
            ".raw",
            ".psd"
        };

        /// <summary>
        /// Gets a list of audio file extensions.
        /// </summary>
        public static List<string> AudioTypes { get; } = new List<string>
        {
            ".m4p",
            ".flac",
            ".mp3",
            ".wav",
            ".wma",
            ".aac"
        };

        /// <summary>
        /// Gets a list of document file extensions.
        /// </summary>
        public static List<string> DocTypes { get; } = new List<string>
        {
            ".doc",
            ".docx",
            ".html",
            ".odt",
            ".pdf",
            ".xls",
            ".xlsx",
            ".ppt",
            ".pptx",
            ".txt"
        };
    }
}