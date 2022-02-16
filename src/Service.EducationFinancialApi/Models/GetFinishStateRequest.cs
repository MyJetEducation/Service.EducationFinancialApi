﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.EducationFinancialApi.Models
{
	public class GetFinishStateRequest
	{
		[Range(1, 5)]
		[DefaultValue(1)]
		public int? Unit { get; set; }
	}
}