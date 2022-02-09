﻿using System.Linq;
using Service.EducationFinancialApi.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using Enum = System.Enum;

namespace Service.EducationFinancialApi.Mappers
{
	public static class TutorialStateMapper
	{
		public static TestScoreResponse ToModel(this TestScoreGrpcResponse response) => response != null
			? new TestScoreResponse
			{
				IsSuccess = response.IsSuccess,
				Unit = response.Unit?.ToModel()
			}
			: null;

		public static TutorialStateResponse ToModel(this FinancialStateGrpcResponse response) => response != null
			? new TutorialStateResponse
			{
				Available = response.Available,
				Units = response.Units?.Select(unit => unit.ToModel()),
				TotalProgress = response.TotalProgress.ToModel()
			}
			: null;

		public static FinishUnitResponse ToModel(this FinishUnitGrpcResponse grpcResponse) => grpcResponse != null
			? new FinishUnitResponse
			{
				Unit = grpcResponse.Unit?.ToModel(),
				TrueFalseProgress = grpcResponse.TrueFalseProgress,
				CaseProgress = grpcResponse.CaseProgress
			}
			: null;

		private static TotalProgressResponse ToModel(this TotalProgressStateGrpcModel grpcModel) => grpcModel != null
			? new TotalProgressResponse
			{
				Habit = grpcModel.Habit.ToModel(),
				Skill = grpcModel.Skill.ToModel(),
				Achievements = grpcModel.Achievements?.Select(Enum.GetName).ToArray()
			}
			: null;

		private static TotalProgressItemResponse ToModel(this ProgressItemInfoGrpcModel grpcModel) => grpcModel != null
			? new TotalProgressItemResponse
			{
				Index = grpcModel.Index,
				Count = grpcModel.Count,
				Progress = grpcModel.Progress
			}
			: null;

		private static TutorialStateUnit ToModel(this FinancialStateUnitGrpcModel grpcModel) => grpcModel != null
			? new TutorialStateUnit
			{
				Unit = grpcModel.Unit,
				TestScore = grpcModel.TestScore,
				Tasks = grpcModel.Tasks?.Select(task => task.ToModel())
			}
			: null;

		private static TutorialStateTask ToModel(this FinancialStateTaskGrpcModel grpcModel) => grpcModel != null
			? new TutorialStateTask
			{
				Task = grpcModel.Task,
				TestScore = grpcModel.TestScore,
				Retry = grpcModel.RetryInfo.ToModel()
			}
			: null;

		private static RetryInfo ToModel(this TaskRetryInfoGrpcModel grpcModel) => grpcModel != null
			? new RetryInfo
			{
				InRetry = grpcModel.InRetry,
				CanRetryByCount = grpcModel.CanRetryByCount,
				CanRetryByTime = grpcModel.CanRetryByTime
			}
			: null;
	}
}