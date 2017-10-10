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
        string _filterString;

        public string SourcePath { get => _sourcePath; set => _sourcePath = value; }
        public string GoalPath { get => _goalPath; set => _goalPath = value; }
        public string FilterString { get => _filterString; set => _filterString = value; }

        public void DoOperate()
        {
            string[] subDirectorys = GetSubDirectorys();
            subDirectorys.ToList().ForEach(folder => Move(folder));
        }

        private string[] GetSubDirectorys()
        {
            string[] subDirectorys = Directory.GetDirectories(_sourcePath);
            //subDirectorys.ToList().ForEach(e => Console.WriteLine(e));
            return subDirectorys;
        }

        private void Move(string folder)
        {
            Console.WriteLine("------------------------------" + folder);
            string[] files = Directory.GetFiles(folder, "*Summary*.doc", SearchOption.AllDirectories);
            //files.ToList().ForEach(e => Console.WriteLine(e));
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                //Console.WriteLine(fileInfo.Name);
                fileInfo.MoveTo(folder + "\\" + fileInfo.Name);
            }
        }
    }
}
