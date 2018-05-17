using HPPanelServices.Model.FileBoundObjects.FBEnums;
using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Project
    /// </summary>
    public class FBProjectDTO
    {
        /// <summary> 
        /// Whether or not to allow users to un-sign a documens once it is signed 
        /// </summary> 
        public bool allowUnsign { get; set; }
        /// <summary> 
        /// Email address for sending batch upload notifications 
        /// </summary> 
        public string batchEmails { get; set; }
        /// <summary> 
        /// Specifies the text to use for Divider labels 
        /// </summary> 
        public string dividerLabel { get; set; }
        /// <summary> 
        /// The collection of Dividers that reside in this Project 
        /// </summary> 
        public FBCollection dividers { get; set; }
        /// <summary> 
        /// Whether or not to enable box tracking functions in interface 
        /// </summary> 
        public bool enableBoxes { get; set; }
        /// <summary> 
        /// Whether or not to enable CAR functions in interface 
        /// </summary> 
        public bool enableCAR { get; set; }
        /// <summary> 
        /// Whether or not to remember dividers added to this Project 
        /// </summary> 
        public bool enableDividerMemory { get; set; }
        /// <summary> 
        /// Whether or not to enable divider security for this Project 
        /// </summary> 
        public bool enableDividerSecurity { get; set; }
        /// <summary> 
        /// Whether or not to enable document locking functions for this Project 
        /// </summary> 
        public bool enableDocumentLocking { get; set; }
        /// <summary> 
        /// Whether or not to enable the FBDrive component for this Project 
        /// </summary> 
        public bool enableFBDrive { get; set; }
        /// <summary> 
        /// Whether or not to enable field security for this Project 
        /// </summary> 
        public bool enableFieldSecurity { get; set; }
        /// <summary> 
        /// Whether or not to enable file tracking functions in interface 
        /// </summary> 
        public bool enableFileTracking { get; set; }
        /// <summary> 
        /// Whether or not to enable full text indexing for this Project 
        /// </summary> 
        public bool enableFullText { get; set; }
        /// <summary> 
        /// Whether or not to allow users who have document edit rights to edit document information on revisions 
        /// </summary> 
        public bool enableInteractiveRevisions { get; set; }
        /// <summary> 
        /// Whether or not to allow manual entry of dividers in this Project 
        /// </summary> 
        public bool enableManualDividerEntry { get; set; }
        /// <summary> 
        /// Whether or not to allow manual entry of separators in this Project 
        /// </summary> 
        public bool enableManualSeparatorEntry { get; set; }
        /// <summary> 
        /// Whether or not to enable Multi-key text searching for this Project
        /// </summary> 
        public bool enableMultiKeySearch { get; set; }
        /// <summary> 
        /// Whether or not to enable document revisioning for this Project 
        /// </summary> 
        public bool enableRevisions { get; set; }
        /// <summary> 
        /// Whether or not to remember separators added to this Project 
        /// </summary> 
        public bool enableSeparatorMemory { get; set; }
        /// <summary> 
        /// Whether or not to enable Multi-level indexing (i.e. use Separators) 
        /// </summary> 
        public bool enableSeparators { get; set; }
        /// <summary> 
        /// Whether or not to enable separator security for this Project 
        /// </summary> 
        public bool enableSeparatorSecurity { get; set; }
        /// <summary> 
        /// Whether or not to enable task manager functions for this Project 
        /// </summary> 
        public bool enableTaskManager { get; set; }
        /// <summary> 
        /// Whether or not to allow users to select the workflow queue to work on 
        /// </summary> 
        public bool enableWFQueueSelection { get; set; }
        /// <summary> 
        /// The ExtendedProperty collection for this Project 
        /// </summary> 
        public FBCollection extendedProperties { get; set; }
        /// <summary> 
        /// The Field collection for this Project 
        /// </summary> 
        public FBCollection fields { get; set; }
        /// <summary> 
        /// The File collection for this Project 
        /// </summary> 
        public FBCollection files { get; set; }
        /// <summary> 
        /// Email address for sending file room checkout request emails 
        /// </summary> 
        public string fileRoomEmails { get; set; }
        /// <summary> 
        /// Whether or not this Project is to be hidden in the standard Web interface 
        /// </summary> 
        public bool hidden { get; set; }
        /// <summary> 
        /// Returns the Object's Type from the FBEnumerations.ObjectType 
        /// </summary> 
        public ObjectType id { get; set; }
        /// <summary> 
        /// Whether or not this Project is to be set to an Imaging Project 
        /// </summary> 
        public bool imaging { get; set; }
        /// <summary> 
        /// Key Field for this Project 
        /// </summary> 
        public int keyField { get; set; }
        /// <summary> 
        /// Key Visual Field for this Project 
        /// </summary> 
        public int keyVisualField { get; set; }
        /// <summary> 
        /// Date this Project was last saved 
        /// </summary> 
        public DateTime lastUpdated { get; set; }
        /// <summary> 
        /// By whom this Project was last saved 
        /// </summary> 
        public long lastUpdatedBy { get; set; }
        /// <summary> 
        /// The name of the Project 
        /// </summary> 
        public string name { get; set; }
        /// <summary> 
        /// Route down which to send newly uploaded documents 
        /// </summary> 
        public long newDocRoute { get; set; }
        /// <summary> 
        /// Which newly uploaded documents to route (FBEnumeration) (Ex. 0=Every Document, 1=First Document in File, 2=Every page) 
        /// </summary> 
        public DocumentRouteAction newDocRouteAction { get; set; }
        /// <summary> 
        /// The number of revisions to show for any given Document 
        /// </summary> 
        public int numRevisions { get; set; }
        /// <summary> 
        /// The number of revisions to show for any given document 
        /// </summary> 
        public long projectId { get; set; }
        /// <summary> 
        /// Whether or not to remember the box number for a file that is checked in from a box 
        /// </summary> 
        public bool rememberBox { get; set; }
        /// <summary> 
        /// Remote ID of the Project 
        /// </summary> 
        public long remoteId { get; set; }
        /// <summary> 
        /// The type of rendition action that will be performed (FBEnumeration) 
        /// </summary> 
        public RenditionAction renditionAction { get; set; }
        /// <summary> 
        /// The maximum dimension of renditions for this Project 
        /// </summary> 
        public int renditionMaximumDimension { get; set; }
        /// <summary> 
        /// When the renditions will be performed 
        /// </summary> 
        public RenditionPerformed renditionPerformed { get; set; }
        /// <summary> 
        /// Whether or not this Project is to be set use the Report Viewer 
        /// </summary> 
        public bool reportViewer { get; set; }
        /// <summary> 
        /// Whether or not to require box number when performing checkouts 
        /// </summary> 
        public bool requireBox { get; set; }
        /// <summary> 
        /// How the Files will be saved 
        /// </summary> 
        public FileSaveStyle saveStyle { get; set; }
        /// <summary> 
        /// The collection of Separators that reside in this Project 
        /// </summary> 
        public FBCollection separators { get; set; }
        /// <summary> 
        /// Specifies the text to use for Separator labels 
        /// </summary> 
        public string separatorLabel { get; set; }
        /// <summary> 
        /// ID of the server this Project resides on 
        /// </summary> 
        public long serverId { get; set; }
        /// <summary> 
        /// The extensions to skip during Server OCR for this Project 
        /// </summary> 
        public string serverOCRSkipExtensions { get; set; }
        /// <summary> 
        /// The type of Server OCR desired at the Project level 
        /// </summary> 
        public ServerOCRType serverOCRType { get; set; }
        /// <summary> 
        /// Whether or not to show the Change Date field in search results (mainly Web interface) 
        /// </summary> 
        public bool showChangeDate { get; set; }
        /// <summary> 
        /// Specifies which direction to sort the Dividers 
        /// </summary> 
        public SortOrder sortDividers { get; set; }
        /// <summary> 
        /// Specifies which direction to sort the Separators 
        /// </summary> 
        public SortOrder sortSeparators { get; set; }
        /// <summary> 
        /// Status of the Project, for example if it is active or deleted 
        /// </summary> 
        public int status { get; set; }
        /// <summary> 
        /// Type of Project 
        /// </summary> 
        public string type { get; set; }
        /// <summary> 
        /// List of all Project types 
        /// </summary> 
        public string[] types { get; set; }
        /// <summary> 
        /// Whether to show "assigned by" on the workflow status screens (Home) 
        /// </summary> 
        public bool wfShowAssignedBy { get; set; }
        /// <summary> 
        /// Whether to show the batch date on the workflow status screens (Home) 
        /// </summary> 
        public bool wfShowBatchDate { get; set; }
        /// <summary> 
        /// Whether to show the Divider on the workflow status screens (Home) 
        /// </summary> 
        public bool wfShowDivider { get; set; }
        /// <summary> 
        /// Whether to show the due date on the workflow status screens (Home) 
        /// </summary> 
        public bool wfShowDueDate { get; set; }
        /// <summary> 
        /// Whether to show the start date on the workflow status screens (Home) 
        /// </summary> 
        public bool wfShowStartDate { get; set; }
        /// <summary> 
        /// The total number of Files in this Project 
        /// </summary> 
        public long totalFileCount { get; set; }

    }
}
