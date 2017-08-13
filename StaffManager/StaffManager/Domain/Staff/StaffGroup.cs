using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager.Domain.Staff
{
    public class StaffGroup : ICollection<StaffMember>
    {
        public Guid Guid { get; }
        public string GroupName { get; set; }
        public StaffMember Owner { get; }

        public List<StaffMember> GroupMembers { get; set; }

        public int Count => GroupMembers.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public StaffGroup(string groupName, StaffMember owner)
        {
            Guid = Guid.NewGuid();
        }

        public StaffGroup(string groupName, StaffMember owner, List<StaffMember> managers)
        {
            Guid = Guid.NewGuid();
        }

        public void Add(StaffMember item)
        {
            if (!GroupMembers.Contains(item))
            {
                GroupMembers.Add(item);
            }
        }

        public void Clear()
        {
            GroupMembers = new List<StaffMember>();
        }

        public bool Contains(StaffMember item)
        {
            foreach(var groupMember in GroupMembers)
            {
                if (groupMember == item) return true;
            }
            return false;
        }

        public void CopyTo(StaffMember[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(StaffMember item)
        {
            if (!GroupMembers.Contains(item)) return false;

            GroupMembers.Remove(item);
            return true;
        }

        public IEnumerator<StaffMember> GetEnumerator()
        {
            return GroupMembers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)GroupMembers).GetEnumerator();
        }
    }
}
