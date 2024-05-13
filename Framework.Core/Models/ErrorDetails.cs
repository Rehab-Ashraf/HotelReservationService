#region Using ...
using System;
using System.Collections.Generic;
using System.Text;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace Framework.Core.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class ErrorDetails
	{
		#region Methods
		public override string ToString()
		{
			return (ErrorCode == 0) ? $"{this.StatusCode}, {Message}" : ErrorCode.ToString();
		}
		#endregion

		#region Properties
		public int StatusCode { get; set; }
		public string Message { get; set; }
		public int ErrorCode { get; set; }
		#endregion
	}
}