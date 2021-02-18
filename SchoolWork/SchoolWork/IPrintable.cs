using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork
{
    interface IPrintable
    {
        void Print();   // this is what links each of the classes to the interface
        int GetScore();

    }
}
