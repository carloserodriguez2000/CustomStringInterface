using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemArrayString : ICustomString
    {
        public int Length()
        {
            int length = 0;
            return length;
        }
        public SystemArrayString()
        {
            //CONSTRUCTOR
        }

        public void Insert(string strngToInsert)
        {

        }

        public void Remove(int startIndex, int numCharsToRemove)
        {

        }
    }
}
