using System.ComponentModel.DataAnnotations;

namespace Service.EducationFinancialApi.Models
{
	public class TaskGameRequest: TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}