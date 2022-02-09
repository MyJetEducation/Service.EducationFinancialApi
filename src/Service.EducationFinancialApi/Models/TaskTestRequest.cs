using System.ComponentModel.DataAnnotations;

namespace Service.EducationFinancialApi.Models
{
	public class TaskTestRequest: TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}