﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager.Interfaces
{
    public interface IHasUniqueName
    {
        bool NameIsUnique(string proposedUniqueName);
    }
}
