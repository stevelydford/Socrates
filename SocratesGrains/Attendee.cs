using System.Threading.Tasks;
using Orleans;
using SocratesGrainInterfaces;

namespace SocratesGrains
{

    public class Attendee : Grain, IAttendee
    {
        private string _name;

        public Task RegisterForSession(int sessionId)
        {
            var session = SessionFactory.GetGrain(sessionId);
            session.AddAttendee(this);
            return TaskDone.Done;
        }

        public Task<string> Name()
        {
            return Task.FromResult(_name);
        }


        public override Task OnActivateAsync()
        {
            _name = "Attendee" + this.GetPrimaryKey();
            return base.OnActivateAsync();
        }
    }
}
