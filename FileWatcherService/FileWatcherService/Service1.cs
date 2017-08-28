using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("FileLogSource"))
                System.Diagnostics.EventLog.CreateEventSource("FileLogSource", "FileServLog");
            eventLog1.Source = "FileLogSource";
            eventLog1.Log = "FileServLog";
            
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Service Started ");
            fileSystemWatcher1.Created += new FileSystemEventHandler(FileCreated);
            fileSystemWatcher1.Deleted += new FileSystemEventHandler(FileDeleted);
            fileSystemWatcher1.Changed += new FileSystemEventHandler(FileModified);
            fileSystemWatcher1.Path = @"C:\Temporary\";
        }

        private void FileModified(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("A File Has Been Modified");
            string sourcePath = @"C:\Temporary\";
            string targetPath = @"C:\TempCopy\";
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            // File.Copy(sourcePath + e.Name, targetPath + e.Name, true);
            foreach (var srcPath in Directory.GetFiles(sourcePath))
            {
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(sourcePath, targetPath), true);
            }

        }

        private void FileDeleted(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("A File Has Been Deleted");
        }

        private void FileCreated(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("New File Has Been Created");
            string sourcePath = @"C:\Temporary\";
            string targetPath = @"C:\TempCopy\";
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
           // File.Copy(sourcePath + e.Name, targetPath + e.Name, true);
            foreach (var srcPath in Directory.GetFiles(sourcePath))
            {
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(sourcePath, targetPath), true);
            }
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service Stopped ");
        }
    }
}
