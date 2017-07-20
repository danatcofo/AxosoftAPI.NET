using System;
using System.ComponentModel;

namespace AxosoftAPI.NET
{
	public enum TokenTypeEnum
	{
		[Description("OAuth")]
		OAuth,
		[Description("Bearer")]
		Bearer
	}
}
