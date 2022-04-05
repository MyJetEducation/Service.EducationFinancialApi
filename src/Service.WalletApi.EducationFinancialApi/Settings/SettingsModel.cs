using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationFinancialApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationFinancialApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationFinancialApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationFinancialApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationFinancialApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("EducationFinancialApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationFinancialApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationFinancialApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("EducationFinancialApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationFinancialApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}