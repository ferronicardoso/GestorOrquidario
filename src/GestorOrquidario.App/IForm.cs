using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorOrquidario.App
{
    internal interface IForm
    {
        void Init();
        void Bind();
        void Cancel();
        void Delete();
        void Edit();
        void EnableEdit(bool value);
        void New();
        void Save();
    }
}
