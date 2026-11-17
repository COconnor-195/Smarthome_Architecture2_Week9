using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        private string _resolutionStatus;
        private bool _recordingStatus;

        public string ResolutionStatus
        {
            get { return _resolutionStatus; }
            set { _resolutionStatus = value; }

        }

        public bool RecordingStatus
        {
            get { return _recordingStatus; }
            set { _recordingStatus = value; }

        }

        public SmartSecurityCamera(string smartResolutionStatus, bool smartRecordingStatus, int smartDeviceID, string smartDeviceName, bool smartDeviceStatus) : base(smartDeviceID, smartDeviceName ,smartDeviceStatus)
         
        {
            ResolutionStatus = smartResolutionStatus;
            RecordingStatus = smartRecordingStatus; 
       

        } 

        public void StartRecording()
        {

        }


        public void StopRecording()
        {

        }

        public override void GetStatus()
        {
       
        }

    }
}
