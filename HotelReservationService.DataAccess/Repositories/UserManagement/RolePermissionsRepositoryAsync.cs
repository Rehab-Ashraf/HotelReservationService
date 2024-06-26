#region Using ...
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Framework.Core.Common;
using HotelReservationService.Core.IRepositories;
using HotelReservationService.DataAccess.Contexts;
using HotelReservationService.Entity.Entities;
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
    public class RolePermissionsRepositoryAsync : Base.BaseServiceRepositoryAsync<RolePermission, long>, IRolePermissionsRepositoryAsync
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance from type
        /// RolePermissionsRepositoryAsync.
        /// </summary>
        /// <param name="context"></param>
        public RolePermissionsRepositoryAsync(HotelReservationServiceContext context, ICurrentUserService currentUserService)
            : base(context, currentUserService)
        {

        }
        #endregion
    }
}
