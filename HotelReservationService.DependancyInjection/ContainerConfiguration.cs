#region Using ...
using Framework.Core.Common;
using Framework.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotelReservationService.Business.Common;
using HotelReservationService.Business.Services;
using HotelReservationService.BusinessLogic.Common;
using HotelReservationService.Core.IRepositories;
using HotelReservationService.Core.IServices;
using HotelReservationService.Core.Common;
using HotelReservationService.DataAccess.Contexts;
using HotelReservationService.DataAccess.Repositories;

#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace HotelReservationService.DependancyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public class ContainerConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();

            #region Register AutoMapper
            services.AddAutoMapper(typeof(Core.Profile).Assembly);
            #endregion

            services.AddHttpContextAccessor();

            services.AddScoped<ILoggerService, LoggerService>();

            #region Add Db Context
            services.AddDbContext<HotelReservationServiceContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString:HotelReservationServiceConnection"], b => b.MigrationsAssembly("HotelReservationService.DataAccess"));
            });
            #endregion

            #region Register HotelReservationServiceContext
            services.AddScoped<HotelReservationServiceContext, HotelReservationServiceContext>();
            #endregion

            #region Register Repositories
            services.AddScoped<IUsersRepositoryAsync, UsersRepositoryAsync>();
            services.AddScoped<IRolePermissionsRepositoryAsync, RolePermissionsRepositoryAsync>();
            services.AddScoped<IRolesRepositoryAsync, RolesRepositoryAsync>();
            services.AddScoped<IPermissionsRepositoryAsync, PermissionsRepositoryAsync>();
            services.AddScoped<IReservationRepositoryAsync, ReservationRepositoryAsync>();
            services.AddScoped<IRoomRepositoryAsync, RoomRepositoryAsync>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkAsync, UnitOfWorkAsync>();

            #endregion

            #region Register Services
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IJwtService, JwtService>();
            #endregion
        }
        public static void ConfigurePublic(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();

            #region Register AutoMapper
            services.AddAutoMapper(typeof(Core.Profile).Assembly);
            #endregion

            services.AddHttpContextAccessor();

            services.AddScoped<ILoggerService, LoggerService>();

            #region Add Db Context
            services.AddDbContext<HotelReservationServiceContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString:HotelReservationServiceConnection"], b => b.MigrationsAssembly("HotelReservationService.DataAccess"));
            });
            #endregion

            #region Register HotelReservationServiceContext
            services.AddScoped<HotelReservationServiceContext, HotelReservationServiceContext>();
            #endregion

            #region Register Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkAsync, UnitOfWorkAsync>();
            #endregion
        }
    }
}