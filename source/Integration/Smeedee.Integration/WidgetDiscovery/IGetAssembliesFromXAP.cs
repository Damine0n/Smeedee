﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Smeedee.Integration.WidgetDiscovery
{
    public interface IGetAssembliesFromXAP
    {
        IEnumerable<Assembly> GetAssemblies(string xapFilePath);
    }
}
