﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    class sizeExeption : ApplicationException
    {
        public sizeExeption() : base() { }
        public sizeExeption(string str) : base(str) { }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
