using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Helpers;

namespace MyLeasing.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random; 

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();     
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("vitorc@gmail.com");

            if(user == null) 
            {
                user = new User
                {
                    Document = "12345678",
                    FirstName = "Vítor",
                    LastName = "Conceição",
                    Address = "Rua lá fora",
                    Email = "vitorc@gmail.com",
                    UserName = "vitorc@gmail.com",
                    PhoneNumber = "123456789",
                };

                var result = await _userHelper.AddUserAsync(user, "123456");

                if(result != IdentityResult.Success) 
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }    


            if (!_context.Owners.Any())
            {
                AddOwner("Vítor Silva", user);
                AddOwner("Marta Almeida", user);
                AddOwner("Tiago Costa", user);
                AddOwner("Manuel Carvalho", user);
                AddOwner("Silvia Pinto", user);
                AddOwner("Vítor Castro", user);
                AddOwner("Daniel Silva", user);
                AddOwner("Teginaldo Naldo", user);
                AddOwner("Michael Jackson", user);
                AddOwner("Ging Liren", user);
                await _context.SaveChangesAsync();
            }

            if(!_context.Lessees.Any())
            {
                AddLessee("Mano", "Vítorr", user);
                AddLessee("Mana", "Telma", user);
                AddLessee("Mano", "Guil", user);
                AddLessee("Mano", "Kuster", user);
                AddLessee("Mana", "Amaral", user);
                await _context.SaveChangesAsync();
            }   
            
        }

        private void AddOwner(string name, User user)
        {
            _context.Owners.Add(new Owner
            {
                Document = _random.Next(99999999).ToString(),
                Name = name,
                User = user
            });
        }

        private void AddLessee(string firstName, string lastName, User user)
        {
            _context.Lessees.Add(new Lessee 
            {
                Document = _random.Next(99999999).ToString(),
                FirstName = firstName, 
                LastName = lastName,      
                User = user     
            });  
        }
    }
}
