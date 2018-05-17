using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#Separator
    /// </summary>
    public class FBSeparatorDTO
    {
        /// <summary>
        /// Alias name of this Separator. Aliases allow the Separator name to be populated with more than one name.
        /// </summary>
        public string AliasName { get; set; }
        public int GroupId { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType Id { get; set; }
        /// <summary>
        /// The name of this Separator
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 	Normalized name of this Separator. When emailing or exporting documents, the normalized name is used when it is set.
        /// </summary>
        public string NormalizedName { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        /// <summary>
        /// The ID of the Project in which this Separator is contained
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// 	The ID of this Separator
        /// </summary>
        public int SeparatorId { get; set; }
        /// <summary>
        /// 	The value to match up with in the File Field value in order to show this Separator as a choice.
        /// </summary>
        public string SepRelation { get; set; }
        /// <summary>
        /// The default order for this divider to Separator. Sorting is done by SortOrder then Name.
        /// </summary>
        public int SortOrder { get; set; }
    }
}
