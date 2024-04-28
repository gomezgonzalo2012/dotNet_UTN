using TechStore.Core.Entities.Interfaces;

namespace TechStore.Core.Entities
{
    public abstract class Device : Sale, IDeviceWithPriceAndID  , IExpiration, IBrand
    {
        public string Id { get; set; }

        private float _buyPrice;
        public float Price { get
            {
                return CalcSalePrice(_buyPrice);
            }
            

        }
        public bool IsNew { get; set; }

        // implement from IBrand
        public string Brand {  get; set; }
        public DateOnly Created { get; set; }

        public virtual string Revision()
        {
            return "in revision...";
        }
        // Override from Sale inheritance
        public override float CalcSalePrice(float price)
        {
            return base.CalcSalePrice(price);
        }

        // implementacion from IExpiration
        public DateOnly ExpirationDate()
        {
            {
                return Created.AddYears(2);
            }
        }

        public Device() { }

        public Device (float price)
        {
            _buyPrice = price;
        }
    }
}
