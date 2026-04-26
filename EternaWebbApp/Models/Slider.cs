using EternaWebbApp.Models.Common;

namespace EternaWebbApp.Models
{
	public class Slider : BaseEntity
	{
		public string Name { get; set; }
		public string SubTitle { get; set; }
		public string ButtonText { get; set; }
		public string ButtonLink { get; set; }
		public string ImageUrl { get; set; }
	}
}
