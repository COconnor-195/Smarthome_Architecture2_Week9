using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        private double _currentTemperature; 
        private double _targetTemperature; 


        public double CurrentTemperature
        {
            get { return _currentTemperature; }
            set { _currentTemperature = value; }
        } 

        public double TargetTemperature
        {
            get { return _targetTemperature; }
            set { _targetTemperature = value; }
        }


        public SmartThermostat(int smartDeviceID, 
            string smartDeviceName, 
            bool smartDeviceStatus, 
            double smartCurrentTemperature, 
            double smartTargetTemperature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            CurrentTemperature = smartCurrentTemperature;
            TargetTemperature = smartTargetTemperature;
        }


        public void SetTempature()
        { 

        } 

        public void SetCurrentTemperature()
        { 

        }

        public override void GetStatus()
        { 

        }





    } 



}
