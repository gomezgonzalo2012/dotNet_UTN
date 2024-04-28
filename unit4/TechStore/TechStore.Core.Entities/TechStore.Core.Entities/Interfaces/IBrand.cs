using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Core.Entities.Interfaces
{
    public interface IBrand
    {
        string Brand { get; set; }

        public string TellBrand()  // default implementation 
        {
            return Brand;
        }
    }
}
