
/*********************************************************
 * AUTOGENERATED with ecuxml2cs.xsl!
 * DO NOT EDIT WITH HANDS!
 *********************************************************/
namespace hobd{

using System;

public class CommonSensors : SensorProvider
{

    public CommonSensors()
    {
    }
    
    public string GetName()
    {
        return "CommonSensors";
    }

    public string GetDescription()
    {
        return "Common derived sensors";
    }
    
    public string GetDescription(string lang)
    {
        return GetDescription();
    }

    public void Activate(SensorRegistry registry)
    {
        CoreSensor s;
        
        // CommonDistanceRun
        s = new hobd.DistanceSensor()
            {
                ID = "Common.DistanceRun",
                Name = "DistanceRun",
                
            };
        
        s.Units = "km";
  
        registry.Add(s);

        // CommonAcceleration
        s = new hobd.GSensor()
            {
                ID = "Common.Acceleration",
                Name = "Acceleration",
                
            };
        
        s.Units = "m/s^2";
  
        registry.Add(s);

        // CommonFuelConsumed
        s = new hobd.FuelConsumedSensor()
            {
                ID = "Common.FuelConsumed",
                Name = "FuelConsumed",
                
            };
        
        s.Units = "liters";
  
        registry.Add(s);

        // CommonFuelEconomy_trip
        s = new hobd.FuelEconomyTripSensor()
            {
                ID = "Common.FuelEconomy_trip",
                Name = "FuelEconomy_trip",
                
            };
        
        s.Units = "lph";
  
        registry.Add(s);

        // CommonTripTime
        s = new hobd.TripTime()
            {
                ID = "Common.TripTime",
                Name = "TripTime",
                
            };
        
        s.Units = "seconds";
  
        registry.Add(s);

        // CommonIdleTime
        s = new hobd.IdleTime()
            {
                ID = "Common.IdleTime",
                Name = "IdleTime",
                
            };
        
        s.Units = "seconds";
  
        registry.Add(s);

        // CommonSpeed
        s = new hobd.SpeedCorrectionSensor()
            {
                ID = "Common.Speed",
                Name = "Speed",
                
            };
        
        registry.Add(s);

    }

    
  public const string DistanceRun = "DistanceRun";

  public const string Acceleration = "Acceleration";

  public const string FuelConsumed = "FuelConsumed";

  public const string FuelEconomy_trip = "FuelEconomy_trip";

  public const string TripTime = "TripTime";

  public const string IdleTime = "IdleTime";

  public const string Speed = "Speed";

}

}
/**
  List of PIDs generated:

  - DistanceRun - Distance Run - Total distance run on trip - km
  - Acceleration - Acceleration - Current Acceleration - m/s^2
  - FuelConsumed - Fuel Consumed - Total fuel consumed - liters
  - FuelEconomy_trip - Fuel Economy - Total fuel economy on trip - lph
  - TripTime - Trip Time - Total trip time - seconds
  - IdleTime - Idle Time - Idle time (with speed less 5km) - seconds
  - Speed -  -  - 
*/
