using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Services
{
    public class SellersService
    {
        private readonly SalesWebMvcContext _context;

        public SellersService(SalesWebMvcContext context)
        {
            _context = context;
        }
        
        public List<Sellers> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Sellers obj)
        {
            obj.Departament = _context.Departament.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Sellers FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
