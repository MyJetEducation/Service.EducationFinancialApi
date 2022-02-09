using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationFinancialApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationFinancialApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationFinancialApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationFinancialApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationFinancialApi.UserInfoCrudServiceUrl")]
		public string UserInfoCrudServiceUrl { get; set; }

		[YamlProperty("EducationFinancialApi.TutorialFinancialServiceUrl")]
		public string TutorialFinancialServiceUrl { get; set; }

		[YamlProperty("EducationFinancialApi.JwtAudience")]
		public string JwtAudience { get; set; }

		[YamlProperty("EducationFinancialApi.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }
	}
}