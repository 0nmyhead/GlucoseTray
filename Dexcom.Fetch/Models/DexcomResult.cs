﻿namespace Dexcom.Fetch.Models
{
    internal class DexcomResult
    {
        public string ST { get; set; }
        public string DT { get; set; }
        public int Trend { get; set; }
        public int Value { get; set; }
        public string WT { get; set; }
    }
}
