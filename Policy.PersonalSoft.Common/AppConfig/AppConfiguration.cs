using Microsoft.Extensions.Configuration;

namespace Policy.PersonalSoft.Common.AppConfig
{
    public class AppConfiguration
    {
        public static IConfiguration Configuration { get; set; }

        static AppConfiguration()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }
    }
}
