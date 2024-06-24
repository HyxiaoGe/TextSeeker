using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSeeker.BusinessLogic
{
    public class FileSearchManager
    {
        // 启动搜索过程
        public static async Task<List<String>> SearchFilesAsync(string directroy, string searchText)
        {
            List<String> results = new List<String>();
            await Task.Run(() =>
            {
                EnumerateFiles(directroy, searchText, results);
            });
            return results;
        }

        // 递归遍历所有文件
        private static void EnumerateFiles(string directroy, string searchText, List<string> results)
        {
            var fileEntries = Directory.GetFiles(directroy, "*", SearchOption.AllDirectories);
            foreach (var fileName in fileEntries)
            {
                if (ReadAndMatchContent(fileName, searchText))
                {
                    results.Add(fileName);
                }
            }
        }

        // 读取文件内容并检查是否包含指定的文本。
        private static bool ReadAndMatchContent(string fileName, string searchText)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                return content.Contains(searchText);
            }
            catch  (IOException)
            {
                return false;
            }
        }
    }
}
