using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.InterfaceAdapter.Interfaces.Mapping
{
    interface Iparser
    {
        TResult Parse<TResult, TIn>(TIn value);
    }
}
