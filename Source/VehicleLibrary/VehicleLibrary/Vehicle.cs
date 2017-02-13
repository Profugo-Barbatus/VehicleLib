using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace VehicleLibrary
{
    public class Vehicle : ThingWithComps
    {
        public VehicleDef localDef;

        public Vehicle()
        {
            localDef = this.def as VehicleDef;
        }
    }
}
