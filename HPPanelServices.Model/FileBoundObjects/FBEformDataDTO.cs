using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#EformData
    /// </summary>
    public class FBEformDataDTO
    {
        /// <summary>
        /// ID of the document in which this EformData is associated
        /// </summary>
        public long documentId { get; set; }
        /// <summary>
        /// The date that this EformData was filled
        /// </summary>
        public DateTime filledDate { get; set; }
        /// <summary>
        /// The name of the field
        /// </summary>
        public string fieldName { get; set; }
        /// <summary>
        /// The value of the field
        /// </summary>
        public string fieldValue { get; set; }
        /// <summary>
        /// The last time this EformData was updated
        /// </summary>
        public DateTime lastUpdated { get; set; }
        /// <summary>
        /// The last User to have updated this EformData
        /// </summary>
        public long lastUpdatedBy { get; set; }
        /// <summary>
        /// ID of the process by which this EformData was generated
        /// </summary>
        public long processId { get; set; }
        /// <summary>
        /// The Separator with which this EformData is associated
        /// </summary>
        public string separator { get; set; }
    }
}
