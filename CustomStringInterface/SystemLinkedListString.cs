using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class SystemLinkedListString //: ICustomString
    {
        LinkedList<char> sysLinkedList;

        public int Length()
        {
            return sysLinkedList.Count;
        }
        
        public SystemLinkedListString( string strngToInsert)
        {
            sysLinkedList = new LinkedList<char>();

            for (int i = 0; i < strngToInsert.Length; i++)
            {
                LinkedListNode<char> llNode = new LinkedListNode<char>(strngToInsert[i]);
                sysLinkedList.AddLast(llNode);
            }
        }

        public void Insert(string strngToInsert)
        {
            for (int i = 0; i < strngToInsert.Length; i++)
            {
                LinkedListNode<char> llNode = new LinkedListNode<char>(strngToInsert[i]);
                sysLinkedList.AddLast(llNode);
            }
        }

        public void Remove(int startIndex, int numCharsToRemove) 
        {
            if ( (startIndex + numCharsToRemove)  <= sysLinkedList.Count  )
            {
                LinkedListNode<char> nodePtr = sysLinkedList.First;
                for (int i = 0; i < startIndex; i++)                // TRAVERSE TO THE LOCATION "startIndex"
                {
                    nodePtr = nodePtr.Next;
                }
                for (int i = 0; i < numCharsToRemove; i++)          // START REMOVING "numCharsToRemove "NODES
                {
                    LinkedListNode<char> nodePtrNext = nodePtr.Next;
                    sysLinkedList.Remove(nodePtr);
                    nodePtr = nodePtrNext;
                }
            }
        }

        public  override string ToString()
        {
            string theStr=null;

            //theStr = sysLinkedList.ToString();
            foreach (var item in sysLinkedList)
            {
                theStr += item.ToString();
            }
            return theStr;
        }
    }
}
