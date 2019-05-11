using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    // Interface Repository 
    public interface IPersonRepository
    {
        string[] GetSplitPersonName(string fullName);
    }
}
