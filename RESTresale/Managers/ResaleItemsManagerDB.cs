using System;
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
            return _context.ResaleItems.OrderByDescending(x => x.Id).ToList();
        }

        public ResaleItem GetById(int id)
        {
            return _context.ResaleItems.Find(id);
        }

        public ResaleItem Add(ResaleItem item)
        {
            item.Id = null;
            _context.ResaleItems.Add(item);
            _context.SaveChanges(); // don't forget to save
            return item;
        }

        internal void Delete(int id)
        {
            ResaleItem item = new ResaleItem() { Id = id };
            _context.ResaleItems.Attach(item);
            _context.ResaleItems.Remove(item);
            _context.SaveChanges();
        }
    }
}
