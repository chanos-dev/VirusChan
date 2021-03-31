using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusChan.Interface;

namespace VirusChan.Model.VirusUrl
{
    interface IUrlScanInfo
    {
        bool detected { get; set; }
        string result { get; set; } 
    } 

    public class CMCThreatIntelligence : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CLEANMX : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DNS8 : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalSilo : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class NotMining : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AICCMONITORAPP : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class VXVault : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Securolytics : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Tencent : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwarePatrol : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Armis : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalBeacon : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ComodoValkyrieVerdict : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PhishLabs : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class EmergingThreats : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Sangfor : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class K7AntiVirus : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class VirusdieExternalSiteScan : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ArtistsAgainst419 : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CINSArmy : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Cyren : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Quttera : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AegisLabWebGuard : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwareDomainList : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
        public string detail { get; set; }
    }

    public class Lumu : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Zvelo : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GoogleSafebrowsing : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Kaspersky : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BitDefender : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GreenSnow : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class IPsum : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GData : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CyberCrime : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwareDomainBlocklist : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AutoShun : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class FeodoTracker : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class WebSecurityGuard : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Cyan : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CyRadar : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DesenmascaraMe : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ADMINUSLabs : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SCUMWAREOrg : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DrWeb : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AlienVault : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Emsisoft : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Spamhaus : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwaresComURLchecker : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Phishtank : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class EonScope : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Malwared : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Avira : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CiscoTalosIPBlacklist : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class OpenPhish : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AntiyAVL : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ForcepointThreatSeeker : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Spam404 : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Trustwave : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Certego : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class URLhaus : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class YandexSafebrowsing : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
        public string detail { get; set; }
    }

    public class ESET : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Threatsourcing : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BlockList : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SecureBrain : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Nucleon : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PREBYTES : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Sophos : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Blueliv : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class HopliteIndustries : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Netcraft : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CRDF : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ThreatHive : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BADWAREINFO : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class FraudScore : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class QuickHeal : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Rising : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class StopBadware : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SucuriSiteCheck : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Fortinet : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class StopForumSpam : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ZeroCERT : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BaiduInternational : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PhishingDatabase : IUrlScanInfo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Scans
    {
        public CMCThreatIntelligence CMCThreatIntelligence { get; set; }
        public CLEANMX CLEANMX { get; set; }
        public DNS8 DNS8 { get; set; }
        public MalSilo MalSilo { get; set; }
        public NotMining NotMining { get; set; }
        [JsonProperty("AICC(MONITORAPP)")]
        public AICCMONITORAPP AICCMONITORAPP { get; set; }
        public VXVault VXVault { get; set; }
        public Securolytics securolytics { get; set; }
        public Tencent Tencent { get; set; }
        public MalwarePatrol MalwarePatrol { get; set; }
        public Armis Armis { get; set; }
        public MalBeacon MalBeacon { get; set; }
        public ComodoValkyrieVerdict ComodoValkyrieVerdict { get; set; }
        public PhishLabs PhishLabs { get; set; }
        public EmergingThreats EmergingThreats { get; set; }
        public Sangfor Sangfor { get; set; }
        public K7AntiVirus K7AntiVirus { get; set; }
        public VirusdieExternalSiteScan VirusdieExternalSiteScan { get; set; }
        public ArtistsAgainst419 ArtistsAgainst419 { get; set; }
        public CINSArmy CINSArmy { get; set; }
        public Cyren Cyren { get; set; }
        public Quttera Quttera { get; set; }
        public AegisLabWebGuard AegisLabWebGuard { get; set; }
        public MalwareDomainList MalwareDomainList { get; set; }
        public Lumu Lumu { get; set; }
        public Zvelo zvelo { get; set; }
        public GoogleSafebrowsing GoogleSafebrowsing { get; set; }
        public Kaspersky Kaspersky { get; set; }
        public BitDefender BitDefender { get; set; }
        public GreenSnow GreenSnow { get; set; }
        public IPsum IPsum { get; set; }
        [JsonProperty("G-Data")]
        public GData GData { get; set; }
        public CyberCrime CyberCrime { get; set; }
        public MalwareDomainBlocklist MalwareDomainBlocklist { get; set; }
        public AutoShun AutoShun { get; set; }
        public FeodoTracker FeodoTracker { get; set; }
        public WebSecurityGuard WebSecurityGuard { get; set; }
        public Cyan Cyan { get; set; }
        public CyRadar CyRadar { get; set; }
        [JsonProperty("desenmascara.me")]
        public DesenmascaraMe DesenmascaraMe { get; set; }
        public ADMINUSLabs ADMINUSLabs { get; set; }
        [JsonProperty("SCUMWARE.org")]
        public SCUMWAREOrg SCUMWAREOrg { get; set; }
        [JsonProperty("Dr.Web")]
        public DrWeb DrWeb { get; set; }
        public AlienVault AlienVault { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Spamhaus Spamhaus { get; set; }
        [JsonProperty("malwares.comURLchecker")]
        public MalwaresComURLchecker MalwaresComURLchecker { get; set; }
        public Phishtank Phishtank { get; set; }
        public EonScope EonScope { get; set; }
        public Malwared Malwared { get; set; }
        public Avira Avira { get; set; }
        public CiscoTalosIPBlacklist CiscoTalosIPBlacklist { get; set; }
        public OpenPhish OpenPhish { get; set; }
        [JsonProperty("Antiy-AVL")]
        public AntiyAVL AntiyAVL { get; set; }
        public ForcepointThreatSeeker ForcepointThreatSeeker { get; set; }
        public Spam404 Spam404 { get; set; }
        public Trustwave Trustwave { get; set; }
        public Certego Certego { get; set; }
        public URLhaus URLhaus { get; set; }
        public YandexSafebrowsing YandexSafebrowsing { get; set; }
        public ESET ESET { get; set; }
        public Threatsourcing Threatsourcing { get; set; }
        public BlockList BlockList { get; set; }
        public SecureBrain SecureBrain { get; set; }
        public Nucleon Nucleon { get; set; }
        public PREBYTES PREBYTES { get; set; }
        public Sophos Sophos { get; set; }
        public Blueliv Blueliv { get; set; }
        public HopliteIndustries HopliteIndustries { get; set; }
        public Netcraft Netcraft { get; set; }
        public CRDF CRDF { get; set; }
        public ThreatHive ThreatHive { get; set; }
        [JsonProperty("BADWARE.INFO")]
        public BADWAREINFO BADWAREINFO { get; set; }
        public FraudScore FraudScore { get; set; }
        public QuickHeal QuickHeal { get; set; }
        public Rising Rising { get; set; }
        public StopBadware StopBadware { get; set; }
        [JsonProperty("Sucuri SiteCheck")]
        public SucuriSiteCheck SucuriSiteCheck { get; set; }
        public Fortinet Fortinet { get; set; }
        public StopForumSpam StopForumSpam { get; set; }
        public ZeroCERT ZeroCERT { get; set; }
        [JsonProperty("Baidu-International")]
        public BaiduInternational BaiduInternational { get; set; }
        public PhishingDatabase PhishingDatabase { get; set; }
    }

    public class UrlScan : IScan
    {
        #region interface property
        public string scan_id { get; set; }
        public string resource { get; set; }
        public int response_code { get; set; }
        public string scan_date { get; set; }
        public string permalink { get; set; }
        public string verbose_msg { get; set; }
        public int positives { get; set; }
        public int total { get; set; }
        #endregion


        public object filescan_id { get; set; }
        public Scans scans { get; set; }
        public string url { get; set; }
    }


}
