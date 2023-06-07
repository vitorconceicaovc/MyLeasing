using System.IO;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Owner ToOwner(OwnerViewModel model, string path, bool isNew)
        {
            return new Owner
            {
                Id = isNew ? 0 : model.Id,
                Document = model.Document,
                Name = model.Name,
                ImageUrl = path,
                CellPhone = model.CellPhone,
                FixedPhone = model.FixedPhone,
                Address = model.Address,
                User = model.User
            };
        }

        public Lessee ToLessee(LesseeViewModel model, string path, bool isNew)
        {
            return new Lessee
            {
                Id = isNew ? 0 : model.Id,
                Document = model.Document,
                FirstName = model.FirstName,
                LastName = model.LastName,  
                ImageUrl = path,
                CellPhone = model.CellPhone,
                FixedPhone = model.FixedPhone,
                Address = model.Address,
                User = model.User
            };
        }

        public OwnerViewModel ToOwnerViewModel(Owner owner)
        {
            return new OwnerViewModel
            {
                Id = owner.Id,
                Document = owner.Document,
                Name = owner.Name,
                ImageUrl = owner.ImageUrl,
                CellPhone = owner.CellPhone,
                FixedPhone = owner.FixedPhone,
                Address = owner.Address,
                User = owner.User
            };
        }

        public LesseeViewModel ToLesseeViewModel(Lessee lessee)
        {
            return new LesseeViewModel
            {
                Id = lessee.Id,
                Document = lessee.Document,
                FirstName = lessee.FirstName,
                LastName = lessee.LastName,
                ImageUrl = lessee.ImageUrl,
                CellPhone = lessee.CellPhone,
                FixedPhone = lessee.FixedPhone,
                Address = lessee.Address,
                User = lessee.User
            };
        }
    }
}
