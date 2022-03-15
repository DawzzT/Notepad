using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class DirectoryRepository : IDirectory
    {
        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        public DirectoryInfo Create(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return Directory.CreateDirectory(path);
        }

        public DirectoryInfo CreateFile(string path, string name)
        {
            using (FileStream fileStream = File.Create(path + @"\" + name + ".txt"))
            {
                fileStream.Close();
            }
            return Directory.CreateDirectory(path);

        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public DirectoryInfo get(string path)
        {
            return new DirectoryInfo(path);
        }

        public void OverWrite(string path, string text)
        {
            using (FileStream file = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                binaryWriter = new BinaryWriter(file);
                binaryWriter.Write(text);
                binaryWriter.Close();
                file.Close();
            }

        }

        public string Read(string path)
        {
            string fileText = "";
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                binaryReader = new BinaryReader(file);
                long length = binaryReader.BaseStream.Length / sizeof(int);
                binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                fileText = File.ReadAllText(path);

                binaryReader.Close();
                file.Close();
            }

            return fileText;
        }
    }
}
