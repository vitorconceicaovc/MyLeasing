using System.Collections.Generic;
using System.Threading.Tasks;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    public class MockRepository : IRepository
    {
        public void AddOwner(Owner owner)
        {
            throw new System.NotImplementedException();
        }

        public Owner GetOwner(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Owner> GetOwners()
        {
            var owners = new List<Owner>();
            owners.Add(new Owner { Id = 1, Name = "Um", Document = "10" });
            owners.Add(new Owner { Id = 2, Name = "Dois", Document = "20" });
            owners.Add(new Owner { Id = 3, Name = "Tres", Document = "30" });
            owners.Add(new Owner { Id = 4, Name = "Quatro", Document = "40" });
            owners.Add(new Owner { Id = 5, Name = "Cinco", Document = "50" });

            return owners;
        }

        public bool OwnerExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveOwner(Owner owner)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdaterOwner(Owner owner)
        {
            throw new System.NotImplementedException();
        }
    }
}
