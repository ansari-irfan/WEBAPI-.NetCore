using HPPanelServices.Model.FileBoundObjects.FBEnums;
using System;
using System.Collections.Generic;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#File
    /// </summary>
    public class FBFileDTO
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
        public FBCollection documents { get; set; }
        /// <summary> 
        /// The ExtraData collection for this File  
        /// </summary> 
        public FBCollection extraData { get; set; }
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
        public long id { get; set; }
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
        /// </summary> 
        public long remoteId {get;set;}
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

        public string UserName { get; set; }

        public string OriginalNote { get; set; }
    }
}
