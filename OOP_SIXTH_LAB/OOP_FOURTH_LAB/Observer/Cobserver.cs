using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_SIXTH_LAB.Observer
{
    public interface Cobserver
    {
        void OnSubjectChanged(Cobject who);

        void OnSubjectSelect(Cobject who);

        void OnSubjectMove(int x, int y);


    }
}
