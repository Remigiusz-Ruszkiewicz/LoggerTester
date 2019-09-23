using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    public class AppLogger
    {
        private readonly string path;
        public AppLogger(string path)
        {
            this.path = path;
        }
        public void Save()
        {
            Save(path);
        }
        public void Save(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                throw new Exception("Podaj inna nazwe");
            }
        }
        public void Write(string text)
        {
            //File.WriteAllBytes(path, new byte[] { 123, 221, 14, 35, 67 });
            File.AppendText(path).Close();

        }
        public void Write(string[] text)
        {
            File.AppendAllLines(path,text);
        }
        public void SaveDirectory(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            for (int i = 1; i <= 5; i++)
            {
                string path = Path.Combine(dir,$"{i}.txt");
                Save(path);
            }
        }
        public void Delete(string path = null)
        {
            if (path != null)
            {
                File.Delete(path);
                return;
            }
            File.Delete(this.path);
        }
    }
}
