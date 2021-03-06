﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite:Component
    {
        private List<Component> children=new List<Component>();
 
        public Composite(String name):base(name)
        {      }

        public override void Add(Component component)
        {
 	        children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+" "+Name);
            foreach (Component component in children)
                component.Display(depth+2);
        }
    }

    
}
