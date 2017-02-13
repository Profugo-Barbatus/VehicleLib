using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace VehicleLibrary
{
    class VehicleRenderer
    {
        private Vehicle vehicle;
        
        public VehicleGraphicSet graphics;
        //Test var, will be replaced later to handle the logic of rendering a wreck or an actual vehicle
        private bool render;

        public VehicleRenderer(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        //A visible structure that handles the rendering logic
        public void renderVehicleAt(Vector3 drawLoc)
        {

        }

        //A private structure that handles the actual job of rendering
        private void internalRender(Vector3 drawLoc)
        {
            //Resolve graphics in case it hasn't be done just to be sure, but later

            Mesh mesh = null;

            if(render)
            {
                this.graphics.vehicleBody.Draw(drawLoc, vehicle.Rotation, vehicle);
            }
        }
    }
}
