using MicCleanArchitecture.Application.Common.Interfaces;

namespace MicCleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }

}
