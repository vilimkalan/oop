using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5.interfaces
{
    internal interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
