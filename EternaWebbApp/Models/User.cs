using EternaWebbApp.Models.Common;

namespace EternaWebbApp.Models
{
	public class User : BaseEntity
	{
		public string FullName { get; set; }
		public string ImageUrl { get; set; }
		public string Position { get; set; }
		public List<Review> Reviews { get; set; }
	}
}
