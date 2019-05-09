using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myproject.Infraestructure.Mapper;

namespace Myproject.Infraestructure.Service
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddCustomApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper();
            services.AddOptions();
            services.Configure<AppSettings>(configuration);
            return services;
        }

        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            #region MAPPER
            services.AddScoped<Parser, Parser>();
            #endregion

            #region GATEWAYS
            //services.AddScoped<ICalendarioSEPPGateway, CalendarioSEPPGateway>();

            #endregion

            #region USE CASES
            //services.AddScoped<ICalendarioPlanillasSEPPUseCase, CalendarioPlanillasSEPPUseCase>();

            #endregion

            #region REPOSITORIES
            //services.AddScoped<ICalendarioPlanillasSEPPRepository, CalendarioPlanillasSEPPRepository>();

            #endregion

            #region DATASOURCE
            /* services.AddScoped<ICalendarioPlanillasSEPPDataSource>(sp =>
             {
                 var passwd = services.BuildServiceProvider()
                 .GetRequiredService<IOptions<AppSettings>>().Value.PasswordBD;
                 var user = services.BuildServiceProvider()
                     .GetRequiredService<IOptions<AppSettings>>().Value.UserBD;

                 var sqlServerConnection = services.BuildServiceProvider()
                                .GetRequiredService<IOptions<AppSettings>>().Value
                                .ConnectionStrings.SqlServerConnection;

                 sqlServerConnection = sqlServerConnection.Replace("{PasswordBD}", passwd).Replace("{UserBD}", user);
                 // return new SqlServerDataSource(services.BuildServiceProvider().GetService<SqlServerDbContext>(), sqlServerConnection);
                 return new CalendarioPlanillasSEPPDataSource(sqlServerConnection);
             });

             services.AddScoped<ICalendarioOmisionesInconsistenciasDataSource>(sp =>
             {
                 var passwd = services.BuildServiceProvider()
                 .GetRequiredService<IOptions<AppSettings>>().Value.PasswordBD;
                 var user = services.BuildServiceProvider()
                     .GetRequiredService<IOptions<AppSettings>>().Value.UserBD;

                 var sqlServerConnection = services.BuildServiceProvider()
                                .GetRequiredService<IOptions<AppSettings>>().Value
                                .ConnectionStrings.SqlServerConnection;
                 sqlServerConnection = sqlServerConnection.Replace("{PasswordBD}", passwd).Replace("{UserBD}", user);

                 return new CalendarioOmisionesInconsistenciasDataSource(sqlServerConnection);
             });

             services.AddScoped<ITipoCalendarioDataSource>(sp =>
             {
                 var passwd = services.BuildServiceProvider()
                 .GetRequiredService<IOptions<AppSettings>>().Value.PasswordBD;
                 var user = services.BuildServiceProvider()
                     .GetRequiredService<IOptions<AppSettings>>().Value.UserBD;

                 var sqlServerConnection = services.BuildServiceProvider()
                                .GetRequiredService<IOptions<AppSettings>>().Value
                                .ConnectionStrings.SqlServerConnection;
                 sqlServerConnection = sqlServerConnection.Replace("{PasswordBD}", passwd).Replace("{UserBD}", user);

                 return new TipoCalendarioDataSource(sqlServerConnection);
             });

             services.AddScoped<ICalendarioInsuficienciasDataSource>(sp =>
             {
                 var passwd = services.BuildServiceProvider()
                 .GetRequiredService<IOptions<AppSettings>>().Value.PasswordBD;
                 var user = services.BuildServiceProvider()
                     .GetRequiredService<IOptions<AppSettings>>().Value.UserBD;

                 var sqlServerConnection = services.BuildServiceProvider()
                                .GetRequiredService<IOptions<AppSettings>>().Value
                                .ConnectionStrings.SqlServerConnection;
                 sqlServerConnection = sqlServerConnection.Replace("{PasswordBD}", passwd).Replace("{UserBD}", user);

                 return new CalendarioInsuficienciasDataSource(sqlServerConnection);
             });
             */

             #endregion

            return services;
        }

        /*public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            //var sqlServerConnection = services.BuildServiceProvider()
            //    .GetRequiredService<IOptions<AppSettings>>().Value
            //    .ConnectionStrings.SqlServerConnection;
            //services.AddDbContext<SqlServerDbContext>(options => options.UseSqlServer(sqlServerConnection));
            return services;
        }*/
    }
}