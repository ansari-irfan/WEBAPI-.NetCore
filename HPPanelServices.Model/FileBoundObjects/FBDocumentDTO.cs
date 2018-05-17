using System;
using HPPanelServices.Model.FileBoundObjects.FBEnums;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Document
    /// </summary>
    public class FBDocumentDTO
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
        public DocSetRole docSetRole {get;set;}
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

        public long routeId { get; set; }
        public long routeItemId { get; set; }
    }
}
