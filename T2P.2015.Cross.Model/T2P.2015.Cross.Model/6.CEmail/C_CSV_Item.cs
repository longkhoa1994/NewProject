using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_CSV_Item : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_CSV_HeaderID;
        public long C_CSV_HeaderID
        {
            get { return _c_CSV_HeaderID; }
            set { _c_CSV_HeaderID = value; }
        }
        private string _kartennummer;
        public string Kartennummer
        {
            get { return _kartennummer; }
            set { _kartennummer = value; }
        }
        private string _karteninhaberName;
        public string KarteninhaberName
        {
            get { return _karteninhaberName; }
            set { _karteninhaberName = value; }
        }
        private string _karteninhaberStadt;
        public string KarteninhaberStadt
        {
            get { return _karteninhaberStadt; }
            set { _karteninhaberStadt = value; }
        }
        private string _rechnungsnummer;
        public string Rechnungsnummer
        {
            get { return _rechnungsnummer; }
            set { _rechnungsnummer = value; }
        }
        private DateTime? _rechnungsdatum;
        public DateTime? Rechnungsdatum
        {
            get { return _rechnungsdatum; }
            set { _rechnungsdatum = value; }
        }
        private string _bruttobetrag;
        public string Bruttobetrag
        {
            get { return _bruttobetrag; }
            set { _bruttobetrag = value; }
        }
        private int? _positionsnummer;
        public int? Positionsnummer
        {
            get { return _positionsnummer; }
            set { _positionsnummer = value; }
        }
        private string _leistungsart;
        public string Leistungsart
        {
            get { return _leistungsart; }
            set { _leistungsart = value; }
        }
        private string _dokumentennummer;
        public string Dokumentennummer
        {
            get { return _dokumentennummer; }
            set { _dokumentennummer = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _routing;
        public string Routing
        {
            get { return _routing; }
            set { _routing = value; }
        }
        private string _leistungserbringer;
        public string Leistungserbringer
        {
            get { return _leistungserbringer; }
            set { _leistungserbringer = value; }
        }
        private DateTime? _verkaufsDatum;
        public DateTime? VerkaufsDatum
        {
            get { return _verkaufsDatum; }
            set { _verkaufsDatum = value; }
        }
        private DateTime? _reiseDatum;
        public DateTime? ReiseDatum
        {
            get { return _reiseDatum; }
            set { _reiseDatum = value; }
        }
        private string _klasse;
        public string Klasse
        {
            get { return _klasse; }
            set { _klasse = value; }
        }
        private string _airlineCode;
        public string AirlineCode
        {
            get { return _airlineCode; }
            set { _airlineCode = value; }
        }
        private string _verkaufsWaehrung;
        public string VerkaufsWaehrung
        {
            get { return _verkaufsWaehrung; }
            set { _verkaufsWaehrung = value; }
        }
        private decimal? _netto;
        public decimal? Netto
        {
            get { return _netto; }
            set { _netto = value; }
        }
        private decimal? _mwSt;
        public decimal? MwSt
        {
            get { return _mwSt; }
            set { _mwSt = value; }
        }
        private string _abrechnungsWaehrung;
        public string AbrechnungsWaehrung
        {
            get { return _abrechnungsWaehrung; }
            set { _abrechnungsWaehrung = value; }
        }
        private decimal? _brutto;
        public decimal? Brutto
        {
            get { return _brutto; }
            set { _brutto = value; }
        }
        private string _details;
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }
        private string _personalID;
        public string PersonalID
        {
            get { return _personalID; }
            set { _personalID = value; }
        }
        private string _dienststelle;
        public string Dienststelle
        {
            get { return _dienststelle; }
            set { _dienststelle = value; }
        }
        private string _kostenstelle;
        public string Kostenstelle
        {
            get { return _kostenstelle; }
            set { _kostenstelle = value; }
        }
        private string _abrechnungseinheit;
        public string Abrechnungseinheit
        {
            get { return _abrechnungseinheit; }
            set { _abrechnungseinheit = value; }
        }
        private string _internesKonto;
        public string InternesKonto
        {
            get { return _internesKonto; }
            set { _internesKonto = value; }
        }
        private DateTime? _bearbeitungsdatum;
        public DateTime? Bearbeitungsdatum
        {
            get { return _bearbeitungsdatum; }
            set { _bearbeitungsdatum = value; }
        }
        private string _projektnummer;
        public string Projektnummer
        {
            get { return _projektnummer; }
            set { _projektnummer = value; }
        }
        private string _auftragsnummer;
        public string Auftragsnummer
        {
            get { return _auftragsnummer; }
            set { _auftragsnummer = value; }
        }
        private string _aktionsnummer;
        public string Aktionsnummer
        {
            get { return _aktionsnummer; }
            set { _aktionsnummer = value; }
        }
        private string _reiseziel;
        public string Reiseziel
        {
            get { return _reiseziel; }
            set { _reiseziel = value; }
        }
        private string _kundenreferenz;
        public string Kundenreferenz
        {
            get { return _kundenreferenz; }
            set { _kundenreferenz = value; }
        }
        private decimal? _nullrechnungsnummer;
        public decimal? Nullrechnungsnummer
        {
            get { return _nullrechnungsnummer; }
            set { _nullrechnungsnummer = value; }
        }
        private decimal? _mwStSatz;
        public decimal? MwStSatz
        {
            get { return _mwStSatz; }
            set { _mwStSatz = value; }
        }
        private decimal? _iATAnummer;
        public decimal? IATAnummer
        {
            get { return _iATAnummer; }
            set { _iATAnummer = value; }
        }
        private string _gebZeichen;
        public string GebZeichen
        {
            get { return _gebZeichen; }
            set { _gebZeichen = value; }
        }
        private string _cC_Leistungscode;
        public string CC_Leistungscode
        {
            get { return _cC_Leistungscode; }
            set { _cC_Leistungscode = value; }
        }
        private string _dOMKennzeichen;
        public string DOMKennzeichen
        {
            get { return _dOMKennzeichen; }
            set { _dOMKennzeichen = value; }
        }
        private DateTime? _fälligkeitstag;
        public DateTime? Fälligkeitstag
        {
            get { return _fälligkeitstag; }
            set { _fälligkeitstag = value; }
        }
        private decimal? _zusatzversicherung;
        public decimal? Zusatzversicherung
        {
            get { return _zusatzversicherung; }
            set { _zusatzversicherung = value; }
        }
        private string _leistungsbeschreibung1;
        public string Leistungsbeschreibung1
        {
            get { return _leistungsbeschreibung1; }
            set { _leistungsbeschreibung1 = value; }
        }
        private string _leistungsbeschreibung2;
        public string Leistungsbeschreibung2
        {
            get { return _leistungsbeschreibung2; }
            set { _leistungsbeschreibung2 = value; }
        }
        private string _leistungsbeschreibung3;
        public string Leistungsbeschreibung3
        {
            get { return _leistungsbeschreibung3; }
            set { _leistungsbeschreibung3 = value; }
        }
        private decimal? _gebuehren;
        public decimal? Gebuehren
        {
            get { return _gebuehren; }
            set { _gebuehren = value; }
        }
        private string _aIDANummer;
        public string AIDANummer
        {
            get { return _aIDANummer; }
            set { _aIDANummer = value; }
        }
        private string _mwstTyp;
        public string MwstTyp
        {
            get { return _mwstTyp; }
            set { _mwstTyp = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public override string Table { get { return "C_CSV_Item"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_CSV_Item_InsertOrUpdate"; } }
    }
    public enum C_CSV_ItemColumns
    {
        ID,
        C_CSV_HeaderID,
        Kartennummer,
        KarteninhaberName,
        KarteninhaberStadt,
        Rechnungsnummer,
        Rechnungsdatum,
        Bruttobetrag,
        Positionsnummer,
        Leistungsart,
        Dokumentennummer,
        Name,
        Routing,
        Leistungserbringer,
        VerkaufsDatum,
        ReiseDatum,
        Klasse,
        AirlineCode,
        VerkaufsWaehrung,
        Netto,
        MwSt,
        AbrechnungsWaehrung,
        Brutto,
        Details,
        PersonalID,
        Dienststelle,
        Kostenstelle,
        Abrechnungseinheit,
        InternesKonto,
        Bearbeitungsdatum,
        Projektnummer,
        Auftragsnummer,
        Aktionsnummer,
        Reiseziel,
        Kundenreferenz,
        Nullrechnungsnummer,
        MwStSatz,
        IATAnummer,
        GebZeichen,
        CC_Leistungscode,
        DOMKennzeichen,
        Fälligkeitstag,
        Zusatzversicherung,
        Leistungsbeschreibung1,
        Leistungsbeschreibung2,
        Leistungsbeschreibung3,
        Gebuehren,
        AIDANummer,
        MwstTyp,
        Email,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum C_CSV_ItemProcedure
    {
        p_C_CSV_GetProcessing,
        p_C_CSV_GetListByHeaderID
    }
    public class C_CSV_ItemList : List<C_CSV_Item>
    {

    }

    public class P_CSVImport
    {
        public C_CSV_Header C_CSV_Header { get; set; }
        public List<C_CSV_Item> ListC_CSV_Item { get; set; }

        public P_CSVImport()
        {
            C_CSV_Header = new C_CSV_Header();
            ListC_CSV_Item = new List<C_CSV_Item>();
        }
    }
}