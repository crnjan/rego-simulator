using System;
using System.Collections.Generic;

namespace RegoSimulator
{
    class RegoMapper
    {
        private readonly Dictionary<int, Func<double>> mapper;


        private RegoMapper(Dictionary<int, Func<double>> mapper)
        {
            this.mapper = mapper;
        }

        public double? ValueForAddress(int address)
        {
            Func<double> valueProvider;
            if (mapper.TryGetValue(address, out valueProvider) == false)
                return null;

            return valueProvider();
        }

        public static RegoMapper CreateRego600Mapper(RegoRegisters registers)
        {
            var mapper = new Dictionary<int, Func<double>>()
            {
                { 0x0209, () => registers.RadiatorReturn },
                { 0x020A, () => registers.Outdoor },
                { 0x020B, () => registers.HotWater },
                { 0x020C, () => registers.Forward },
                { 0x020D, () => registers.Room }
            };

            return new RegoMapper(mapper);
        }
    }
}
