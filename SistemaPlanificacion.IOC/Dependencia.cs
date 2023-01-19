using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SistemaPlanificacion.DAL.DBContext;
using SistemaPlanificacion.DAL.Interfaces;
using SistemaPlanificacion.DAL.Implementacion;
using SistemaPlanificacion.BLL.Interfaces;
using SistemaPlanificacion.BLL.Implementacion;
using Microsoft.Extensions.Options;

namespace SistemaPlanificacion.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BasePlanificacionContext>(Options =>
            {
                Options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
