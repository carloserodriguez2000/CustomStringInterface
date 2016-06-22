using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemArrayString : ICustomString
    {
        Array sysArrayList;                     //char[] sysArrayList; //=  Array.CreateInstance(typeof(char),
       
        public int Length()
        {
            int length = sysArrayList.Length;
            return length;
        }
        public SystemArrayString(string strngToInsert)          //CONSTRUCTOR
        {
            sysArrayList = strngToInsert.ToArray();
        }

        public void Insert(string strngToInsert)
        {
            int newLength     = sysArrayList.Length + strngToInsert.Count();
            Array biggerArray = Array.CreateInstance(typeof(char), newLength);
            System.Array.Copy(sysArrayList, 0, biggerArray, 0, sysArrayList.Length);
            System.Array.Copy(strngToInsert.ToArray(), 0, biggerArray, sysArrayList.Length, strngToInsert.Count());
            sysArrayList = biggerArray;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            for (int i = startIndex; i < sysArrayList.Length; i++)
            {
                if (i + numCharsToRemove < sysArrayList.Length) // dont go past the end
                {
                    sysArrayList.SetValue(sysArrayList.GetValue(i + numCharsToRemove), i);
                }
                else
                {
                    sysArrayList.SetValue(null, i);             // set to null the end of the array
                }
            }
            Array smallerArray = Array.CreateInstance(typeof(char), sysArrayList.Length- numCharsToRemove);
            System.Array.Copy(sysArrayList, 0, smallerArray, 0, smallerArray.Length);
            sysArrayList = smallerArray;
        }

        public override string ToString()
        {
            string theStr = null;
            foreach (var item in sysArrayList)   //theStr = sysArrayList.ToString();
            {
                theStr += item.ToString();
            }
            return theStr;
        }
    }
}
