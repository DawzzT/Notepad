using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDirectory : IModel<DirectoryInfo>
    {
        void Delete(string path);

        DirectoryInfo get(string path);

        DirectoryInfo CreateFile(string path, string name);
    }
}
