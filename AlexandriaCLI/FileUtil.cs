using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace AlexandriaCLI
{
    class FileUtil
    {
        public bool ProcessDirectory(string directoryName, bool recursive)
        {
            DirectoryInfo di = new DirectoryInfo(directoryName);
            
            foreach (FileInfo fi in di.GetFiles())
                ProcessFile(fi.FullName );
            

            if (recursive)
            {
                foreach(DirectoryInfo dis in di.GetDirectories())
                       ProcessDirectory (di.FullName, recursive);
            }
            return true;
        }
        public bool ProcessFile(string fileName)
        {
            string hashText;
            FileInfo fi;
            
            try
            {
                fi = new FileInfo(fileName);
                hashText = HashCalc(fileName);
                Console.WriteLine("FileName: {0}; DirectoryName: {1}; FileSize: {2}; HashValue: {3}", fi.Name, fi.DirectoryName, fi.Length, hashText);
            }
            catch { }

            
            return true;
        }

        private static string HashCalc(string fileName)
        {
            string hashText;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    hashText = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
            return hashText;
        } 
    }
}
