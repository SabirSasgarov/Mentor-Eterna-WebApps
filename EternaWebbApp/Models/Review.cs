using EternaWebbApp.Models.Common;

namespace EternaWebbApp.Models
{
	public class Review : BaseEntity
	{
		public decimal StarCount { get; set; }
		public string Comment { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
