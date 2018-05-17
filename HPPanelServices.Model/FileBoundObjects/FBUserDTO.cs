using HPPanelServices.Model.FileBoundObjects.FBEnums;
using System;

namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#User
    /// </summary>
    public class FBUserDTO
    {
        /// <summary>
        /// Whether or not this user has Access Admin rights (access to Groups, Users, and vendors)	
        /// </summary>
        public bool AccessAdmin { get; set; }
        /// <summary>
        /// Whether or not a User is Active
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Address line 1 for this User
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// Address line 2 for this User
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Whether or not this User is a System Administrator
        /// </summary>
        public bool Admin { get; set; }
        /// <summary>
        /// City for this User
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Whether or not this User has access to only his or her clipboard
        /// </summary>
        public bool ClipboardOnly { get; set; }
        /// <summary>
        /// The custom startup URL for this User
        /// </summary>
        public string CustomURL { get; set; }
        /// <summary>
        /// Default Viewer for the User
        /// </summary>
        public string DefaultViewer { get; set; }
        /// <summary>
        /// Full name of this User
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Email address for this User
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Fax Number for this User
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// The Session GUID for this Login
        /// </summary>
        public string FBGUID { get; set; }
        /// <summary>
        /// Force change Password
        /// </summary>
        public bool ForcePassword { get; set; }
        /// <summary>
        /// Whether or not this User has access to only his or her Forms menu
        /// </summary>
        public bool FormsOnly { get; set; }
        /// <summary>
        /// ID of the Group
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Whether or not this User is hidden from User lists
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType Id { get; set; }
        public bool IncludeGroupsAndProjects { get; set; }
        /// <summary>
        /// Whether or not a User is on location for its business
        /// </summary>
        public int Location { get; set; }
        /// <summary>
        /// Login name of this User
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Returns the Object's Type from the FBEnumerations.ObjectType
        /// </summary>
        public ObjectType ObjectType { get; set; }
        /// <summary>
        /// Whether or not a User is Out Of Office
        /// </summary>
        public bool OutOfOffice { get; set; }
        /// <summary>
        /// Password for this User
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The date this User last changed their password
        /// </summary>
        public DateTime PasswordDate { get; set; }
        /// <summary>
        /// Date/Time this User's password expires
        /// </summary>
        public DateTime PasswordExpires { get; set; }
        /// <summary>
        /// Reflects whether the password has been modified for this User
        /// </summary>
        public string PasswordModified { get; set; }
        /// <summary>
        /// Phone Number for this User
        /// </summary>
        public string Phone { get; set; }
        public int ProjectId { get; set; }
        /// <summary>
        /// Project collection for this User
        /// </summary>
        public FBCollection Projects { get; set; }
        /// <summary>
        /// Property set to true to skip secure password validations (second time) when save method calls for resetting the passwordExpires date
        /// </summary>
        public bool ResetPasswordExpires { get; set; }
        /// <summary>
        /// Routed Item collection for this User
        /// </summary>
        public FBCollection RoutedItems { get; set; }
        /// <summary>
        /// Whether or not this User is allowed to login
        /// </summary>
        public int StartScreen { get; set; }
        /// <summary>
        /// State for this User
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// The Status of this User (1=Active, 0=Deleted)
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Determines whether or not the object has changed since its last load or save operation
        /// </summary>
        public ObjectSyncFlag SyncFlag { get; set; }
        /// <summary>
        /// The time zone this User is in
        /// </summary>
        public int TimeZone { get; set; }
        /// <summary>
        /// ID of this User
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 	Flag set by interface to indicate the Object has originated in a Viewer
        /// </summary>
        public ViewerContextType ViewerContext { get; set; }
        /// <summary>
        /// Website URL for this User
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// Website URL for this User
        /// </summary>
        public string Zip { get; set; }

        public int Department { get; set; }
        public string UserName { get; set; }
    }
}
