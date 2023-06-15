using System;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public Guid ImageId { get; set; }

        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Address { get; set; }

        public string ImageFullPath => ImageId == Guid.Empty ? $"https://myleasingwebtpsivc.azurewebsites.net/images/noimage.jpg" : $"https://myleasingwebtpsivc.blob.core.windows.net/owners/{ImageId}";

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Full Name With Document")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public User User { get; set; }
    }
}
