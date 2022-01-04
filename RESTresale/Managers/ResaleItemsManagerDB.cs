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

        public int Add(ResaleItem item)
        {
            _context.Add(item);
            _context.SaveChanges(); // don't forget to save
            int newId = item.Id;
            // car.Id us updated by the database: id int identity(1,1)
            return newId;
        }

    }
}
