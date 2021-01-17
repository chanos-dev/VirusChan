using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Model
{
    class Detection
    { 
        public string DetectionEngine { get; set; }
        public bool Detected { get; set; }
        public string DetectionVersion { get; set; }
        public object DetectionResult { get; set; }
        public string DetectionUpdate { get; set; }

        public static Detection CreateDetection(string Engine, bool Detected, string Version, object Result, string Update)
        {
            Detection detection = new Detection();
            detection.DetectionEngine = Engine;
            detection.Detected = Detected;
            detection.DetectionVersion = Version;
            detection.DetectionResult = Result;
            detection.DetectionUpdate = Update;
            return detection;
        }
    }
}
