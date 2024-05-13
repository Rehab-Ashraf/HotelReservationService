#region Using ...
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Common;
using HotelReservationService.Core.IRepositories;
using HotelReservationService.DataAccess.Contexts;
using HotelReservationService.Entity.Entities;
using Microsoft.EntityFrameworkCore;
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
    public class UsersRepositoryAsync : Base.BaseServiceRepositoryAsync<User, long>, IUsersRepositoryAsync
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance from type
        /// UsersRepositoryAsync.
        /// </summary>
        /// <param name="context"></param>
        public UsersRepositoryAsync(HotelReservationServiceContext context, ICurrentUserService currentUserService)
            : base(context, currentUserService)
        {

        }
        #endregion


        public User Login(string userName)
        {
            return this.Entities.AsQueryable().Include(x => x.Role).FirstOrDefault(x => x.Username == userName &&x.IsDeleted!=true&&x.IsActive==true);
        }

    }
}