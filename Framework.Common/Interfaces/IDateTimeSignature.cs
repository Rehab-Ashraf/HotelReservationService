#region Using ...
using System;
using System.Collections.Generic;
using System.Text;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace Framework.Common.Interfaces
{
	/// <summary>
	/// 
	/// </summary>
	public interface IDateTimeSignature : ICreationTimeSignature
	{
		#region Properties
		DateTime? FirstModificationDate { get; set; }
		DateTime? LastModificationDate { get; set; }
		#endregion
	}
}
