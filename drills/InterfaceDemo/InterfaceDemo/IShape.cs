using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IShape
    {
        int MyNumber
        {
            get;
            set;
        }
        void InterfaceMethod();
    }
}
