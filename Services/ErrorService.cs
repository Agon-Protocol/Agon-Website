using System.Runtime.CompilerServices;

namespace Agon.Website.Services
{
    public class ErrorService
    {
        private readonly ILoggerFactory _loggerFactory;

        public ErrorService(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void ProcessError(Exception ex, [CallerMemberName] string categoryName = "ErrorService")
        {
            ILogger logger = _loggerFactory.CreateLogger(categoryName);
            logger.LogError("Error: ProcessError - Type: {Type} Message: {Message}",
                ex.GetType(), ex.Message);
        }
    }
}
