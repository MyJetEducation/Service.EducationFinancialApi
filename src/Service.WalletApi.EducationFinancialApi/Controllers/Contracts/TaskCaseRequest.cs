using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationFinancialApi.Controllers.Contracts
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}