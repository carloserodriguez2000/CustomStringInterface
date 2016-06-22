using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemArrayString : ICustomString
    {
        char[] sysArrayList ;
        public int Length()
        {
            int length = sysArrayList.Count();
            return length;
        }
        public SystemArrayString(string strngToInsert)
        {
            //CONSTRUCTOR
            sysArrayList = strngToInsert.ToArray();
        }

        public void Insert(string strngToInsert)
        {
            int newLength       = sysArrayList.Count() + strngToInsert.Count();
   
            char [] biggerArray = new char [newLength];
            sysArrayList.CopyTo(biggerArray, 0);

            for (int i = sysArrayList.Count(), j = 0; i < newLength; i++, j++)
            {
                biggerArray[i] = strngToInsert[j];
            }
            sysArrayList = biggerArray;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {

        }

        public override string ToString()
        {

            string theStr = null;

            //theStr = sysArrayList.ToString();
            foreach (var item in sysArrayList)
            {
                theStr += item.ToString();
            }

            return theStr;
        }
    }
}
