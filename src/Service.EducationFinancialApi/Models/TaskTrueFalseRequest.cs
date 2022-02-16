using System.ComponentModel.DataAnnotations;

namespace Service.EducationFinancialApi.Models
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}