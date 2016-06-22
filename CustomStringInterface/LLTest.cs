using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class llTest //: ICustomString
    {
        LinkedList<char> sysLinkedList;

        public int Length()
        {

            return sysLinkedList.Count;
        }


        public llTest(string strngToInsert)
        {
            sysLinkedList = new LinkedList<char>();

            for (int i = 0; i < strngToInsert.Length; i++)
            {
                //LinkedListNode<char> llNode = new LinkedListNode<char>(strngToInsert[i]);
                sysLinkedList.AddLast(strngToInsert[i]);
            }

        }

        public void Insert(string strngToInsert)
        {
            for (int i = 0; i < strngToInsert.Length; i++)
            {
                sysLinkedList.AddLast(strngToInsert[i]);
            }
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            //ElementAt<T>(Int32);
            //sysLinkedList.Remove(node);
            //sysLinkedList.Remove(async char or a node)

            for (int i = 0; i < sysLinkedList.Count; i++)
            {
                Console.Write(sysLinkedList.ElementAt(i));
            }


            if ((startIndex + numCharsToRemove) <= sysLinkedList.Count)
            {

                
                for (int i = startIndex; i < (startIndex + numCharsToRemove); i++)
                {
                    //Console.WriteLine(sysLinkedList.ElementAt(i));
                    //sysLinkedList[i].Remove();
                    sysLinkedList.Remove(sysLinkedList.ElementAt(i));
                    //Console.WriteLine(sysLinkedList[i]);


                    Console.WriteLine();
                    for (int j = 0; j < sysLinkedList.Count; j++)
                    {
                        Console.Write(sysLinkedList.ElementAt(j));
                    }
                }
            }

        }

        public override string ToString()
        {
            string theStr = null;

            foreach (var item in sysLinkedList)
            {
                theStr += item.ToString();
            }
            return theStr;

        }
    }
}
