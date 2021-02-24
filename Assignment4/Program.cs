using System;
using System.IO;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ReadAndWriteFileAsync();
        }

        private static async Task ReadAndWriteFileAsync()
        {
            string ReadFilePath ="A.txt";
            string content = await File.ReadAllTextAsync(ReadFilePath);
            if(string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("'A.txt 'File is Empty.");
            }
            else
            {
                string WriteFilePath ="B.txt";
                await File.WriteAllTextAsync(WriteFilePath,content); 
                Console.WriteLine("Successfully Content of 'A.txt' File copied to 'B.txt' File.");  
            }
        }
    }
}
