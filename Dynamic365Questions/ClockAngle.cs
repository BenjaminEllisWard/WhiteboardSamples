using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class ClockAngle
    {
        // Write a function that finds the angle between the hour hand and the minute hand on a clock.
        // Output angle should be 180 degrees or less.

        // Plan: find angle from 12 oclock position for each hand; subtract greater angle from lesser angle;
        //       if angle is greater than 180 degrees, subtract from 360.

        public double Angle(DateTime time)
        {
            double hourAngle = 0;
            double minAngle = 0;

            hourAngle = time.Hour * 30 + time.Minute * 0.1;
            // enforces am/pm compensation for hour hand
            hourAngle = hourAngle > 360 ? hourAngle - 360 : hourAngle;

            minAngle = time.Minute * 6 + time.Second * 0.1;

            double angle = Math.Max(hourAngle, minAngle) - Math.Min(hourAngle, minAngle);

            // enforces angle under 181
            angle = angle > 180 ? 360 - angle : angle;

            return angle;
        }
    }
}
