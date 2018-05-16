using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_1
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Cat");
            list.AddToEnd("Danny");
            list.AddToEnd("Jaide");            

            list.PrintAllNodes();         
                                               
            list.RemoveAll("Cat");               
            
            list.PrintAllNodes();           

        }
    }
}
