using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#Route
    /// </summary>
    public class FBRouteDTO
    {
        /// <summary>
        /// Idicates whether or not to use only business days in due date calculations.
        /// </summary>
        public bool BusinessDays { get; set; }
        /// <summary>
        /// 	The display name of the Route
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The ID of the Route's Exception Steps User
        /// </summary>
        public int ExceptionStepUserId { get; set; }
        /// <summary>
        /// Whether or not this Route is hidden
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// 	Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType Id { get; set; }
        /// <summary>
        /// True if Route is an Automation Process (i.e. ActiveDirectory, GlobalSearch, AutoOCR, etc.)
        /// </summary>
        public bool IsAutomationProcess { get; set; }
        /// <summary>
        /// The LastRunDate for Automation Processes
        /// </summary>
        public string LastRunDate { get; set; }
        /// <summary>
        /// The name of the Route
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The NextRunDate for Automation Processes
        /// </summary>
        public string NextRunDate { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        /// <summary>
        /// 	The RouteID of the Parent Process
        /// </summary>
        public int ParentRouteId { get; set; }
        /// <summary>
        /// 	The name of the Parent Process
        /// </summary>
        public object ParentRouteName { get; set; }
        /// <summary>
        /// Parent Process Type
        /// </summary>
        public RouteType ParentRouteType { get; set; }
        /// <summary>
        /// The ID of the process
        /// </summary>
        public int ProcessId { get; set; }
        /// <summary>
        /// 	The ID of the project in which this Route is defined
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// The collection of Revisions tied to this Route
        /// </summary>
        public FBCollection Revisions { get; set; }
        /// <summary>
        /// 	The collection of RoutedItems tied to this Route
        /// </summary>
        public FBCollection RoutedItems { get; set; }
        /// <summary>
        /// 	The ID of this Route
        /// </summary>
        public int RouteId { get; set; }
        /// <summary>
        /// 	Idicates the Routed Item Type Regular, or Process
        /// </summary>
        public RouteType RouteType { get; set; }
        /// <summary>
        /// Indicates whether the item is Scheduled or not, specifically for Automation
        /// </summary>
        public bool Scheduled { get; set; }
        /// <summary>
        /// 	Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag SyncFlag { get; set; }
        /// <summary>
        /// Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType Type { get; set; }
        public int ViewerContext { get; set; }
        /// <summary>
        /// XML representation of this Route
        /// </summary>
        public string Xml { get; set; }
    }
}
