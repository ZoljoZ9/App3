using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using System.IO;
using Xamarin.Forms;
using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;
using App3.iOS;

[assembly: Dependency(typeof(FileHelper))]
namespace App3.iOS
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }

        public void DeleteEmptyDirectroy(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                if (!Directory.EnumerateFileSystemEntries(directoryPath).Any())
                {
                    Directory.Delete(directoryPath);
                }
            }
        }

        DirectoryInfo IFileHelper.CreateDirectory(string path)
        {
            throw new NotImplementedException();
        }

        string IFileHelper.GetCurrentDirectory()
        {
            throw new NotImplementedException();
        }

        bool IFileHelper.Exists(string path)
        {
            throw new NotImplementedException();
        }

        bool IFileHelper.DirectoryExists(string path)
        {
            throw new NotImplementedException();
        }

        Stream IFileHelper.GetStream(string filePath, FileMode mode, FileAccess access)
        {
            throw new NotImplementedException();
        }

        Stream IFileHelper.GetStream(string filePath, FileMode mode, FileAccess access, FileShare share)
        {
            throw new NotImplementedException();
        }

        IEnumerable<string> IFileHelper.EnumerateFiles(string directory, SearchOption searchOption, params string[] endsWithSearchPatterns)
        {
            throw new NotImplementedException();
        }

        FileAttributes IFileHelper.GetFileAttributes(string path)
        {
            throw new NotImplementedException();
        }

        Version IFileHelper.GetFileVersion(string path)
        {
            throw new NotImplementedException();
        }

        void IFileHelper.CopyFile(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        void IFileHelper.MoveFile(string sourcePath, string destinationPath)
        {
            throw new NotImplementedException();
        }

        void IFileHelper.WriteAllTextToFile(string filePath, string content)
        {
            throw new NotImplementedException();
        }

        string IFileHelper.GetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        void IFileHelper.DeleteDirectory(string directoryPath, bool recursive)
        {
            throw new NotImplementedException();
        }

        string[] IFileHelper.GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            throw new NotImplementedException();
        }

        void IFileHelper.Delete(string path)
        {
            throw new NotImplementedException();
        }

        string IFileHelper.GetTempPath()
        {
            throw new NotImplementedException();
        }

        long IFileHelper.GetFileLength(string path)
        {
            throw new NotImplementedException();
        }
    }

}
