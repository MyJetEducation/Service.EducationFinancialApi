using System.Collections.Generic;

namespace Service.EducationFinancialApi.Models
{
	public class TutorialStateResponse
	{
		public bool Available { get; set; }

		public IEnumerable<TutorialStateUnit> Units { get; set; }

		public TotalProgressResponse TotalProgress { get; set; }
	}
}