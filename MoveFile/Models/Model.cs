using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveFile.Models
{
    class Model
    {
        public delegate void DoneEventHandler();

        public event DoneEventHandler doneEvent;

        string _sourcePath;
        string _goalPath;
        string _filterString;

        public string SourcePath { get => _sourcePath; set => _sourcePath = value; }
        public string GoalPath { get => _goalPath; set => _goalPath = value; }
        public string FilterString { get => _filterString; set => _filterString = value; }
        private void NotifyDoneEvent() => doneEvent?.Invoke();

        public void DoOperate()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_sourcePath);
            DirectoryInfo[] subDirectoryInfos = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDir in subDirectoryInfos)
            {
                DirectoryInfo goal = new DirectoryInfo(_goalPath + "\\" + subDir.Name);
                DoMove(subDir, goal, _filterString);
            }
            NotifyDoneEvent();
        }        

        private void DoMove(DirectoryInfo source, DirectoryInfo goal, string pattern)
        {
            List<FileInfo> fileInfos = source.GetFiles(pattern, SearchOption.AllDirectories).ToList();
            if (fileInfos.Count != 0 && !goal.Exists)
                Directory.CreateDirectory(goal.FullName);
            fileInfos.ToList().ForEach(e => e.CopyTo(goal.FullName + "\\" + e.Name, true));
        }
    }
}