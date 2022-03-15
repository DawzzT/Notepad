using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class DirectoryServices : BaseServices<DirectoryInfo>, IDirectoryServices
    {
        IDirectory repository;
        public DirectoryServices(IDirectory _repository) : base(_repository)
        {
            this.repository = _repository;
        }
        public DirectoryInfo CreateFile(string path, string name)
        {
            return repository.CreateFile(path, name);
        }

        public void Delete(string path)
        {
            repository.Delete(path);
        }

        public DirectoryInfo get(string path)
        {
            return repository.get(path);
        }
    }
}
