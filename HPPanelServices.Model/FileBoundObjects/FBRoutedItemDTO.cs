using System;
using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#RoutedItem
    /// </summary>
    public class FBRoutedItemDTO
    {
        /// <summary>
        /// Flag as to whether or not to use password authentication when step is processed
        /// </summary>
        public bool Authenticate { get; set; }
        /// <summary>
        /// 	BatchDate for the routed item
        /// </summary>
        public DateTime BatchDate { get; set; }
        /// <summary>
        /// The user who routed this item
        /// </summary>
        public int ByUserId { get; set; }
        /// <summary>
        /// The Name of the user from whom this item was routed
        /// </summary>
        public string ByUserName { get; set; }
        /// <summary>
        /// 	The ID of the RoutedItem that called this RoutedItem
        /// </summary>
        public int CallingRoutedItemId { get; set; }
        /// <summary>
        /// The comments about this routed item
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 	The Date/Time this item was completed
        /// </summary>
        public DateTime Completed { get; set; }
        /// <summary>
        /// The direction this route is going
        /// </summary>
        public RoutedItemDirection Direction { get; set; }
        /// <summary>
        /// 	Divider for the routed item
        /// </summary>
        public string Divider { get; set; }
        /// <summary>
        /// The Date/Time this item is due to be completed
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Extension for the routed item
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// Find all files that match these field values. For range searches (Numeric and Date) this holds the FROM value.
        /// </summary>
        public string[] Field { get; set; }
        /// <summary>
        /// Whether or not this was the final step in the workflow
        /// </summary>
        public bool FinalStep { get; set; }
        /// <summary>
        /// 	Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 	IDCode from the related RouteStep
        /// </summary>
        public dynamic IdCode { get; set; }
        public bool LocalTreeOnly { get; set; }
        /// <summary>
        /// 	Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        public int Overdue { get; set; }
        /// <summary>
        /// The ID of the User who originated this workflow
        /// </summary>
        public int OriginatorId { get; set; }
        /// <summary>
        /// 	The ID of the RoutedItem that parented this one
        /// </summary>
        public int ParentRoutedItemId { get; set; }
        /// <summary>
        /// Date/Time this item was processed by the Server Monitor
        /// </summary>
        public DateTime ProcessDate { get; set; }
        /// <summary>
        /// Whether or not this item was processed by the Server Monitor
        /// </summary>
        public int ProcessFlag { get; set; }
        public int ProjectId { get; set; }
        /// <summary>
        /// Prompt to show the user when attempting to complete the step
        /// </summary>
        public string PromptComplete { get; set; }
        /// <summary>
        /// Prompt to show the user when attempting to reject the step
        /// </summary>
        public string PromptReject { get; set; }
        /// <summary>
        /// Flag as to whether or not to prompt for notes when completing a step
        /// </summary>
        public bool PromptUser { get; set; }
        public bool QueuedItems { get; set; }
        /// <summary>
        /// 	ID of the Box that this RoutedItem is related to
        /// </summary>
        public int RelBoxId { get; set; }
        /// <summary>
        /// ID of the File that this RoutedItem is related to
        /// </summary>
        public int RelFileId { get; set; }
        /// <summary>
        /// The ID of the Routed Item
        /// </summary>
        public int RoutedItemId { get; set; }
        /// <summary>
        /// The ID of the object being routed
        /// </summary>
        public long RoutedObjectId { get; set; }
        /// <summary>
        /// The type of object being routed
        /// </summary>
        public ObjectType RoutedObjectType { get; set; }
        /// <summary>
        /// The ID of the Route in which this item is being routed
        /// </summary>
        public int RouteId { get; set; }
        /// <summary>
        /// Name of the route which the item is routed down
        /// </summary>
        public string RouteName { get; set; }
        /// <summary>
        /// The ID of the RoutePath of this Document on this Route
        /// </summary>
        public int RoutePathId { get; set; }
        /// <summary>
        /// The RouteStep Description for this RoutedItem
        /// </summary>
        public object RouteStepDescription { get; set; }
        /// <summary>
        /// 	The ID of the Route Step this item is on
        /// </summary>
        public int RouteStepId { get; set; }
        public object RouteStepName { get; set; }
        /// <summary>
        /// Whether or not to wait for this step to complete before moving on
        /// </summary>
        public RouteWaitState RouteWait { get; set; }
        /// <summary>
        /// Separator for the routed item
        /// </summary>
        public string Separator { get; set; }
        /// <summary>
        /// 	Flag as to whether or not to show the complete button
        /// </summary>
        public bool ShowButtonComplete { get; set; }
        /// <summary>
        /// 	Flag as to whether or not to show the reassign button
        /// </summary>
        public bool ShowButtonReassign { get; set; }
        /// <summary>
        /// Flag as to whether or not to show the reject button
        /// </summary>
        public bool ShowButtonReject { get; set; }
        /// <summary>
        /// 	The ID of the RoutedItem that was called by this RoutedItem
        /// </summary>
        public int SiblingRoutedItemId { get; set; }
        /// <summary>
        /// The Date/Time this item was started
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// The status of the routed item
        /// </summary>
        public RoutedItemStatus Status { get; set; }
        /// <summary>
        /// The Date/Time this item was started
        /// </summary>
        public RouteStepStatusFlag StatusFlag { get; set; }
        /// <summary>
        /// 	The step name at which this item is
        /// </summary>
        public string StepName { get; set; }
        /// <summary>
        /// The step number at which this item is
        /// </summary>
        public int StepNumber { get; set; }
        /// <summary>
        /// 	Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag SyncFlag { get; set; }
        /// <summary>
        /// True if Document tied to this RoutedItem does not have an extension of ".msg" or ".txt". Right now, this is only set by method "Get RoutedItems by RoutedItem ID" if visualWorkflow is true.
        /// </summary>
        public bool VisualWorkflowThumbnailView { get; set; }
        /// <summary>
        /// The ID of the user to whom this item is routed
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 	The Name of the user to whom this item is routed
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 	Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType ViewerContext { get; set; }
    }
}
