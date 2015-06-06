using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;

namespace SocratesGrainInterfaces
{
    public interface IAttendee : IGrain
    {
        Task RegisterForSession(int sessionId);
        Task<string> Name();
    }
}