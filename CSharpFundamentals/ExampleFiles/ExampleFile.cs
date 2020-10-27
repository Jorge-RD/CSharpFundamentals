using System;
using System.IO;


namespace CSharpFundamentals.ExampleFiles
{
    public class ExampleFile
    {
        public void ExampleFiles()
        {
            // FileCopy();
            Console.WriteLine("Static File");
            FileRead();
            Console.WriteLine("Class File");
            FileInfoRead();
        }

        public void FileCopy()
        {
            string sourceFileName = @"C:\Users\Intellisys\Desktop\code.png";
            string destFileName = @"C:\Users\Intellisys\Downloads\New folder\code.png";
            bool overite = true;
            File.Copy(sourceFileName, destFileName, overite);
        }

        public void FileRead()
        {
            string path = @"C:\Users\Intellisys\PROYECTOS\INTELLISYS\JS\JS-workspace.code-workspace";
            bool exist = File.Exists(path);
            if (exist)
            {
                string content = File.ReadAllText(path);
                Console.WriteLine(content);

            }
        }

        public void FileInfoRead()
        {
            string path = @"C:\Users\Intellisys\PROYECTOS\INTELLISYS\JS\JS-workspace.code-workspace";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                StreamReader content = fileInfo.OpenText();
                Console.WriteLine(content.ReadToEnd());
            }
        }
    }
}
