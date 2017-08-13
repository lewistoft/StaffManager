using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager.Interfaces
{
    public interface IStaffMember
    {
        bool CreateAdhocStaffGroup(string uniqueName);
        bool DeleteAdhocStaffGroup(string uniqueName);
    }
}
