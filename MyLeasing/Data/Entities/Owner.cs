using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
	public class Owner : IEntity
	{
		public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string Document { get; set; }

		[Required]
		[MaxLength(50)]	
		[Display(Name = "Owner Name")]
		public string Name { get; set; }

		[Display(Name = "Fixed Phone")]
		public string FixedPhone { get; set; }

		[Display(Name = "Cell Phone")]
		public string CellPhone { get; set; }		

		public string Address { get; set; }

		
	}
}