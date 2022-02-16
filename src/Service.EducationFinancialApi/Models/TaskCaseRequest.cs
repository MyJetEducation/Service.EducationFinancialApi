using System.ComponentModel.DataAnnotations;

namespace Service.EducationFinancialApi.Models
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}