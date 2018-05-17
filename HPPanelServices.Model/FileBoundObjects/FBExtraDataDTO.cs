using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#ExtraData
    /// </summary>
    public class FBExtraDataDTO
    {
        /// <summary>
        /// ID of the File in which this ExtraData is associated
        /// </summary>
        public int fileId { get; set; }
        /// <summary>
        /// The variable name for this ExtraData
        /// </summary>
        public string variable { get; set; }
        /// <summary>
        /// The value of this ExtraData
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// ID of the Document in which this ExtraData is associated
        /// </summary>
        public int documentId { get; set; }
        /// <summary>
        /// The last time this ExtraData was updated
        /// </summary>
        public DateTime lastUpdated { get; set; }
        /// <summary>
        /// The last User to have updated this ExtraData
        /// </summary>
        public string lastUpdatedBy { get; set; }
    }
}
