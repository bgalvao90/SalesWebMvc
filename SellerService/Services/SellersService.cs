﻿using SalesWebMvc.Data;
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
    }
}
