using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager.Domain.Staff
{
    public class StaffMember : IEquatable<StaffMember>
    {
        public Guid Guid { get; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public List<StaffGroup> StaffGroups { get; set; }

        public StaffMember(string userName, string nickName)
        {
            Guid = Guid.NewGuid();
            UserName = userName;
            NickName = nickName;

            DefaultStaffGroups(new List<StaffMember>());
        }

        public StaffMember(string userName, string nickName, List<StaffMember> managers)
        {
            Guid = Guid.NewGuid();
            UserName = userName;
            NickName = nickName;

            DefaultStaffGroups(managers);
        }
        
        public bool Equals(StaffMember other)
        {
            return this.UserName == other.UserName;
        }

        private void DefaultStaffGroups(List<StaffMember> managers)
        {
            StaffGroups = new List<StaffGroup>();
            StaffGroups.Add(new StaffGroup("DirectReports", this));
            StaffGroups.Add(new StaffGroup("LineManagers", this));
        }
    }
}
