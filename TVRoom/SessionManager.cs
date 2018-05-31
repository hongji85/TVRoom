using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRoom
{
    public class SessionManager
    {
        private List<Session> Sessions;

        public SessionManager()
        {
            Sessions = new List<Session>();
        }

        public Session ActiveSession => Sessions.FirstOrDefault(s => s.IsSessionActive);

        public Session LastSession => Sessions.Last();

        public Session CreateSession()
        {
            Session newSession = new Session();
            Sessions.Add(newSession);
            return newSession;
        }

        public double CalculateTimeOn => Sessions.Sum(s => s.TotalSessionTime);

    }
}
