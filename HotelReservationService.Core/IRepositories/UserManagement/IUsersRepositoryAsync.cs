#region Using ...
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationService.Entity.Entities;
#endregion

/*
* Generated by: CodeGenerator Version 1.0.0.0
* Generated for: SmarttechSys
*/
namespace HotelReservationService.Core.IRepositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUsersRepositoryAsync : Base.IBaseServiceRepositoryAsync<User, long>
    {
        User Login(string userName);
    }
}
