using System;

namespace RegoSimulator
{
    class RegoRegisters
    {
        public double RadiatorReturn { get; set; }
        public double Outdoor { get; set; }
        public double HotWater { get; set; }
        public double Forward { get; set; }
        public double Room { get; set; }
        public double Compressor { get; set; }
        public double HeatFluidIn { get; set; }
        public double HeatFluidOut { get; set; }
        public double ColdFluidIn { get; set; }
        public double ColdFluidOut { get; set; }
        public double ExternalHotWater { get; set; }
    }
}
