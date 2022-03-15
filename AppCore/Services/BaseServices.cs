using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public abstract class BaseServices<T> : IServices<T>
    {
        private IModel<T> model;
        protected BaseServices(IModel<T> _model)
        {
            this.model = _model;
        }
        public T Create(string n)
        {
            return model.Create(n);
        }

        public void OverWrite(string path, string text)
        {
            model.OverWrite(path, text);
        }

        public string Read(string path)
        {
            return model.Read(path);
        }
    }
}
