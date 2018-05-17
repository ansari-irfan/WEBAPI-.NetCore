using System.Collections.Generic;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// to get full object structure plz refer the below link
    /// https://applications.filebound.com/v4/documentation/objects#Assignment
    /// </summary>
    public class FBAssignmentDTO
    {
        /// <summary>
        /// ID of the Task
        /// </summary>
        public long taskId { get; set; }
        /// <summary>
        /// Fields for this Assignment
        /// </summary>
        public List<dynamic> fields { get; set; }
        /// <summary>
        /// AssignmentActions for this Assignment
        /// </summary>
        public List<FBAssignmentActionDTO> tasks { get; set; }
        /// <summary>
        /// Project Name
        /// </summary>
        public string projectName { get; set; }
        /// <summary>
        /// Url to File Details page in FileBound
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// File ID
        /// </summary>
        public long fileId { get; set; }
        /// <summary>
        /// Project ID
        /// </summary>
        public long projectId { get; set; }

        public string AssignedTo { get; set; }

        public string TaskName { get; set; }

        public bool ToBeReassigned { get; set; }


    }
}
