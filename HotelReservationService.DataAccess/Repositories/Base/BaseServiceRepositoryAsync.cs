#region Using ...
using Framework.Common.Interfaces;
using Framework.Core.Common;
using Framework.DataAccess.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using HotelReservationService.Core.IRepositories.Base;
using HotelReservationService.DataAccess.Contexts;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace HotelReservationService.DataAccess.Repositories.Base
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TEntity"></typeparam>
	/// <typeparam name="TPrimeryKey"></typeparam>
	public class BaseServiceRepositoryAsync<TEntity, TPrimeryKey> : BaseFrameworkRepositoryAsync<TEntity, TPrimeryKey>,
		IBaseServiceRepositoryAsync<TEntity, TPrimeryKey>
		where TEntity : class, IEntityIdentity<TPrimeryKey>
	{
		#region Data Members
		private HotelReservationServiceContext _HotelReservationContext;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance from type 
		/// BaseServiceRepositoryAsync.
		/// </summary>
		/// <param name="context"></param>
		public BaseServiceRepositoryAsync(HotelReservationServiceContext context, ICurrentUserService currentUserService)
			: base(context, currentUserService)
		{
			this.HotelReservationContext = context;
		}
		#endregion

		#region Properties
		protected HotelReservationServiceContext HotelReservationContext
		{
			get { return this._HotelReservationContext; }
			private set { this._HotelReservationContext = value; }
		}
		#endregion
	}
}