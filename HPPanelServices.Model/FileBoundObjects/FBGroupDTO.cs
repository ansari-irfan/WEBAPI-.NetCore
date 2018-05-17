using HPPanelServices.Model.FileBoundObjects.FBEnums;
using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Group
    /// </summary>
    public class FBGroupDTO
    {
        /// <summary> 
        /// Whether or not users in this Group get Access Server Templates rights  
        /// </summary> 
        public bool accessServerTemplates { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have their newly added Files placed on their clipboard  
        /// </summary> 
        public bool addNewFilesToClipboard { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Annotations shown by default  
        /// </summary> 
        public bool annoDefaultShow { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Annotation Edit rights  
        /// </summary> 
        public bool annoEdit { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Annotation Saving rights  
        /// </summary> 
        public bool annoSave { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Annotation Viewing rights  
        /// </summary> 
        public bool annoShow { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Annotation Burn In Rights; this right will honor the Document Edit right  
        /// </summary> 
        public bool annoBurnIn { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have the option to show and hide Annotations  
        /// </summary> 
        public bool annoToggle { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have rights to use standard scanning applications (Data Manager, Capture Lite, etc). NOTE: This right is used by scanning applications directly. 3rd party scanning applications must be built to support this for it to work properly.  
        /// </summary> 
        public bool dataManager { get; set; }
        /// <summary> 
        /// Property to show up diplaying of Indexing Queue Docs whether to All Users or GI User only  
        /// </summary> 
        public IndexingQueueDocs displayIndexingQueueDocs { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Delete Document rights  
        /// </summary> 
        public bool docDelete { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Recycle rights  
        /// </summary> 
        public bool docRecycle { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Save rights  
        /// </summary> 
        public bool docEdit { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have the ability to alter OCR text in the interface. This is used by the FileBound Document Viewer only. Setting this to false does not prevent users to alter the OCR contents through other means.  
        /// </summary> 
        public bool docEditOCR { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have the ability to manage unindexed Documents.  
        /// </summary> 
        public bool docManageUnindexed { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Export rights  
        /// </summary> 
        public bool docExport { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Print rights  
        /// </summary> 
        public bool docPrint { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Secure rights  
        /// </summary> 
        public bool docSecure { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Send (Email) rights  
        /// </summary> 
        public bool docSend { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Signing rights  
        /// </summary> 
        public bool docSign { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document Un-Secure rights  
        /// </summary> 
        public bool docUnsecure { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Document View rights  
        /// </summary> 
        public bool docView { get; set; }
        /// <summary> 
        /// The ID of this Group  
        /// </summary> 
        public long groupId { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Integration Kit rights  
        /// </summary> 
        public bool integrationKit { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Mass Entry rights  
        /// </summary> 
        public bool mass { get; set; }
        /// <summary> 
        /// The name of this Group  
        /// </summary> 
        public string name { get; set; }
        /// <summary> 
        /// Whether or not users in this group have Project Admin rights  
        /// </summary> 
        public bool projectAdmin { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Reporting rights  
        /// </summary> 
        public bool reporting { get; set; }
        /// <summary> 
        /// This Group's Field Securities  
        /// </summary> 
        public FBCollection fieldSecurities { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Delete rights  
        /// </summary> 
        public bool fileDelete { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Recycle rights  
        /// </summary> 
        public bool fileRecycle { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Edit (Edit Only) rights  
        /// </summary> 
        public bool fileEdit { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Entry (Add/Edit) rights  
        /// </summary> 
        public bool fileEntry { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Tracking (ability to check files in and out) rights  
        /// </summary> 
        public bool fileTracking { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Transfer (transfer checkout from one user to another) rights  
        /// </summary> 
        public bool fileTransfer { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have File Search rights  
        /// </summary> 
        public bool fileSearch { get; set; }
        /// <summary> 
        /// This Group's File Securities  
        /// </summary> 
        public FBCollection fileSecurities { get; set; }
        /// <summary> 
        /// Date this Group was last saved  
        /// </summary> 
        public DateTime lastUpdated { get; set; }
        /// <summary> 
        /// By whom this Group was last saved  
        /// </summary> 
        public long lastUpdatedBy { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have the ability to manage unindexed Documents  
        /// </summary> 
        public bool qcFiles { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Save Templates to Server rights  
        /// </summary> 
        public bool saveTemplatesToServer { get; set; }
        /// <summary> 
        /// Status of this Group (i.e. Active or Deleted)  
        /// </summary> 
        public int status { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Workflow Initiation rights  
        /// </summary> 
        public bool workflowInit { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Workflow Management rights  
        /// </summary> 
        public bool workflowManage { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Workflow Assignment Management rights  
        /// </summary> 
        public bool workflowAssignmentManagement { get; set; }
        /// <summary> 
        /// Whether or not users in this Group have Workflow Reporting rights  
        /// </summary> 
        public bool workflowReporting { get; set; }

    }
}
