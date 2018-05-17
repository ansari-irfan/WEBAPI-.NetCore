using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Divider
    /// </summary>
    public class FBDividerDTO
    {
        /// <summary>
        /// Alias Name
        /// </summary>
        public string aliasName { get; set; }
        /// <summary>
        /// The ID of the Divider
        /// </summary>
        public long dividerId { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// Divider Name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The normalized Divider name
        /// </summary>
        public string normalizedName { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType objectType { get; set; }
        /// <summary>
        /// The ID of the Project that contains this Divider
        /// </summary>
        public long projectId { get; set; }
        /// <summary>
        /// The name of the Separator that this Divider is in 
        /// (will be empty string if there is no related Separator)
        /// </summary>
        public string separator { get; set; }
        /// <summary>
        /// The sort order for this Divider
        /// </summary>
        public long sortOrder { get; set; }
    }
}
