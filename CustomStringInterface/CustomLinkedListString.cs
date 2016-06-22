using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class CustomLinkedListString : ICustomString
    {
        private MyNode<char> _Head;
        // OR get { return _Head;} set { _Head = value; }
        // OR  public NodeChar _Head { get; set; }

        public int Length()
        {
            int length = 0;
            MyNode<char> nodePtr = _Head;

            do
            {
                length++;
                nodePtr = nodePtr.NextNode;
            } while (nodePtr != null);
            return length;
        }

        private void PatchSegment(string strngToInsert, MyNode<char> nodePtr)
        {
            int i = 0;

            if (nodePtr == null)
            {
                nodePtr = new MyNode<char>(strngToInsert[0]);
                _Head = nodePtr;
                i = 1;
            }

            for (; i < strngToInsert.Length; i++) // intial i=1 when adding the first string, i=0 afterwards
            {
                nodePtr.NextNode = new MyNode<char>(strngToInsert[i]);
                nodePtr = nodePtr.NextNode;
            }
        }
        public CustomLinkedListString(string strngToInsert)
        {
            if (strngToInsert == null)
            {
                //error. 
            }
            else
            {
                PatchSegment(strngToInsert, _Head);
            }
        }

        public void Insert(string strngToInsert)
        {
            if (strngToInsert == null)
            {
                //error
            }
            else
            {
                MyNode<char> nodePtr = _Head;
                while (nodePtr.NextNode != null) // FIND THE END OF THE LIST
                {
                    nodePtr = nodePtr.NextNode;
                }
                ///////////// NEXT PATCH THE NEW STRING /////////
                PatchSegment(strngToInsert, nodePtr);

            }
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            MyNode<char> nodePtrpPrevious=null
                ;
            if ((startIndex + numCharsToRemove) <= this.Length())
            {
                MyNode<char> nodePtr = _Head;
                for (int i = 0; i < startIndex; i++)                // TRAVERSE TO THE LOCATION "startIndex"
                {
                    nodePtrpPrevious = nodePtr;                     // SAVE THE LOCATION OF REMOVAL POINT
                    nodePtr = nodePtr.NextNode;
                }
                for (int i = 0; i < numCharsToRemove; i++)          // START REMOVING "numCharsToRemove "NODES
                {
                    nodePtr = nodePtr.NextNode;
                }
                nodePtrpPrevious.NextNode = nodePtr;
            }
        }

        public override string ToString()
        {
            MyNode<char> nodePtr = _Head;
            string theStr = _Head.TValue.ToString();
            int theLength = this.Length();
            for (int i = 1; i < theLength; i++)
            {
                theStr += nodePtr.NextNode.TValue.ToString();
                nodePtr = nodePtr.NextNode;
            }
            return theStr;
        }

    }
}
