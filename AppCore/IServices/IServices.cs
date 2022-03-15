using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {
        T Create(string n);
        string Read(string path);
        void OverWrite(string path, string text);
    }
}
