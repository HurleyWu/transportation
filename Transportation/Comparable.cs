﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    interface Comparable<T>
    {
        int compareTo(T o);
    }
}
