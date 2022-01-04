using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTresale.Models;

namespace RESTresale.Managers
{
    public class ResaleItemsManagerDB
    {
        private SalesItemContext context;

        public ResaleItemsManagerDB(SalesItemContext context)
        {
            this.context = context;
        }

        public List<ResaleItem> GetAll()
        {
            return context.ResaleItems.ToList();
        }
    }
}
