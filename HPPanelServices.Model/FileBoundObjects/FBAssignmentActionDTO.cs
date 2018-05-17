using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#AssignmentAction
    /// </summary>
    public class FBAssignmentActionDTO
    {
        /// <summary>
        /// The name of the icon for this AssignmentAction button
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// The caption for this AssignmentAction button
        /// </summary>
        public string caption { get; set; }
        /// <summary>
        /// The type of action that this button will make
        /// </summary>
        public AssignmentActionType action { get; set; }
        /// <summary>
        /// Whether or not the action is browseable (i.e. a plugin)
        /// </summary>
        public bool browseable { get; set; }
        /// <summary>
        /// The RouteStepID
        /// </summary>
        public long routeStepId { get; set; }
        /// <summary>
        /// Whether or not this action requires authentication
        /// </summary>
        public bool authenticate { get; set; }
        /// <summary>
        /// Whether or not this action will prompt for notes
        /// </summary>
        public bool notes { get; set; }
        /// <summary>
        /// A message prompt (if not empty string, the message will be prompted with this action)
        /// </summary>
        public string prompt { get; set; }
        /// <summary>
        /// The RouteStepTaskID. Will be 0 if the RouteStepTask does not have a Checklist.
        /// </summary>
        public long checklistRouteStepTaskId { get; set; }
        /// <summary>
        /// The URL that will be called to perform the action, usually a call back to the API.
        /// </summary>
        public string actionLink { get; set; }
    }
}
