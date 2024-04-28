using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Core.Entities
{
    public class SmartPhone : Device
    {
        

        public SmartPhone() { }

        public SmartPhone( float price) : base(price) { } // uses the inherit constructor

        // override from Device

        public override string Revision()
        {
            return $"SmartPhone {base.Revision()}";
        }

        
    }
}
