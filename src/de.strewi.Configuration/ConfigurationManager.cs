using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace de.strewi.Configuration
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;

        private IConfiguration configuration;

        private ConfigurationManager()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            configuration = configurationBuilder.Build();
        }

        public string SearchApiName
        {
            get
            {
                return configuration.GetValue<string>("Search:ApiName", "");
            }
        }

        public string SearchSecretKey
        {
            get
            {
                return configuration.GetValue<string>("Search:SecretKey", "");
            }
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }

                return instance;
            }
        }
    }
}
