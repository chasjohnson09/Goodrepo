using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
    interface IBarkable
    {
        string Bark();
        string GetName();   // give it a new name
        void SetName(string name);  // 
    }
}
