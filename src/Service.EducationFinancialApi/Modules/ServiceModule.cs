using Autofac;
using Service.Core.Client.Services;
using Service.TutorialFinancial.Client;

namespace Service.EducationFinancialApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterTutorialFinancialClient(Program.Settings.EducationFlowServiceUrl);

			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();

			builder.Register(context => new EncoderDecoder(Program.EncodingKey))
				.As<IEncoderDecoder>()
				.SingleInstance();
		}
	}
}