using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var sb = new StringBuilder();

            var files = Directory.GetFiles(inputFolderPath);

            var extensionFileInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                if (extensionFileInfo.ContainsKey(info.Extension) == false)
                {
                    extensionFileInfo[info.Extension] = new List<FileInfo>();
                }

                extensionFileInfo[info.Extension].Add(info);
            }

            foreach (var kvp in extensionFileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string ext = kvp.Key;
                var info = kvp.Value;

                sb.AppendLine(ext);
                foreach (var fileInfo in info.OrderByDescending(x => x.Length))
                {
                    string name = fileInfo.Name;
                    double size = fileInfo.Length / 1024;

                    sb.AppendLine($"--{name} - {size:F3}kb");

                }
            }

            var output = sb.ToString().TrimEnd();
            
            return output;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathToDesktop, textContent);
        }

    }
}
