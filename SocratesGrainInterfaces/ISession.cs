using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;

namespace SocratesGrainInterfaces
{
    public interface ISession: IGrain
    {
        Task AddAttendee(IAttendee attendee);

        Task<IList<IAttendee>> Attendees();
    }
}
