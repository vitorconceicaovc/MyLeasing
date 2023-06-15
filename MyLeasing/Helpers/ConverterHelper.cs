using System;
using System.IO;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

namespace MyLeasing.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Owner ToOwner(OwnerViewModel model, Guid imageId, bool isNew)
        {
            return new Owner
            {
                Id = isNew ? 0 : model.Id,
                Document = model.Document,
                Name = model.Name,
                ImageId = imageId,
                CellPhone = model.CellPhone,
                FixedPhone = model.FixedPhone,
                Address = model.Address,
                User = model.User
            };
        }

        public Lessee ToLessee(LesseeViewModel model, Guid imageId, bool isNew)
        {
            return new Lessee
            {
                Id = isNew ? 0 : model.Id,
                Document = model.Document,
                FirstName = model.FirstName,
                LastName = model.LastName,  
                ImageId = imageId,
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
                ImageId = owner.ImageId,
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
                ImageId = lessee.ImageId,
                CellPhone = lessee.CellPhone,
                FixedPhone = lessee.FixedPhone,
                Address = lessee.Address,
                User = lessee.User
            };
        }

        
    }
}
