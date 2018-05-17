using System;
using System.Collections;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Field
    /// </summary>
    public class FBFieldDTO
    {
        public string defaultValue { get; set; }
        public bool display { get; set; }
        public bool doubleEnter { get; set; }
        public bool enableFBDrive { get; set; }
        public int fbDriveSortOrder { get; set; }
        public long fieldId { get; set; }
        public ArrayList fieldOptions { get; set; }
        public long id { get; set; }
        public bool keyField { get; set; }
        public bool keyVisualField { get; set; }
        public string keyVisualMask { get; set; }
        public string mask { get; set; }
        public long maxLen { get; set; }
        public long minLen { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public long order { get; set; }
        public long projectId { get; set; }
        public long projectLinkId { get; set; }
        public System.Collections.Generic.List<FBProjectLinkFieldDTO> projectLinkOptions { get; set; }
        public long remoteID { get; set; }
        public bool required { get; set; }
        public bool sepRelation { get; set; }
        public bool showOnHomePage { get; set; }
        public bool sortField { get; set; }
        public bool storePLinkDataset { get; set; }
        public FBEnums.FieldType type { get; set; }
        public bool unique { get; set; }
        public FBEnums.ViewerContextType viewerContext { get; set; }
        public bool isLookupKey { get; set; }

        public string FieldDataType { get;set; }
    }

    public class SQLFieldDTO
    {
        public int FieldID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Number { get; set; }
        public short Type { get; set; }
        public int Display { get; set; }
        public Nullable<int> Order { get; set; }
        public string Mask { get; set; }
        public Nullable<short> Required { get; set; }
        public int KeyField { get; set; }
        public Nullable<int> KeyVisualField { get; set; }
        public string KeyVisualMask { get; set; }
        public Nullable<int> MinLen { get; set; }
        public Nullable<int> MaxLen { get; set; }
        public Nullable<int> SortField { get; set; }
        public Nullable<int> Unique { get; set; }
        public string FieldOptions { get; set; }
        public Nullable<int> SepRelation { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<int> DoubleEnter { get; set; }
        public Nullable<int> ShowOnHomePage { get; set; }
        public Nullable<int> RemoteID { get; set; }
        public Nullable<bool> EnableFBDrive { get; set; }
        public Nullable<int> FBDriveSortOrder { get; set; }
    }
}


