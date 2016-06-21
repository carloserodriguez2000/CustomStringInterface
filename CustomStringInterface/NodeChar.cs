using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
   
    class MyNode<T>
    {
        private T _TValue;

        public T TValue
        {
            get { return _TValue; } set { _TValue = value; }
        }

        public MyNode<T> NextNode { get; set; }
        public MyNode(T Tdata)
        {
            _TValue = Tdata;
            NextNode = null;
        }
    }//END OF CLASS
}//END OF NAMESPACE
