using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Core.Entities
{
    public abstract class Sale
    {
        public virtual float CalcSalePrice(float price)
        {
            return price * (1 + 0.30f); // 30% of profit
        }
    }
}
