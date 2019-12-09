﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component.Table
{
    public class PagerResult<T>
    {
        public List<T> Rows { get; set; }
        public int Total { get; set; }
    }
}
