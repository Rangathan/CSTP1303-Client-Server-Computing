using System;

namespace assignment5.Class
{
    internal class GenericClass
    {
        public enum VehicleType
        {
            Car,
            Truck,
            Bus,
            Motorcycle
        }

        public class Engine
        {
            
        }

        public class Body
        {
            
        }

        public class Vehicle<TVehicleType, TEngine, TBody>
            where TVehicleType : struct, Enum
            where TEngine : Engine
            where TBody : Body
        {
            public TVehicleType Type { get; set; }
            public TEngine Engine { get; set; }
            public TBody Body { get; set; }

            public override string ToString()
            {
                return $"Type: {Type}, Engine: {Engine}, Body: {Body}";
            }
        }


        
    }
}
