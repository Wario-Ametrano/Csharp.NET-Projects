using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SerilogConsole
{
    public class AdminServices : IAdminServices
    {
        private readonly ILogger<AdminServices> logger;
        private readonly IConfiguration config;

        public AdminServices(ILogger<AdminServices> logger, IConfiguration config) // DI
        {
            this.logger = logger;
            this.config = config;
        }
        public void Run()
        {
            for (int i = 0; i < config.GetValue<int>("LoopTimes"); i++)
            {
                logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
