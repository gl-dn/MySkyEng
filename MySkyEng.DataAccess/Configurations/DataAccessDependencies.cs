using Microsoft.Extensions.DependencyInjection;
using MySkyEng.DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.DataAccess.Configurations
{
    public static class DataAccessDependencies
    {
        public static void RegisterDataAccessDependencies(this IServiceCollection collection)
        {
            collection.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
