using HPPanelServices.Model.FileBoundObjects.FBEnums;
using System;
using System.Collections.Generic;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Project
    /// </summary>
    public class FBAdvancedSearchProjects
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
        public FBAdvancedSearchFieldDTO fields { get; set; }
        /// <summary> 
        /// The File collection for this Project 
        /// </summary> 
        public FBAdvancedSearchFileDTO files { get; set; }
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
    public class FBAdvancedSearchFileDTO
    {
        public int TotalCount { get; set; }
        public List<FBAdvancedSearchFile> Collection { get; set; }
    }
    public class FBAdvancedSearchFile
    {
        /// <summary> 
        /// ID of the box in which this File is contained  
        /// </summary> 
        public long boxId { get; set; }
        /// <summary> 
        /// The User who last changed this File  
        /// </summary> 
        public long changedBy { get; set; }
        /// <summary> 
        /// Can be used to specify custom sort terms  
        /// </summary> 
        public string customSort { get; set; }
        /// <summary> 
        /// The last date this File was changed  
        /// </summary> 
        public DateTime dateChanged { get; set; }
        /// <summary> 
        /// The date this File was started  
        /// </summary> 
        public DateTime dateStarted { get; set; }
        /// <summary> 
        /// The destruction date for this File  
        /// </summary> 
        public DateTime destruction { get; set; }
        /// <summary> 
        /// Number of Documents in this File  
        /// </summary> 
        public long documentCount { get; set; }
        /// <summary> 
        /// Documents in this File  
        /// </summary> 
        public FBAdvancedSearchDocumentDTO documents { get; set; }
        /// <summary> 
        /// The ExtraData collection for this File  
        /// </summary> 
        public FBAdvancedSearchExtraDataObject extraData { get; set; }
        /// <summary> 
        /// The Field collection for this file  
        /// </summary> 
        public FBCollection fieldDefs { get; set; }
        /// <summary> 
        /// The raw, un-masked Field data for this File  
        /// </summary> 
        public string[] field { get; set; }
        /// <summary> 
        /// ID of this File  
        /// </summary> 
        public long fileId { get; set; }
        /// <summary> 
        /// ID of the File this File is pointing to. File Pointers allow one File to act as a placeholder for another File.  
        /// </summary> 
        public long filePtr { get; set; }
        /// <summary> 
        /// Returns the Object's Type from the FBEnumerations.ObjectType  
        /// </summary> 
        public ObjectType id { get; set; }
        /// <summary> 

        /// Checks to see if any text has been entered into any Field of this File  
        /// </summary> 
        public bool isIndexed { get; set; }
        /// <summary> 
        /// The Key Value of this File  
        /// </summary> 
        public string keyValue { get; set; }
        /// <summary> 
        /// The Key Visual value of this File  
        /// </summary> 
        public string keyVisualValue { get; set; }
        /// <summary> 
        /// The last time this File had a label printed. Check the FileLabels collection for all labels that were printed.  
        /// </summary> 
        public DateTime labelPrinted { get; set; }
        /// <summary> 
        /// The Line Item collection for this File.  
        /// </summary> 
        public FBCollection lineItems { get; set; }
        /// <summary> 
        /// The notes for this File  
        /// </summary> 
        public string notes { get; set; }
        /// <summary> 
        /// Returns the Object's Type from the FBEnumerations.ObjectType  
        /// </summary> 
        public ObjectType objectType { get; set; }
        /// <summary> 
        /// ID of the Project that contains this File  
        /// </summary> 
        public long projectId { get; set; }
        /// <summary> 
        /// The Route Info for this file  
        /// </summary> 
        public FBRoutedItemDTO routeInfo { get; set; }
        /// <summary> 
        /// The Routing Document for this file  
        /// </summary> 
        public FBDocumentDTO routingDoc { get; set; }
        /// <summary> 
        /// Remote ID of this File  
        /// </summary> public long remoteId {get;set;}
        /// <summary> 
        /// Flag that specifies whether or not to save only the notes  
        /// </summary> 
        public bool saveNotesOnly { get; set; }
        /// <summary> 
        /// How the File will be saved  
        /// </summary> 
        public FileSaveStyle saveStyle { get; set; }
        /// <summary> 
        /// The status of this File (Ex: 1=Active, 0=Deleted, 7=Recycled)  
        /// </summary> 
        public FileStatus status { get; set; }
        /// <summary> 
        /// Determines whether or not the object has changed since its last load or save operation  
        /// </summary> 
        public ObjectSyncFlag syncFlag { get; set; }
        /// <summary> 
        /// Total number of Documents in this File  
        /// </summary> 
        public long totalDocumentCount { get; set; }
        /// <summary> 
        /// Flag set by interface to indicate the Object has originated in a Viewer  
        /// </summary> 
        public ViewerContextType viewerContext { get; set; }


    }
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Field
    /// </summary>
    public class FBAdvancedSearchFieldDTO
    {
        public int TotalCount { get; set; }
        public List<FBFieldDTO> Collection { get; set; }
    }
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Document
    /// </summary>
    public class FBAdvancedSearchDocumentObject
    {
        /// <summary>
        /// Turn on or off the binary data save when a Document is saved
        /// </summary>
        public bool allowSaveBinaryData { get; set; }
        /// <summary>
        /// size of the Annotation
        /// </summary>
        public long annotationSize { get; set; }
        /// <summary>
        /// The name of the archive in which this Document resides
        /// </summary>
        public string archive { get; set; }
        /// <summary>
        /// ID of the Archive in which this Document resides
        /// </summary>
        public long archiveId { get; set; }
        /// <summary>
        /// Batch to which this Document belongs
        /// </summary>
        public DateTime batchDate { get; set; }
        /// <summary>
        /// Binary data of the Document itself
        /// </summary>
        public object binaryData { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document can be saved using the normal save method
        /// </summary>
        public bool canSave { get; set; }
        /// <summary>
        /// Gets or sets the size of the chunk in KB. Used while uploading the Document in chunks
        /// </summary>
        public int chunkSize { get; set; }
        /// <summary>
        /// Flag denoting whether or not the server has cleaned up the Document from the drive if deleted
        /// </summary>
        public bool cleaned { get; set; }
        /// <summary>
        /// Date the Document was created
        /// </summary>
        public DateTime dateCreated { get; set; }
        /// <summary>
        /// Date the Document was last updated
        /// </summary>
        public DateTime dateFiled { get; set; }
        /// <summary>
        /// Description of this Document
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Divider in which this Document resides
        /// </summary>
        public string divider { get; set; }
        /// <summary>
        /// The ID of the Document this is a virtual copy of. 0 if not a virtual copy.
        /// </summary>
        public long docPtr { get; set; }
        /// <summary>
        /// Shows Document Set Count if Document is Primary Document otherwise 0
        /// </summary>
        public long docSetCount { get; set; }
        /// <summary>
        /// The role the Document plays in a Document Set
        /// </summary>
        public Guid docSetGUID { get; set; }
        /// <summary>
        /// The role the Document plays in a Document Set
        /// </summary>
        public DocSetRole docSetRole { get; set; }
        /// <summary>
        /// Date assigned to this Document
        /// </summary>
        public DateTime documentDate { get; set; }
        /// <summary>
        /// ID of this Document
        /// </summary>
        public long documentId { get; set; }
        /// <summary>
        /// Size of the Document as reported by the data source
        /// </summary>
        public long documentSize { get; set; }
        /// <summary>
        /// Date this e-form was completed
        /// </summary>
        public DateTime eFormComplete { get; set; }
        /// <summary>
        /// Due date of the e-form
        /// </summary>
        public DateTime eFormDue { get; set; }
        /// <summary>
        /// ID of the E-Form this Document was generated from. 0 if not generated from an E-Form.
        /// </summary>
        public long eFormId { get; set; }
        /// <summary>
        /// Flag that specifies whether or not this Document is to be encrypted when saved
        /// </summary>
        public bool encrypted { get; set; }
        /// <summary>
        /// Extension that describes the type of the Document
        /// </summary>
        public string extension { get; set; }
        /// <summary>
        /// ID of the File in which this Document resides
        /// </summary>
        public long fileId { get; set; }
        /// <summary>
        /// The full text (OCR) for this Document
        /// </summary>
        public string fullText { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType id { get; set; }
        /// <summary>
        /// True if the extension of this Document is supported for Auto-Indexing
        /// </summary>
        public bool isAutoIndexable { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is in the Indexing Queue
        /// </summary>
        public bool isIndexing { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is a MasterSheet
        /// </summary>
        public bool isMasterSheet { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is a multimedia Document (WMA, WMV, MPEG, etc.)
        /// </summary>
        public bool isMultimedia { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is an image and is multi-page. Requires BinaryData to be populated or exception will be thrown.
        /// </summary>
        public bool isMultipageImage { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is an OLE-compliant Document (DOC, XLS, etc.)
        /// </summary>
        public bool isOLE { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is an image that can be rendered (BMP, GIF, TIF, PDF, etc.)
        /// </summary>
        public bool isRenderable { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is a text file (TXT)
        /// </summary>
        public bool isText { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is a TIF image
        /// </summary>
        public bool isTIFF { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is a web page (HTM, HTML, etc.)
        /// </summary>
        public bool isWeb { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document is an HTML E-Form
        /// </summary>
        public bool isWebEform { get; set; }
        /// <summary>
        /// Date this Document was last viewed
        /// </summary>
        public DateTime lastView { get; set; }
        /// <summary>
        /// ID of the user who has locked this Document. This will be 0 if the Document is not locked
        /// </summary>
        public long lockedBy { get; set; }
        /// <summary>
        /// Name of the Document
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Document notes
        /// </summary>
        public string notes { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType objectType { get; set; }
        /// <summary>
        /// Number of 50K pages contained in this Document
        /// </summary>
        public long pages { get; set; }
        /// <summary>
        /// Path this Document was read from
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// Property which is set after the Document is streamed down
        /// </summary>
        public string physicalLocation { get; set; }
        /// <summary>
        /// ID of the Process Step the e-form was generated from
        /// </summary>
        public long processStepId { get; set; }
        /// <summary>
        /// Gets the progress percentage. Used to get the progress percentage while async Document upload/download
        /// </summary>
        public int progressPercentage { get; set; }
        /// <summary>
        /// Gets the state of the progress. Used to get the state information while async Document upload/download
        /// </summary>
        public string progressState { get; set; }
        /// <summary>
        /// ID of the Project in which this Document is queued up for indexing. This is only used for Un-Indexed Document
        /// </summary>
        public long relProjectId { get; set; }
        /// <summary>
        /// Remote ID of this Document
        /// </summary>
        public long remoteID { get; set; }
        /// <summary>
        /// The Document ID this Document is a revision of
        /// </summary>
        public long revDocumentId { get; set; }
        /// <summary>
        /// Flag that specifies whether or not to save only the notes
        /// </summary>
        public bool saveNotesOnly { get; set; }
        /// <summary>
        /// How the Document will be saved
        /// </summary>
        public DocumentSaveStyle saveStyle { get; set; }
        /// <summary>
        /// Flag that speified whether or not this Document is secured
        /// </summary>
        public bool secured { get; set; }
        /// <summary>
        /// Separator in which this Document resides
        /// </summary>
        public string separator { get; set; }
        /// <summary>
        /// Order in which this page is shown in the File/Separator/Divider
        /// </summary>
        public long sortOrder { get; set; }
        /// <summary>
        /// Status of this Document (Ex. 1=Active, 0=Deleted, 2=Archived, 7=Recycled)
        /// </summary>
        public DocumentStatus status { get; set; }
        /// <summary>
        /// Gets or sets the Streaming Mode. If this mode is set to true, the Document Stream property must not be null for Web Connector
        /// </summary>
        public bool streamingMode { get; set; }
        /// <summary>
        /// Flag that denotes whether or not this Document supports annotations
        /// </summary>
        public bool supportsAnnotations { get; set; }
        /// <summary>
        /// Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag syncFlag { get; set; }
        /// <summary>
        /// ID of User who created the Document
        /// </summary>
        public long userCreated { get; set; }
        /// <summary>
        /// ID of User who last updated this Document
        /// </summary>
        public long userFiled { get; set; }
        /// <summary>
        /// Name of User who created this Document
        /// </summary>
        public string userNameCreated { get; set; }
        /// <summary>
        /// Name of User who last updated this Document
        /// </summary>
        public string userNameFiled { get; set; }
        /// <summary>
        /// Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType viewerContext { get; set; }

        public List<FBEformDataDTO> eformData { get; set; }
        public List<FBEformDetailDTO> eformdetailData { get; set; }
    }
    public class FBAdvancedSearchDocumentDTO
    {
        public int TotalCount { get; set; }
        public List<FBAdvancedSearchDocumentObject> Collection { get; set; }
    }

    public class FBFilter
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class SearchFilter
    {
        public IList<FBFilter> filters { get; set; }
    }

    public class AdvancedSearchResult
    {
        public List<DataTableColumns> columns { get; set; }
        public List<string[]> data { get; set; }
        public string keyField { get; set; }
    }

    public class AdvancedSearchDTO
    {
        public int Status { get; set; } = 1;
        public int DocsChangedSinceLastArchive { get; set; } = -999;
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public int FileID { get; set; }
        public int FilePtr { get; set; }
        public int BoxID { get; set; }
        public int AuditID { get; set; }
        public string DestructionDateFrom { get; set; } = "1990/01/01";
        public string DestructionDateTo { get; set; } = "1990/01/01";
        public string DateChangedFrom { get; set; } = "1990/01/01";
        public string DateChangedTo { get; set; } = "1990/01/01";
        public string DateCreatedFrom { get; set; } = "1990/01/01";
        public string DateCreatedTo { get; set; } = "1990/01/01";
        public string LabelPrintedFrom { get; set; } = "1990/01/01";
        public string LabelPrintedTo { get; set; } = "1990/01/01";
        public string BatchDateFrom { get; set; } = "1990/01/01";
        public string BatchDateTo { get; set; } = "1990/01/01";
        public string Separator { get; set; } = "";
        public string Divider { get; set; } = "";
        public string Archive { get; set; } = "";
        public int ArchiveID { get; set; }
        public bool Clipboard { get; set; } = false;
        public string FullText { get; set; } = "";
        public int FullTextMode { get; set; }
        public string MultiKey { get; set; } = "";
        public string MultiID { get; set; } = "";
        public string FileNotes { get; set; } = "";
        public string DocNotes { get; set; } = "";
        public string DocNames { get; set; } = "";
        public string Field1 { get; set; } = "";
        public string Field1To { get; set; } = "";
        public string Field2 { get; set; } = "";
        public string Field2To { get; set; } = "";
        public string Field3 { get; set; } = "";
        public string Field3To { get; set; } = "";
        public string Field4 { get; set; } = "";
        public string Field4To { get; set; } = "";
        public string Field5 { get; set; } = "";
        public string Field5To { get; set; } = "";
        public string Field6 { get; set; } = "";
        public string Field6To { get; set; } = "";
        public string Field7 { get; set; } = "";
        public string Field7To { get; set; } = "";
        public string Field8 { get; set; } = "";
        public string Field8To { get; set; } = "";
        public string Field9 { get; set; } = "";
        public string Field9To { get; set; } = "";
        public string Field10 { get; set; } = "";
        public string Field10To { get; set; } = "";
        public string Field11 { get; set; } = "";
        public string Field11To { get; set; } = "";
        public string Field12 { get; set; } = "";
        public string Field12To { get; set; } = "";
        public string Field13 { get; set; } = "";
        public string Field13To { get; set; } = "";
        public string Field14 { get; set; } = "";
        public string Field14To { get; set; } = "";
        public string Field15 { get; set; } = "";
        public string Field15To { get; set; } = "";
        public string Field16 { get; set; } = "";
        public string Field16To { get; set; } = "";
        public string Field17 { get; set; } = "";
        public string Field17To { get; set; } = "";
        public string Field18 { get; set; } = "";
        public string Field18To { get; set; } = "";
        public string Field19 { get; set; } = "";
        public string Field19To { get; set; } = "";
        public string Field20 { get; set; } = "";
        public string Field20To { get; set; } = "";
        public int RangeBegin { get; set; }
        public int RangeLength { get; set; }
        public string Sort { get; set; } = "";

    }

    public class GlobalSearchResult
    {
        public string Project { get; set; }
        public string File { get; set; }
        public string Document { get; set; }
        public string MatchedText { get; set; }
        public bool? IsMatch { get; set; }
    }

    public class DataTableColumns
    {
        public string title { get; set; }
    }

    public class AdvancedFilterObject
    {
        //public bool? FileNotes { get; set; }
        //public bool? FileIndexes { get; set; }
        //public bool? DocNotes { get; set; }
        //public bool? DocName { get; set; }

        //public bool? DocDivider { get; set; }
        //public bool? DocSeparator { get; set; }

        //public bool? DocFullText { get; set; }
        //public bool? RoutedItemComment { get; set; }
        //public bool? TextAnnotations { get; set; }
        //public bool? FormDetails { get; set; }
        //public bool? FormData { get; set; }
        //public bool? FormExtraData { get; set; }
        //public bool? FileKeyField { get; set; }
        public List<long?> Projects { get; set; }
        public List<long?> Scopes { get; set; }
        public string projectsList { get; set; }
        public string scopesList { get; set; }
    }

    public class FBAdvancedSearchExtraDataObject
    {
        public int TotalCount { get; set; }
        public List<FBExtraDataDTO> Collection { get; set; }
    }
}
