using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraCAM
{
    enum Units
    {
        Inches=1,
        Milllimeters,
    }

    enum Direction
    {
        Positive=1,
        Negative=2
    }

    class MachineProperties
    {
        //Container class for holding Machine Properties
        
        Units NativeUnits;

        //Physical Dimensions
        AxisProperties xAxis;
        AxisProperties yAxis;
        AxisProperties zAxis;


    }
    class AxisProperties
    {
        //Container class for holding axis properties
        float maxAccel;
        float maxVel;
        float minLim;
        float maxLim;
        float homePosition;

        float homingSpeed;
        Direction homeDirection; 

    }
}
