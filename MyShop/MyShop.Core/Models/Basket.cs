using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Core.Models
{
    public class Basket : BAseEntity
    {
        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }
    }
}