using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        T Create(string n);
        string Read(string path);

        void OverWrite(string path, string text);
    }
}
