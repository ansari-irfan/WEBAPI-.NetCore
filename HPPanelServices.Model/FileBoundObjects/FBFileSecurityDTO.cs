namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#FileSecurity
    /// </summary>
    public class FBFileSecurityDTO
    {
        /// <summary>
        /// The number of the Field associated with this FileSecurity
        /// </summary>
        public long fieldNumber { get; set; }
        /// <summary>
        /// The ID of this FileSecurity
        /// </summary>
        public long fileSecurityId { get; set; }
        /// <summary>
        /// The ID of the Group associated with this FileSecurity
        /// </summary>
        public long groupId { get; set; }
        /// <summary>
        /// The index restrictions for this FileSecurity
        /// </summary>
        public string indexes { get; set; }
        /// <summary>
        /// The ID of the Project associated with this FileSecurity
        /// </summary>
        public long projectId { get; set; }

    }
}
