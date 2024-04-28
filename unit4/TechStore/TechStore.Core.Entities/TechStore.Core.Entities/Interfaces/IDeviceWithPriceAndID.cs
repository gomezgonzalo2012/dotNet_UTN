using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Core.Entities.Interfaces
{
    public interface IDeviceWithPriceAndID
    {
        public string Id {  get; set; }
        public float Price { get; }
    }
}
