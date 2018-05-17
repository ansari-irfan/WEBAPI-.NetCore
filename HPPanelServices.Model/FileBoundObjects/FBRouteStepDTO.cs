using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#RouteStep
    /// </summary>
    public class FBRouteStepDTO
    {
        /// <summary>
        /// Whether or not to verify the user by having them enter their password
        /// </summary>
        public bool Authenticate { get; set; }
        /// <summary>
        /// 	An in-depth description of the actions which should be taken at this Step
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of days in which this step is due
        /// </summary>
        public int DueDays { get; set; }
        /// <summary>
        /// Sets the due date of this step to the date in the field specified
        /// </summary>
        public int DueField { get; set; }
        /// <summary>
        /// The number of hours in which this step is due
        /// </summary>
        public int DueHours { get; set; }
        /// <summary>
        /// When to execute: The field number to compare to see whether or not to execute
        /// </summary>
        public int FieldNumber { get; set; }
        /// <summary>
        /// 	When to execute: The field value to compare the field value to in deciding whether or not to execute
        /// </summary>
        public string FieldValue { get; set; }
        /// <summary>
        /// 	The list of Group names responsible for this step if multi-step
        /// </summary>
        public string GroupNameList { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType Id { get; set; }
        /// <summary>
        /// A Special ID on the RouteStep for use in Custom Coding
        /// </summary>
        public string IdCode { get; set; }
        /// <summary>
        /// The name of this RouteStep
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Route ID to process (Child Route) when this RouteStep is executed
        /// </summary>
        public int NextRouteId { get; set; }
        /// <summary>
        /// 	Whether or not to notify users via email
        /// </summary>
        public bool NotifyEmail { get; set; }
        /// <summary>
        /// 	When to execute: The number of times this step has been executed
        /// </summary>
        public int NumProcessed { get; set; }
        /// <summary>
        /// 	Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        /// <summary>
        /// 	The prompt to show users when they complete this step
        /// </summary>
        public string PromptComplete { get; set; }
        /// <summary>
        /// 	The prompt to show users when they reject this step
        /// </summary>
        public string PromptReject { get; set; }
        /// <summary>
        /// Whether or not to prompt the user for notes when completing this step
        /// </summary>
        public bool PromptUser { get; set; }
        /// <summary>
        /// When rejected, this step will move the workflow back to the step specified
        /// </summary>
        public int RejectToStep { get; set; }
        /// <summary>
        /// When to execute: Direction of workflow to execute on
        /// </summary>
        public int RouteDirection { get; set; }
        /// <summary>
        /// The collection of RoutedItems tied to this RouteStep
        /// </summary>
        public FBCollection RoutedItems { get; set; }
        /// <summary>
        /// The ID of the Route that this RouteStep is in
        /// </summary>
        public int RouteId { get; set; }
        /// <summary>
        /// The ID of this RouteStep
        /// </summary>
        public int RouteStepId { get; set; }
        /// <summary>
        /// The collection of RouteStepTasks tied to this RouteStep
        /// </summary>
        public FBCollection RouteStepTasks { get; set; }
        /// <summary>
        /// Whether or not to wait for this step to complete in order to move on to the next step
        /// </summary>
        public bool RouteWait { get; set; }
        /// <summary>
        /// 	Flag to decide whether or not the user sets the next step's due date
        /// </summary>
        public bool SetNextDueDate { get; set; }
        /// <summary>
        /// Whether or not to show the complete button
        /// </summary>
        public bool ShowButtonComplete { get; set; }
        /// <summary>
        /// Whether or not to show the reassign button
        /// </summary>
        public bool ShowButtonReassign { get; set; }
        /// <summary>
        /// Whether or not to show the reject button
        /// </summary>
        public bool ShowButtonReject { get; set; }
        public bool ShowHiddenSteps { get; set; }
        /// <summary>
        /// The colored flag to show in the interface for this step
        /// </summary>
        public RouteStepStatusFlag StatusFlag { get; set; }
        /// <summary>
        /// 	The number this Step is in the Route
        /// </summary>
        public int StepNumber { get; set; }
        /// <summary>
        /// 	When to execute: The percentage of the time this step is executed
        /// </summary>
        public int StepPercent { get; set; }
        /// <summary>
        /// The type of RouteStep
        /// </summary>
        public RouteStepType StepType { get; set; }
        /// <summary>
        /// Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag SyncFlag { get; set; }
        /// <summary>
        /// 	The Field number to update when this RouteStep is completed
        /// </summary>
        public int UpdateFieldNumber { get; set; }
        /// <summary>
        /// The value to update the Field to when this RouteStep is completed
        /// </summary>
        public string UpdateFieldValue { get; set; }
        /// <summary>
        /// 	The ID of the user to which this step is assigned is standard step
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 	The list of UserIDs and GroupIDs responsible for this step if multi-step
        /// </summary>
        public string UserList { get; set; }
        /// <summary>
        /// The name of the user to which this step is assigned is standard step
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The list of User names responsible for this step if multi-step
        /// </summary>
        public string UserNameList { get; set; }
        /// <summary>
        /// 	Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType ViewerContext { get; set; }
        /// <summary>
        /// What percentage of the users in a Vote step need to complete it for the step to complete
        /// </summary>
        public int VotePercent { get; set; }
        /// <summary>
        /// Whether or not a Multi-Vote step should collect all votes before moving on
        /// </summary>
        public bool VoteWaitForAll { get; set; }
    }
}
