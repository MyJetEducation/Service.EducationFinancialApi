using System.Collections.Generic;

namespace Service.EducationFinancialApi.Models
{
	public class TutorialStateUnit
	{
		public int Unit { get; set; }

		public int TestScore { get; set; }

		public IEnumerable<TutorialStateTask> Tasks { get; set; }
	}
}