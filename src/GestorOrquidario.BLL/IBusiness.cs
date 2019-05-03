using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorOrquidario.BLL
{
    public interface IBusiness<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(T value);
        T Get(T value);
        bool Set(T value);
        bool Delete(T value);
        bool Delete(int Id);
    }
}
