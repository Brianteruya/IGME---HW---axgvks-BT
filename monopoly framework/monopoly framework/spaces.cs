using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly_framework
{
    internal abstract class spaces //cant create it, but can make instances of it
    {
        //NOTE: all variables in internal classes default as private
        protected string SpaceName = "";
        protected bool Purchase; //true of false: can you buy it? does someone own this property?
        protected int SpaceValue; //
        protected int Price; //cost



        spaces(string spacename, int purchasePrice)
        {
            this.SpaceName = spacename;
            this.Price = purchasePrice;
        }

        spaces(string spaceName, bool purchase, int spaceValue, int purchasePrice) : this(spaceName, purchasePrice)
        {
            SpaceValue = spaceValue;
            Purchase = purchase;

        }
        protected bool Purchased
        {
            get { return Purchased; }//the getter (cannot be changed
            set { Purchased = Purchase; }//an if statement to ensure if number is > 0 and < 100000
        }

        protected int spaceValue
        {
            get 
            { 
                return SpaceValue; 
            
            }

            set
            {
               
                if (SpaceValue > 0 && SpaceValue < 100000)
                {
                    SpaceValue = value;
                }
            } //the setter (cannot be changed)

        }
        internal virtual void SpaceInfo(string name)
        {
            SpaceName = name;

            Console.WriteLine("----------------Space info----------------");

            if (SpaceName == "b")
            {
                SpaceName = "c";
            }
        }

        internal virtual void PurchaseProperty(bool canPurchase)
        {
            
        }


        //Coding PROPERTY Getters and SETTERS
       

    }

}
