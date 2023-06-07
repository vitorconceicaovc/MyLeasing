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
    }
}
