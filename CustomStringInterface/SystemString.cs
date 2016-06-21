using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface 
{
    class SystemString : ICustomString
    {
         private string theString= null;

        public SystemString(string data)                            //CONSTRUCTOR
        {   theString = data; }

        public override string ToString()                           //OVERRIDE
        {   return theString;   }
        
        public int Length()                                         //INTERFACE IMPLEMENTATION
        {   return theString.Length;    }
       
        public void Insert(string strngToInsert)                    //INTERFACE IMPLEMENTATION
        {
            theString.Insert(theString.Count(), strngToInsert);
        }

        public void Remove(int startIndex, int numCharsToRemove)    //INTERFACE IMPLEMENTATION
        {
            theString.Remove(startIndex, numCharsToRemove);
        }
    }
}
