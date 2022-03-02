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

		[YamlProperty("EducationFinancialApi.TutorialFinancialServiceUrl")]
		public string TutorialFinancialServiceUrl { get; set; }
	}
}