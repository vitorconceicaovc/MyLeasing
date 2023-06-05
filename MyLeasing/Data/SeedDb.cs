using System;
using System.Linq;
using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random; 

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();     
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();   

            if (!_context.Owners.Any())
            {
                AddOwner("Vítor Silva");
                AddOwner("Marta Almeida");
                AddOwner("Tiago Costa");
                AddOwner("Manuel Carvalho");
                AddOwner("Silvia Pinto");
                AddOwner("Vítor Castro");
                AddOwner("Daniel Silva");
                AddOwner("Teginaldo Naldo");
                AddOwner("Michael Jackson");
                AddOwner("Ging Liren");
                await _context.SaveChangesAsync();
            }
        }

        private void AddOwner(string name)
        {
            _context.Owners.Add(new Owner
            {
                Document = _random.Next(99999999).ToString(),
                Name = name
            });
        }
    }
}
