using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationFinancialApi.Controllers.Contracts
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}