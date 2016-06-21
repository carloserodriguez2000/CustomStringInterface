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

            //////////////////  TEST THE sYSTEMSTRING CLASS//////////
            SystemString myString = new SystemString("This is it");
            Console.WriteLine(myString);
            Console.ReadLine();
            ////////////////////////////////////////////////////////

            /////////////////// TEST THE SYSTEMLINKEDLISTSTRING ///////
            SystemLinkedListString myLinkedString = new SystemLinkedListString("This is char string linked listed.");
            Console.WriteLine(myLinkedString.ToString());
            /////////////////  TEST THE "INSERT" METHOD ///////////////
            myLinkedString.Insert(" Just added some more.");
            Console.WriteLine(myLinkedString.ToString());
            Console.ReadLine();
            ///////////////////////////////////////////////////////
            //System.Collections.SortedList SysColSL = new System.Collections.SortedList();

            //System.Collections.SortedList<ICustomString> SysSLICustomS = new System.Collections.SortedList<ICustomString>();

        }
    }
}
