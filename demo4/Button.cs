using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.demo4
{
    public delegate void ActionDelegate(string msg);
    internal class Button
    {
        public event ActionDelegate Click;
        public Button(ActionDelegate onAction) 
        {
            Click += onAction;
        }
    }
}
