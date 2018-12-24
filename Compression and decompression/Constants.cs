﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression_and_decompression
{
    public static class Constants
    {
        public static readonly int BitsUsed = 64;
        public static readonly ulong Half = 1UL << (BitsUsed - 1);
        public static readonly ulong Quarter = 1UL << (BitsUsed - 2);
        public static readonly ulong LogConstant = 1000000000000000;
    }
}
