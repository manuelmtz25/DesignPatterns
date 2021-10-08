using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Repository
{
    public class BeerRepository:IBeerRepository
    {
        private beerDBContext _context;

        public BeerRepository(beerDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Beer> Get()
        {
            return _context.Beers.ToList();
        }

        public Beer Get(int id)
        {
            return _context.Beers.Find(id);
        }

        public void Add(Beer data)
        {
            _context.Beers.Add(data);
        }

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public void Update(Beer data)
        {
            _context.Entry(data).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
