using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRoom
{
    public class Session
    {
        public Guid SessionID { get; }
        private DateTime StartDateTime;
        private DateTime? EndDateTime;
        private List<string> Users;
        
        public double TotalSessionTime
        {
            get
            {
                if (EndDateTime.HasValue)
                    return EndDateTime.Value.Subtract(StartDateTime).TotalSeconds;
                else
                    return DateTime.Now.Subtract(StartDateTime).TotalSeconds;
            }
        }

        public bool IsSessionActive => !this.EndDateTime.HasValue;

        public Session()
        {
            SessionID = Guid.NewGuid();
            Users = new List<string>();
            this.StartDateTime = DateTime.Now;
        }

        public bool AddUser(string user)
        {
            if (!this.Users.Contains(user))
            {
                this.Users.Add(user);
                return true;
            }
            else
                return false;
        }

        public bool RemoveUser(string user)
        {
            if (this.Users.Contains(user))
            {
                this.Users.Remove(user);
                if (this.Users.Count == 0)
                    this.EndDateTime = DateTime.Now;

                return true;
            }
            else
                return false;
        }
    }
}
