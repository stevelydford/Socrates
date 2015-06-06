using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orleans;
using SocratesGrainInterfaces;

namespace SocratesGrains
{
    public class Session: Grain, ISession
    {
        private IList<IAttendee> _attendees = new List<IAttendee>(); 

        public Task AddAttendee(IAttendee attendee)
        {
            _attendees.Add(attendee);
            return TaskDone.Done;
        }

        public Task<IList<IAttendee>> Attendees()
        {
            return Task.FromResult(_attendees);
        }
    }
}
