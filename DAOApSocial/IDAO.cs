using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApSocial.DAO
{
    public interface IDAO<t>
    {
        void add(t dato);
        void remove(t dato);
        void modify(t dato);
        List<t> getAll();
        t searchById(int d);
    }
}
