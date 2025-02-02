// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_spddatarow
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioSpddatarow
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpddatarow class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpddatarow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioSpddatarow class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioSpddatarow(string adoxioPreviouspostalcode3 = default(string), string adoxioPreviouspostalcode2 = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioPreviousprovstate1 = default(string), string adoxioPreviousstreetaddress8 = default(string), bool? adoxioIsexport = default(bool?), string adoxioPreviousprovstatex = default(string), int? statecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioPreviousprovstate2 = default(string), string adoxioAlias2middlename = default(string), string adoxioPreviousprovstate6 = default(string), string adoxioSelfdisclosureyn = default(string), int? importsequencenumber = default(int?), string adoxioPreviouscountry7 = default(string), string adoxioPreviouscity7 = default(string), string adoxioAlias5surname = default(string), string _createdbyValue = default(string), string adoxioPreviouscountry1 = default(string), string adoxioPreviouscountry4 = default(string), string adoxioPreviousstreetaddress7 = default(string), string adoxioPreviouscity5 = default(string), string adoxioBcidentificationcardnumber = default(string), string adoxioPreviouspostalcode6 = default(string), string adoxioLcrbbusinessjobid = default(string), string adoxioAlias3middlename = default(string), System.DateTimeOffset? adoxioExporteddate = default(System.DateTimeOffset?), string versionnumber = default(string), string adoxioAlias5middlename = default(string), string adoxioLcrbworkerjobid = default(string), string adoxioAlias4surname = default(string), string adoxioPreviousprovstate4 = default(string), string _adoxioSpdexportValue = default(string), string _modifiedonbehalfbyValue = default(string), string adoxioPreviouscountry6 = default(string), int? statuscode = default(int?), string adoxioAlias2surname = default(string), int? utcconversiontimezonecode = default(int?), string adoxioAddressline1 = default(string), string _owningteamValue = default(string), string adoxioGendermf = default(string), string adoxioAlias3surname = default(string), string adoxioContactphone = default(string), string adoxioAlias5firstname = default(string), string adoxioLegalsurname = default(string), string adoxioPreviouscity8 = default(string), string adoxioPreviousstreetaddress2 = default(string), string adoxioAddresscountry = default(string), string adoxioPreviouscity3 = default(string), string adoxioPreviouscity4 = default(string), string adoxioPreviouscountryx = default(string), string adoxioParcelidnumber = default(string), string adoxioAddresscity = default(string), string adoxioPreviouscity1 = default(string), string adoxioPreviousstreetaddress1 = default(string), bool? adoxioSelfdisclosure = default(bool?), string adoxioAlias1surname = default(string), string adoxioPreviousstreetaddress5 = default(string), string adoxioAlias2firstname = default(string), string adoxioDriverslicence = default(string), string adoxioPreviousprovstate7 = default(string), string adoxioAlias3firstname = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioPreviousstreetaddress3 = default(string), string adoxioPreviousprovstate9 = default(string), string adoxioLegalfirstname = default(string), string adoxioPreviouscity6 = default(string), string adoxioBirthdate = default(string), string _owninguserValue = default(string), string adoxioAlias4firstname = default(string), string _createdonbehalfbyValue = default(string), string adoxioAlias1middlename = default(string), string adoxioPreviousstreetaddress9 = default(string), string adoxioPreviouspostalcode1 = default(string), string adoxioSpddatarowid = default(string), int? timezoneruleversionnumber = default(int?), string adoxioPreviouscountry5 = default(string), string adoxioPreviouspostalcode9 = default(string), string adoxioPreviousprovstate5 = default(string), string adoxioPreviousprovstate8 = default(string), string adoxioPreviousstreetaddress4 = default(string), string adoxioLcrbassociatejobid = default(string), string adoxioPreviouspostalcode7 = default(string), string adoxioAlias4middlename = default(string), string adoxioAlias1firstname = default(string), string adoxioAddressprovstate = default(string), string adoxioPreviouscountry2 = default(string), string adoxioPreviouspostalcode5 = default(string), string adoxioPersonalemailaddress = default(string), string adoxioPreviousstreetaddressx = default(string), string adoxioPreviousprovstate3 = default(string), string adoxioPreviouscountry3 = default(string), string adoxioPreviouscountry9 = default(string), string _owningbusinessunitValue = default(string), string adoxioLegalmiddlename = default(string), string adoxioPreviouscountry8 = default(string), string adoxioBirthplacecity = default(string), string adoxioPreviousstreetaddress6 = default(string), string adoxioPreviouspostalcodex = default(string), string adoxioName = default(string), string _owneridValue = default(string), string adoxioPreviouspostalcode8 = default(string), string adoxioBcregistriesnumber = default(string), string adoxioPreviouspostalcode4 = default(string), string adoxioPreviouscity9 = default(string), string adoxioPreviouscityx = default(string), string adoxioPreviouscity2 = default(string), string adoxioAddresspostalcode = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioSpddatarowSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioSpddatarowAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> adoxioSpddatarowMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> adoxioSpddatarowProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioSpddatarowBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> adoxioSpddatarowPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMadoxioSpdexports adoxioSPDExport = default(MicrosoftDynamicsCRMadoxioSpdexports))
        {
            AdoxioPreviouspostalcode3 = adoxioPreviouspostalcode3;
            AdoxioPreviouspostalcode2 = adoxioPreviouspostalcode2;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            AdoxioPreviousprovstate1 = adoxioPreviousprovstate1;
            AdoxioPreviousstreetaddress8 = adoxioPreviousstreetaddress8;
            AdoxioIsexport = adoxioIsexport;
            AdoxioPreviousprovstatex = adoxioPreviousprovstatex;
            Statecode = statecode;
            Createdon = createdon;
            AdoxioPreviousprovstate2 = adoxioPreviousprovstate2;
            AdoxioAlias2middlename = adoxioAlias2middlename;
            AdoxioPreviousprovstate6 = adoxioPreviousprovstate6;
            AdoxioSelfdisclosureyn = adoxioSelfdisclosureyn;
            Importsequencenumber = importsequencenumber;
            AdoxioPreviouscountry7 = adoxioPreviouscountry7;
            AdoxioPreviouscity7 = adoxioPreviouscity7;
            AdoxioAlias5surname = adoxioAlias5surname;
            this._createdbyValue = _createdbyValue;
            AdoxioPreviouscountry1 = adoxioPreviouscountry1;
            AdoxioPreviouscountry4 = adoxioPreviouscountry4;
            AdoxioPreviousstreetaddress7 = adoxioPreviousstreetaddress7;
            AdoxioPreviouscity5 = adoxioPreviouscity5;
            AdoxioBcidentificationcardnumber = adoxioBcidentificationcardnumber;
            AdoxioPreviouspostalcode6 = adoxioPreviouspostalcode6;
            AdoxioLcrbbusinessjobid = adoxioLcrbbusinessjobid;
            AdoxioAlias3middlename = adoxioAlias3middlename;
            AdoxioExporteddate = adoxioExporteddate;
            Versionnumber = versionnumber;
            AdoxioAlias5middlename = adoxioAlias5middlename;
            AdoxioLcrbworkerjobid = adoxioLcrbworkerjobid;
            AdoxioAlias4surname = adoxioAlias4surname;
            AdoxioPreviousprovstate4 = adoxioPreviousprovstate4;
            this._adoxioSpdexportValue = _adoxioSpdexportValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioPreviouscountry6 = adoxioPreviouscountry6;
            Statuscode = statuscode;
            AdoxioAlias2surname = adoxioAlias2surname;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioAddressline1 = adoxioAddressline1;
            this._owningteamValue = _owningteamValue;
            AdoxioGendermf = adoxioGendermf;
            AdoxioAlias3surname = adoxioAlias3surname;
            AdoxioContactphone = adoxioContactphone;
            AdoxioAlias5firstname = adoxioAlias5firstname;
            AdoxioLegalsurname = adoxioLegalsurname;
            AdoxioPreviouscity8 = adoxioPreviouscity8;
            AdoxioPreviousstreetaddress2 = adoxioPreviousstreetaddress2;
            AdoxioAddresscountry = adoxioAddresscountry;
            AdoxioPreviouscity3 = adoxioPreviouscity3;
            AdoxioPreviouscity4 = adoxioPreviouscity4;
            AdoxioPreviouscountryx = adoxioPreviouscountryx;
            AdoxioParcelidnumber = adoxioParcelidnumber;
            AdoxioAddresscity = adoxioAddresscity;
            AdoxioPreviouscity1 = adoxioPreviouscity1;
            AdoxioPreviousstreetaddress1 = adoxioPreviousstreetaddress1;
            AdoxioSelfdisclosure = adoxioSelfdisclosure;
            AdoxioAlias1surname = adoxioAlias1surname;
            AdoxioPreviousstreetaddress5 = adoxioPreviousstreetaddress5;
            AdoxioAlias2firstname = adoxioAlias2firstname;
            AdoxioDriverslicence = adoxioDriverslicence;
            AdoxioPreviousprovstate7 = adoxioPreviousprovstate7;
            AdoxioAlias3firstname = adoxioAlias3firstname;
            Overriddencreatedon = overriddencreatedon;
            AdoxioPreviousstreetaddress3 = adoxioPreviousstreetaddress3;
            AdoxioPreviousprovstate9 = adoxioPreviousprovstate9;
            AdoxioLegalfirstname = adoxioLegalfirstname;
            AdoxioPreviouscity6 = adoxioPreviouscity6;
            AdoxioBirthdate = adoxioBirthdate;
            this._owninguserValue = _owninguserValue;
            AdoxioAlias4firstname = adoxioAlias4firstname;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioAlias1middlename = adoxioAlias1middlename;
            AdoxioPreviousstreetaddress9 = adoxioPreviousstreetaddress9;
            AdoxioPreviouspostalcode1 = adoxioPreviouspostalcode1;
            AdoxioSpddatarowid = adoxioSpddatarowid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioPreviouscountry5 = adoxioPreviouscountry5;
            AdoxioPreviouspostalcode9 = adoxioPreviouspostalcode9;
            AdoxioPreviousprovstate5 = adoxioPreviousprovstate5;
            AdoxioPreviousprovstate8 = adoxioPreviousprovstate8;
            AdoxioPreviousstreetaddress4 = adoxioPreviousstreetaddress4;
            AdoxioLcrbassociatejobid = adoxioLcrbassociatejobid;
            AdoxioPreviouspostalcode7 = adoxioPreviouspostalcode7;
            AdoxioAlias4middlename = adoxioAlias4middlename;
            AdoxioAlias1firstname = adoxioAlias1firstname;
            AdoxioAddressprovstate = adoxioAddressprovstate;
            AdoxioPreviouscountry2 = adoxioPreviouscountry2;
            AdoxioPreviouspostalcode5 = adoxioPreviouspostalcode5;
            AdoxioPersonalemailaddress = adoxioPersonalemailaddress;
            AdoxioPreviousstreetaddressx = adoxioPreviousstreetaddressx;
            AdoxioPreviousprovstate3 = adoxioPreviousprovstate3;
            AdoxioPreviouscountry3 = adoxioPreviouscountry3;
            AdoxioPreviouscountry9 = adoxioPreviouscountry9;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioLegalmiddlename = adoxioLegalmiddlename;
            AdoxioPreviouscountry8 = adoxioPreviouscountry8;
            AdoxioBirthplacecity = adoxioBirthplacecity;
            AdoxioPreviousstreetaddress6 = adoxioPreviousstreetaddress6;
            AdoxioPreviouspostalcodex = adoxioPreviouspostalcodex;
            AdoxioName = adoxioName;
            this._owneridValue = _owneridValue;
            AdoxioPreviouspostalcode8 = adoxioPreviouspostalcode8;
            AdoxioBcregistriesnumber = adoxioBcregistriesnumber;
            AdoxioPreviouspostalcode4 = adoxioPreviouspostalcode4;
            AdoxioPreviouscity9 = adoxioPreviouscity9;
            AdoxioPreviouscityx = adoxioPreviouscityx;
            AdoxioPreviouscity2 = adoxioPreviouscity2;
            AdoxioAddresspostalcode = adoxioAddresspostalcode;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioSpddatarowSyncErrors = adoxioSpddatarowSyncErrors;
            AdoxioSpddatarowAsyncOperations = adoxioSpddatarowAsyncOperations;
            AdoxioSpddatarowMailboxTrackingFolders = adoxioSpddatarowMailboxTrackingFolders;
            AdoxioSpddatarowProcessSession = adoxioSpddatarowProcessSession;
            AdoxioSpddatarowBulkDeleteFailures = adoxioSpddatarowBulkDeleteFailures;
            AdoxioSpddatarowPrincipalObjectAttributeAccesses = adoxioSpddatarowPrincipalObjectAttributeAccesses;
            AdoxioSPDExport = adoxioSPDExport;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode3")]
        public string AdoxioPreviouspostalcode3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode2")]
        public string AdoxioPreviouspostalcode2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate1")]
        public string AdoxioPreviousprovstate1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress8")]
        public string AdoxioPreviousstreetaddress8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isexport")]
        public bool? AdoxioIsexport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstatex")]
        public string AdoxioPreviousprovstatex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate2")]
        public string AdoxioPreviousprovstate2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias2middlename")]
        public string AdoxioAlias2middlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate6")]
        public string AdoxioPreviousprovstate6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosureyn")]
        public string AdoxioSelfdisclosureyn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry7")]
        public string AdoxioPreviouscountry7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity7")]
        public string AdoxioPreviouscity7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias5surname")]
        public string AdoxioAlias5surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry1")]
        public string AdoxioPreviouscountry1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry4")]
        public string AdoxioPreviouscountry4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress7")]
        public string AdoxioPreviousstreetaddress7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity5")]
        public string AdoxioPreviouscity5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcidentificationcardnumber")]
        public string AdoxioBcidentificationcardnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode6")]
        public string AdoxioPreviouspostalcode6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lcrbbusinessjobid")]
        public string AdoxioLcrbbusinessjobid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias3middlename")]
        public string AdoxioAlias3middlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_exporteddate")]
        public System.DateTimeOffset? AdoxioExporteddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias5middlename")]
        public string AdoxioAlias5middlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lcrbworkerjobid")]
        public string AdoxioLcrbworkerjobid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias4surname")]
        public string AdoxioAlias4surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate4")]
        public string AdoxioPreviousprovstate4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_spdexport_value")]
        public string _adoxioSpdexportValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry6")]
        public string AdoxioPreviouscountry6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias2surname")]
        public string AdoxioAlias2surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressline1")]
        public string AdoxioAddressline1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gendermf")]
        public string AdoxioGendermf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias3surname")]
        public string AdoxioAlias3surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactphone")]
        public string AdoxioContactphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias5firstname")]
        public string AdoxioAlias5firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalsurname")]
        public string AdoxioLegalsurname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity8")]
        public string AdoxioPreviouscity8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress2")]
        public string AdoxioPreviousstreetaddress2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresscountry")]
        public string AdoxioAddresscountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity3")]
        public string AdoxioPreviouscity3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity4")]
        public string AdoxioPreviouscity4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountryx")]
        public string AdoxioPreviouscountryx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_parcelidnumber")]
        public string AdoxioParcelidnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresscity")]
        public string AdoxioAddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity1")]
        public string AdoxioPreviouscity1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress1")]
        public string AdoxioPreviousstreetaddress1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosure")]
        public bool? AdoxioSelfdisclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias1surname")]
        public string AdoxioAlias1surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress5")]
        public string AdoxioPreviousstreetaddress5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias2firstname")]
        public string AdoxioAlias2firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicence")]
        public string AdoxioDriverslicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate7")]
        public string AdoxioPreviousprovstate7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias3firstname")]
        public string AdoxioAlias3firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress3")]
        public string AdoxioPreviousstreetaddress3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate9")]
        public string AdoxioPreviousprovstate9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalfirstname")]
        public string AdoxioLegalfirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity6")]
        public string AdoxioPreviouscity6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthdate")]
        public string AdoxioBirthdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias4firstname")]
        public string AdoxioAlias4firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias1middlename")]
        public string AdoxioAlias1middlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress9")]
        public string AdoxioPreviousstreetaddress9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode1")]
        public string AdoxioPreviouspostalcode1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarowid")]
        public string AdoxioSpddatarowid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry5")]
        public string AdoxioPreviouscountry5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode9")]
        public string AdoxioPreviouspostalcode9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate5")]
        public string AdoxioPreviousprovstate5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate8")]
        public string AdoxioPreviousprovstate8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress4")]
        public string AdoxioPreviousstreetaddress4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lcrbassociatejobid")]
        public string AdoxioLcrbassociatejobid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode7")]
        public string AdoxioPreviouspostalcode7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias4middlename")]
        public string AdoxioAlias4middlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alias1firstname")]
        public string AdoxioAlias1firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressprovstate")]
        public string AdoxioAddressprovstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry2")]
        public string AdoxioPreviouscountry2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode5")]
        public string AdoxioPreviouspostalcode5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalemailaddress")]
        public string AdoxioPersonalemailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddressx")]
        public string AdoxioPreviousstreetaddressx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousprovstate3")]
        public string AdoxioPreviousprovstate3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry3")]
        public string AdoxioPreviouscountry3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry9")]
        public string AdoxioPreviouscountry9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalmiddlename")]
        public string AdoxioLegalmiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscountry8")]
        public string AdoxioPreviouscountry8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthplacecity")]
        public string AdoxioBirthplacecity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previousstreetaddress6")]
        public string AdoxioPreviousstreetaddress6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcodex")]
        public string AdoxioPreviouspostalcodex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode8")]
        public string AdoxioPreviouspostalcode8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcregistriesnumber")]
        public string AdoxioBcregistriesnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouspostalcode4")]
        public string AdoxioPreviouspostalcode4 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity9")]
        public string AdoxioPreviouscity9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscityx")]
        public string AdoxioPreviouscityx { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_previouscity2")]
        public string AdoxioPreviouscity2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresspostalcode")]
        public string AdoxioAddresspostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioSpddatarowSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioSpddatarowAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> AdoxioSpddatarowMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> AdoxioSpddatarowProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioSpddatarowBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_spddatarow_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> AdoxioSpddatarowPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_SPDExport")]
        public MicrosoftDynamicsCRMadoxioSpdexports AdoxioSPDExport { get; set; }

    }
}
