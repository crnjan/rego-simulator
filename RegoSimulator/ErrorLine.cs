using System;

namespace RegoSimulator
{
    struct ErrorLine
    {
        public byte Error { get; set; }
        public DateTime Timestamp { get; set; }
        public byte Value1 { get; set; }
        public byte Value2 { get; set; }
        public byte Value3 { get; set; }
        public byte Value4 { get; set; }
    }
}
