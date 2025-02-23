using _30github.app.Application.Contracts;

namespace _30github.app.Infrastructure.Services
{
    class UserMarketingService : IUserEmailMarketingServiceInterface, IUserSmsMarketingServiceInterface
    {
        public bool SmsMarketingConsent()
        {
            return false;
        }

        public bool EmailMarketingConsent()
        {
            return true;
        }
    }
}
