using System;
using Newtonsoft.Json.Serialization;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate;
        if (speed == 0)
        {
            successRate = 0;
            return successRate; 
        }
        if (speed>=1 && speed <=4)
        {
            successRate = 1;
            return successRate; 
        }
        if (speed>=5 && speed <=8)
        {
            successRate = 0.9;
            return successRate;
        }
        if (speed == 9)
        {
            successRate = 0.8;
            return successRate;
        }
        if (speed == 10)
        {
            successRate = 0.77;
            return successRate;
        }
        else
        {
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed)/60;
    }
}
