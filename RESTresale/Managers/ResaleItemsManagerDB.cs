using System.Collections.Generic;
using System.Linq;
using RESTresale.Models;

namespace RESTresale.Managers
{
    public class ResaleItemsManagerDB
    {
        private readonly SalesItemContext _context;

        public ResaleItemsManagerDB(SalesItemContext context)
        {
            _context = context;
        }

        public List<ResaleItem> GetAll()
        {
            return _context.ResaleItems.ToList();
        }

        public ResaleItem GetById(int id)
        {
            return _context.ResaleItems.Find(id);
        }

        public ResaleItem Add(ResaleItem item)
        {
            _context.Add(item);
            _context.SaveChanges(); // don't forget to save
            return item;
        }

    }
}
