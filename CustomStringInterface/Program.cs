using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    class Program
    {
        static void Main(string[] args)
        {
/////////////////////////////////////////////////////////////////////////
            //////////////////  TEST THE sYSTEM "string" CLASS//////////
            ////////////////////////////////////////////////////////////
            SystemString myString = new SystemString("This is the SYSTEM \"string\".");
            Console.WriteLine(myString);
            Console.ReadLine();
            myString.Insert("Add More to this is it");
            Console.WriteLine(myString);
            Console.ReadLine();
            myString.Remove(39, 8);         //AT POSITION 39 REMOVE 4 CHARATERS
            Console.WriteLine(myString);
            Console.ReadLine();
            ////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////
            /////////////////// TEST THE CUSTOM LINKEDLISTSTRING ///////
            ////////////////////////////////////////////////////////////
            CustomLinkedListString myLinkedString = new CustomLinkedListString("This is char Custom string linked listed.");
            Console.WriteLine(myLinkedString.ToString());
                    ////////  TEST THE "INSERT" METHOD ///////////////
            myLinkedString.Insert(" Just added some more.");
            Console.WriteLine(myLinkedString.ToString());
            Console.ReadLine();
            myLinkedString.Remove(39, 8);         //AT POSITION 39 REMOVE 4 CHARATERS
            Console.WriteLine(myLinkedString);
            Console.ReadLine();
////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////
            //////////////// TEST THE SYSTEM "LinkedList" ///////////
            ////////////////////////////////////////////////////////////
            SystemLinkedListString MySysLinkedLIst = new SystemLinkedListString(" This is a char System \"LinkedList\".");
            Console.WriteLine(MySysLinkedLIst.ToString());
            MySysLinkedLIst.Insert(" Adding to the linked list");
            Console.WriteLine(MySysLinkedLIst.ToString());
            MySysLinkedLIst.Remove(4, 3);
            Console.WriteLine(MySysLinkedLIst.ToString());
            Console.ReadLine();
            ////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////
            //////////////// TEST THE SYSTEM "ARRAY List" ///////////
            ////////////////////////////////////////////////////////////
            SystemArrayString MySysArrayList = new SystemArrayString("This is an array list.");
            Console.WriteLine(MySysArrayList.ToString());
            MySysArrayList.Insert(" Adding to the Array");
            Console.WriteLine(MySysArrayList.ToString());
            MySysArrayList.Remove(12, 3);
            Console.WriteLine(MySysArrayList.ToString());

            Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////

            //System.Collections.SortedList SysColSL = new System.Collections.SortedList();

            //System.Collections.SortedList<ICustomString> SysSLICustomS = new System.Collections.SortedList<ICustomString>();

        }
    }
}
