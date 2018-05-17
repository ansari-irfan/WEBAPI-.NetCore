using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#RouteStepTask
    /// </summary>
    public class FBRouteStepTaskDTO
    {
        /// <summary>
        /// The action to take relative to the action type. This is used for ActionTypes of NewRoute (ID of route to send document) and PlugIn (ID of Plug-In to execute).
        /// </summary>
        public int ActionNum { get; set; }
        /// <summary>
        /// The type of action to take when clicked.
        /// </summary>
        public RouteStepTaskButtonAction ActionType { get; set; }
        /// <summary>
        /// The Number of the AutoStep item in question. Valid for 'Move' type where this is the step number to move to.
        /// </summary>
        public int AutoNum { get; set; }
        /// <summary>
        /// The workflow action to take (accept, reject, etc.)
        /// </summary>
        public RouteStepTaskWorkflowAction AutoStep { get; set; }
        /// <summary>
        /// 	The caption to use for the task button
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// The child route to send the route to
        /// </summary>
        public int ChildRouteId { get; set; }
        /// <summary>
        /// The icon number to use when displaying the task button
        /// </summary>
        public int IconNumber { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType Id { get; set; }
        /// <summary>
        /// The description of this RouteStepTask
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 	Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        /// <summary>
        /// The ID of the RouteStep this task relates to
        /// </summary>
        public int RouteStepId { get; set; }
        /// <summary>
        /// The ID of this RouteStepTask
        /// </summary>
        public int RouteStepTaskId { get; set; }
        /// <summary>
        /// 	Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag SyncFlag { get; set; }
        /// <summary>
        /// 	The order in which the task button shows up relative to other buttons
        /// </summary>
        public int TaskOrder { get; set; }
        /// <summary>
        /// The User Pick List to display if needed
        /// </summary>
        public string UserPickerFilter { get; set; }
        /// <summary>
        /// 	Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType ViewerContext { get; set; }
    }
}
