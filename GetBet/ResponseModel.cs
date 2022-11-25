using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetBet
{
   public class ResponseModel
    {
        [JsonProperty("sg")]
        public Sg sg { get; set; }

        [JsonProperty("nsn")]
        public Nsn nsn { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BestWinnersBets
    {
    }

    public class EA
    {
        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("EV")]
        public int EV { get; set; }

        [JsonProperty("ENN")]
        public string ENN { get; set; }

        [JsonProperty("TYPE")]
        public int TYPE { get; set; }

        [JsonProperty("GT")]
        public int GT { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("ESD")]
        public object ESD { get; set; }

        [JsonProperty("ED")]
        public object ED { get; set; }

        [JsonProperty("DAY")]
        public string DAY { get; set; }

        [JsonProperty("T")]
        public string T { get; set; }

        [JsonProperty("P")]
        public int P { get; set; }

        [JsonProperty("LC")]
        public int LC { get; set; }

        [JsonProperty("BC")]
        public string BC { get; set; }

        [JsonProperty("LE")]
        public int LE { get; set; }

        [JsonProperty("BP")]
        public int BP { get; set; }

        [JsonProperty("BS")]
        public int BS { get; set; }

        [JsonProperty("NS")]
        public int NS { get; set; }

        [JsonProperty("MA")]
        public List<MA> MA { get; set; }

        [JsonProperty("MSA")]
        public List<MSA> MSA { get; set; }

        [JsonProperty("CE")]
        public int CE { get; set; }

        [JsonProperty("BRID")]
        public int BRID { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }
    }

    public class EditorChoice
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("outcome")]
        public string outcome { get; set; }

        [JsonProperty("marketId")]
        public string marketId { get; set; }
    }

    public class Editors
    {
        [JsonProperty("1006")]
        public string _1006 { get; set; }

        [JsonProperty("1001")]
        public string _1001 { get; set; }

        [JsonProperty("-1")]
        public string _1 { get; set; }

        [JsonProperty("1032")]
        public string _1032 { get; set; }

        [JsonProperty("1034")]
        public string _1034 { get; set; }

        [JsonProperty("1037")]
        public string _1037 { get; set; }

        [JsonProperty("1050")]
        public string _1050 { get; set; }

        [JsonProperty("1009")]
        public string _1009 { get; set; }

        [JsonProperty("1031")]
        public string _1031 { get; set; }

        [JsonProperty("1018")]
        public string _1018 { get; set; }

        [JsonProperty("1028")]
        public string _1028 { get; set; }

        [JsonProperty("1051")]
        public string _1051 { get; set; }

        [JsonProperty("1014")]
        public string _1014 { get; set; }

        [JsonProperty("1010")]
        public string _1010 { get; set; }

        [JsonProperty("1044")]
        public string _1044 { get; set; }

        [JsonProperty("1039")]
        public string _1039 { get; set; }

        [JsonProperty("1003")]
        public string _1003 { get; set; }

        [JsonProperty("1007")]
        public string _1007 { get; set; }

        [JsonProperty("1038")]
        public string _1038 { get; set; }

        [JsonProperty("1042")]
        public string _1042 { get; set; }
    }

    public class EditorVideo
    {
        [JsonProperty("eventId")]
        public int eventId { get; set; }

        [JsonProperty("videoId")]
        public string videoId { get; set; }
    }

    public class EWMA
    {
        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("TYPE")]
        public int TYPE { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("ESD")]
        public object ESD { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }

        [JsonProperty("LC")]
        public string LC { get; set; }

        [JsonProperty("LN")]
        public string LN { get; set; }

        [JsonProperty("LO")]
        public int LO { get; set; }

        [JsonProperty("ENO")]
        public string ENO { get; set; }
    }

    public class LA
    {
        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("CC")]
        public string CC { get; set; }

        [JsonProperty("SO")]
        public int SO { get; set; }
    }

    public class MA
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("NO")]
        public int NO { get; set; }

        [JsonProperty("MV")]
        public int MV { get; set; }

        [JsonProperty("MTID")]
        public int MTID { get; set; }

        [JsonProperty("MBS")]
        public int MBS { get; set; }

        [JsonProperty("SOV")]
        public double SOV { get; set; }

        [JsonProperty("MS")]
        public int MS { get; set; }

        [JsonProperty("OCA")]
        public List<OCA> OCA { get; set; }

        [JsonProperty("MSD")]
        public object MSD { get; set; }

        [JsonProperty("MED")]
        public object MED { get; set; }

        [JsonProperty("HM")]
        public int? HM { get; set; }

        [JsonProperty("BM")]
        public int? BM { get; set; }

        [JsonProperty("INM")]
        public int? INM { get; set; }
    }

    public class MSA
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("NO")]
        public int NO { get; set; }

        [JsonProperty("MN")]
        public string MN { get; set; }

        [JsonProperty("MV")]
        public int MV { get; set; }

        [JsonProperty("MT")]
        public int MT { get; set; }

        [JsonProperty("MBS")]
        public int MBS { get; set; }

        [JsonProperty("SOV")]
        public double SOV { get; set; }

        [JsonProperty("MS")]
        public int MS { get; set; }

        [JsonProperty("MSD")]
        public object MSD { get; set; }

        [JsonProperty("MED")]
        public object MED { get; set; }

        [JsonProperty("OCA")]
        public List<OCA> OCA { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("T")]
        public string T { get; set; }

        [JsonProperty("IO")]
        public string IO { get; set; }

        [JsonProperty("VT")]
        public int VT { get; set; }
    }

    public class Nsn
    {
        [JsonProperty("nsnDataVersion")]
        public string nsnDataVersion { get; set; }

        [JsonProperty("percentages")]
        public List<object> percentages { get; set; }

        [JsonProperty("outcomePercentages")]
        public OutcomePercentages outcomePercentages { get; set; }

        [JsonProperty("nsnBultenNames")]
        public List<NsnBultenName> nsnBultenNames { get; set; }

        [JsonProperty("nsnBroadcasts")]
        public List<NsnBroadcast> nsnBroadcasts { get; set; }

        [JsonProperty("editorChoices")]
        public List<EditorChoice> editorChoices { get; set; }

        [JsonProperty("editorVideos")]
        public List<EditorVideo> editorVideos { get; set; }

        [JsonProperty("editors")]
        public Editors editors { get; set; }

        [JsonProperty("editorComments")]
        public List<int> editorComments { get; set; }

        [JsonProperty("bestWinnersBets")]
        public BestWinnersBets bestWinnersBets { get; set; }
    }

    public class NsnBroadcast
    {
        [JsonProperty("E")]
        public int E { get; set; }

        [JsonProperty("M")]
        public int M { get; set; }

        [JsonProperty("C")]
        public string C { get; set; }
    }

    public class NsnBultenName
    {
        [JsonProperty("EID")]
        public int EID { get; set; }

        [JsonProperty("MID")]
        public int MID { get; set; }

        [JsonProperty("ON")]
        public int ON { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }
    }

    public class OCA
    {
        [JsonProperty("N")]
        public int N { get; set; }

        [JsonProperty("O")]
        public double O { get; set; }

        [JsonProperty("ON")]
        public string ON { get; set; }
    }

    public class OutcomePercentages
    {
    }

    public class Sg
    {
        [JsonProperty("eventVersion")]
        public int eventVersion { get; set; }

        [JsonProperty("marketVersion")]
        public int marketVersion { get; set; }

        [JsonProperty("oddVersion")]
        public int oddVersion { get; set; }

        [JsonProperty("drawNo")]
        public int drawNo { get; set; }

        [JsonProperty("FB")]
        public int FB { get; set; }

        [JsonProperty("EA")]
        public List<EA> EA { get; set; }

        [JsonProperty("EWMA")]
        public List<EWMA> EWMA { get; set; }

        [JsonProperty("LA")]
        public List<LA> LA { get; set; }
    }


}
