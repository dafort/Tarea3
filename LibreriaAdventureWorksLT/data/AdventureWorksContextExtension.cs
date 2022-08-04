using AdventureWorksNS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksNS.data
{
    public static class AdventureWorksContextExtension
    {
        public static IServiceCollection AdventureWorksDBContext(
          this IServiceCollection services,
          string strCnx = "Data Source=LAPTOP-6LPNIOV7;Initial Catalog=AdventureWorksLT2019;Integrated Security=false;User=sa;Password=Daniel18;")
        {
            services.AddDbContext<AdventureWorksDB>(options => options.UseSqlServer(strCnx));
            return services;
        }

    }
}
