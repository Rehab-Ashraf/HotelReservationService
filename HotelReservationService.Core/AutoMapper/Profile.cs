#region Using ...
using HotelReservationService.Core.Models.ViewModels;
using HotelReservationService.Entity.Entities;
using Microsoft.AspNetCore.Builder;

#endregion


namespace HotelReservationService.Core
{
    /* 
	 * See: https://code-maze.com/automapper-net-core/ 
	 */

    /// <summary>
    /// Provides a named configuration for maps. 
    /// Naming conventions become scoped per 
    /// profileStockItem, StockItemListViewModel
    /// </summary>
    public class Profile : AutoMapper.Profile
    {
        #region Properties
        public static IApplicationBuilder ApplicationBuilder { get; set; }
        #endregion


        #region Constructors
        /// <summary>
        /// Initializes a new instance from type 
        /// Profile.
        /// </summary>
        public Profile()
        {
            #region User
            CreateMap<User, UserViewModel>()
               
               .ReverseMap();

            #endregion
        }

        #endregion
    }
}
