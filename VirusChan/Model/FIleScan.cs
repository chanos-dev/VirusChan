using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusChan.Model
{
    interface IFileScanInfo
    {
        bool detected { get; set; }
        string version { get; set; }
        object result { get; set; }
        string update { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Bkav : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; } 
    }

    public class TotalDefense : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class MicroWorldEScan : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class CMC : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class CATQuickHeal : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class McAfee : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Malwarebytes : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Zillya : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Sangfor : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class K7AntiVirus : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class K7GW : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class BitDefenderTheta : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Cyren : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Symantec : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class ESETNOD32 : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Baidu : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class TrendMicroHouseCall : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Avast : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class ClamAV : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Kaspersky : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class BitDefender : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class NANOAntivirus : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class ViRobot : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class SUPERAntiSpyware : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Rising : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class AdAware : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class TACHYON : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Emsisoft : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Comodo : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class FSecure : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class DrWeb : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class VIPRE : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class TrendMicro : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class McAfeeGWEdition : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class FireEye : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Sophos : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Ikarus : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Jiangmin : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Avira : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class AntiyAVL : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Kingsoft : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Microsoft : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Gridinsoft : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Arcabit : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class AegisLab : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class ZoneAlarm : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class GData : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Cynet : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class AhnLabV3 : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Acronis : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class ALYac : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class MAX : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class VBA32 : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Cylance : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Zoner : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Tencent : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Yandex : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class SentinelOne : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class MaxSecure : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Fortinet : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class AVG : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Panda : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Qihoo360 : IFileScanInfo
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public object result { get; set; }
        public string update { get; set; }
    }

    public class Scans
    {
        public Bkav Bkav { get; set; }
        public TotalDefense TotalDefense { get; set; }
        [JsonProperty("MicroWorld-eScan")]
        public MicroWorldEScan MicroWorldEScan { get; set; }
        public CMC CMC { get; set; }
        [JsonProperty("CAT-QuickHeal")]
        public CATQuickHeal CATQuickHeal { get; set; }
        public McAfee McAfee { get; set; }
        public Malwarebytes Malwarebytes { get; set; }
        public Zillya Zillya { get; set; }
        public Sangfor Sangfor { get; set; }
        public K7AntiVirus K7AntiVirus { get; set; }
        public K7GW K7GW { get; set; }
        public BitDefenderTheta BitDefenderTheta { get; set; }
        public Cyren Cyren { get; set; }
        public Symantec Symantec { get; set; }
        [JsonProperty("ESET-NOD32")]
        public ESETNOD32 ESETNOD32 { get; set; }
        public Baidu Baidu { get; set; }
        [JsonProperty("TrendMicro-HouseCall")]
        public TrendMicroHouseCall TrendMicroHouseCall { get; set; }
        public Avast Avast { get; set; }
        public ClamAV ClamAV { get; set; }
        public Kaspersky Kaspersky { get; set; }
        public BitDefender BitDefender { get; set; }
        [JsonProperty("NANO-Antivirus")]
        public NANOAntivirus NANOAntivirus { get; set; }
        public ViRobot ViRobot { get; set; }
        public SUPERAntiSpyware SUPERAntiSpyware { get; set; }
        public Rising Rising { get; set; }
        [JsonProperty("Ad-Aware")]
        public AdAware AdAware { get; set; }
        public TACHYON TACHYON { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Comodo Comodo { get; set; }
        [JsonProperty("F-Secure")]
        public FSecure FSecure { get; set; }
        public DrWeb DrWeb { get; set; }
        public VIPRE VIPRE { get; set; }
        public TrendMicro TrendMicro { get; set; }
        [JsonProperty("McAfee-GW-Edition")]
        public McAfeeGWEdition McAfeeGWEdition { get; set; }
        public FireEye FireEye { get; set; }
        public Sophos Sophos { get; set; }
        public Ikarus Ikarus { get; set; }
        public Jiangmin Jiangmin { get; set; }
        public Avira Avira { get; set; }
        [JsonProperty("Antiy-AVL")]
        public AntiyAVL AntiyAVL { get; set; }
        public Kingsoft Kingsoft { get; set; }
        public Microsoft Microsoft { get; set; }
        public Gridinsoft Gridinsoft { get; set; }
        public Arcabit Arcabit { get; set; }
        public AegisLab AegisLab { get; set; }
        public ZoneAlarm ZoneAlarm { get; set; }
        public GData GData { get; set; }
        public Cynet Cynet { get; set; }
        [JsonProperty("AhnLab-V3")]
        public AhnLabV3 AhnLabV3 { get; set; }
        public Acronis Acronis { get; set; }
        public ALYac ALYac { get; set; }
        public MAX MAX { get; set; }
        public VBA32 VBA32 { get; set; }
        public Cylance Cylance { get; set; }
        public Zoner Zoner { get; set; }
        public Tencent Tencent { get; set; }
        public Yandex Yandex { get; set; }
        public SentinelOne SentinelOne { get; set; }
        public MaxSecure MaxSecure { get; set; }
        public Fortinet Fortinet { get; set; }
        public AVG AVG { get; set; }
        public Panda Panda { get; set; }
        [JsonProperty("Qihoo-360")]
        public Qihoo360 Qihoo360 { get; set; }
    }

    public class FileScan
    {
        public Scans scans { get; set; }
        public string scan_id { get; set; }
        public string sha1 { get; set; }
        public string resource { get; set; }
        public int response_code { get; set; }
        public string scan_date { get; set; }
        public string permalink { get; set; }
        public string verbose_msg { get; set; }
        public int total { get; set; }
        public int positives { get; set; }
        public string sha256 { get; set; }
        public string md5 { get; set; }
    }


}
