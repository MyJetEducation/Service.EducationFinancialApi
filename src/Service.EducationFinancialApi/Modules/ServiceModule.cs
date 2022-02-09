using Autofac;
using Service.Core.Client.Services;
using Service.TutorialFinancial.Client;
using Service.UserInfo.Crud.Client;
using Service.UserReward.Client;

namespace Service.EducationFinancialApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterUserInfoCrudClient(Program.Settings.UserInfoCrudServiceUrl);
			builder.RegisterTutorialFinancialClient(Program.Settings.TutorialFinancialServiceUrl);
			builder.RegisterUserRewardClient(Program.Settings.UserRewardServiceUrl);

			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();

			builder.Register(context => new EncoderDecoder(Program.EncodingKey))
				.As<IEncoderDecoder>()
				.SingleInstance();
		}
	}
}