using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace monopoly_framework
{
     internal class PropertySpace : spaces
    {

        internal override void PurchaseProperty(bool Purchase)
        {
            //code here
        }

        internal void SpaceInfo(string name)
        {
           
        }
        internal void SpaceInfo(string name,string age)
        {
            Console.WriteLine($"Hi {name}");
        }

        internal override void SpaceInfo()
        {
            base.SpaceInfo(); //so this method can use the other base method. however we are able to make our own code from it as well

            //this method is better than  the parent's!!! believe it!!!

        }

        internal void SpacetypeAction()
        {
            Console.WriteLine("this is a utility");
        }

    }
}
