﻿using System;
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
            list.AddAtStart("Mohammed");
            list.AddAtStart("Cat");
            list.AddAtStart("Shaun");
            list.AddToEnd("Cat");
            list.AddToEnd("Jaide");            

            list.PrintAllNodes();         
                                               
            list.RemoveAll("Cat");               
            
            list.PrintAllNodes();           

        }
    }
}
