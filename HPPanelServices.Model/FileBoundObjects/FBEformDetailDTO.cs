using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#EformDetail
    /// </summary>
    public class FBEformDetailDTO
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
        /// Row number in the detail form in which this data resides
        /// </summary>
        public long row { get; set; }
        /// <summary>
        /// The last time this EformData was updated
        /// </summary>
        public DateTime lastUpdated { get; set; }
        /// <summary>
        /// The last User to have updated this EformData
        /// </summary>
        public long lastUpdatedBy { get; set; }

    }
}
