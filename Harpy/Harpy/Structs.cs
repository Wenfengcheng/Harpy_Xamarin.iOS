using System;
using ObjCRuntime;

namespace Harpy
{
    [Native]
    public enum HarpyAlertType : ulong
    {
        Force = 1,
        Option,
        Skip,
        None
    }
}
