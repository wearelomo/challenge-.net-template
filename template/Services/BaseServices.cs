using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lomo_Template.Services
{
    public class BaseServices
    {

        protected IConfiguration _Config { get; private set; }

        public BaseServices(IConfiguration config)
        {
            _Config = config;
        }

        /// <summary>
        /// Gets the connectionString from the config file.
        /// </summary>
        /// <returns>Connection String</returns>
        protected string GetConnectionString()
        {
            return _Config.GetConnectionString("DefaultConnection");
        }
    }
}
