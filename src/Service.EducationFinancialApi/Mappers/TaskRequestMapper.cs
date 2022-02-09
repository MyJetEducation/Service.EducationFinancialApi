using System;
using System.Linq;
using Service.EducationFinancialApi.Models;
using Service.TutorialFinancial.Grpc.Models;

namespace Service.EducationFinancialApi.Mappers
{
	public static class TaskRequestMapper
	{
		public static FinancialTaskTextGrpcRequest ToGrpcModel(this TaskTextRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskTextGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static FinancialTaskTestGrpcRequest ToGrpcModel(this TaskTestRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskTestGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new FinancialTaskTestAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static FinancialTaskVideoGrpcRequest ToGrpcModel(this TaskVideoRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskVideoGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static FinancialTaskCaseGrpcRequest ToGrpcModel(this TaskCaseRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskCaseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Value = model.Value
		};

		public static FinancialTaskTrueFalseGrpcRequest ToGrpcModel(this TaskTrueFalseRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskTrueFalseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new FinancialTaskTrueFalseAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static FinancialTaskGameGrpcRequest ToGrpcModel(this TaskGameRequest model, Guid? userId, TimeSpan duration) => new FinancialTaskGameGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Passed = model.Passed
		};
	}
}