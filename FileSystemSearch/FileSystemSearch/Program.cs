using System;
using System.IO;
using System.Collections;

namespace FileSystemSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give your path
            GetFilesInDirectory(@"C:\Users\sthapa\Documents\Test");
            Console.ReadLine();
        }

        public static ArrayList GetFilesInDirectory(string path)
        {

            ArrayList fileList = new ArrayList();
            FindFiles(path, fileList);
            foreach (string dir in Directory.GetDirectories(path))
            {
                //Function caling function, recursion happens here. 
                GetFilesInDirectory(dir);
            }

            return fileList;
        }

        private static void FindFiles(string path, ArrayList fileList)
        {
            string[] files = Directory.GetFiles(path);
            if (files != null)
            {
                foreach (string file in files)
                {
                    fileList.Add(file);
                    Console.WriteLine(file);
                }
            }
        }
    }
}
