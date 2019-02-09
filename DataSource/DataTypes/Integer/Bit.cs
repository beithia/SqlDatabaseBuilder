﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xtrimmer.SqlDatabaseBuilder
{
    internal class Bit : Integer
    {
        public override string Definition => "bit";
        public override int Size => 1;
        public static long Max = 1;
        public static long Min = 0;
    }
}
