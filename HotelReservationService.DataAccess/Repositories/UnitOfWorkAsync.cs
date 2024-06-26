#region Using ...
using Framework.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HotelReservationService.Core.IRepositories;
using HotelReservationService.DataAccess.Contexts;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace HotelReservationService.DataAccess.Repositories
{
	/// <summary>
	/// 
	/// </summary>
	public class UnitOfWorkAsync : IUnitOfWorkAsync
	{
		#region Data Members
		private HotelReservationServiceContext _context;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance from type 
		/// UnitOfWorkAsync.
		/// </summary>
		/// <param name="context"></param>
		public UnitOfWorkAsync(HotelReservationServiceContext context)
		{
			this._context = context;
		}
		#endregion

		#region IUnitOfWork	
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<int> CommitAsync()
		{
			var result = await this._context.SaveChangesAsync();
			return result;
		}
		#endregion
	}
}
