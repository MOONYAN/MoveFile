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
        string _sourcePath;
        string _goalPath;

        public string SourcePath { get => _sourcePath; set => _sourcePath = value; }
        public string GoalPath { get => _goalPath; set => _goalPath = value; }

        public void DoOperate()
        {
            FindFile();
        }
        private void FindFile()
        {
            string[] subDirectorys = Directory.GetDirectories(_sourcePath);
            subDirectorys.ToList().ForEach(e => Console.WriteLine(e));
        }
    }
}
