#region Using ...
using Framework.Common.Interfaces;
using Framework.Core.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace HotelReservationService.Core.IRepositories.Base
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TEntity"></typeparam>
	/// <typeparam name="TPrimeryKey"></typeparam>
	public interface IBaseServiceRepositoryAsync<TEntity, TPrimeryKey> : IBaseFrameworkRepositoryAsync<TEntity, TPrimeryKey>
		where TEntity : class, IEntityIdentity<TPrimeryKey>
	{

	}
}
