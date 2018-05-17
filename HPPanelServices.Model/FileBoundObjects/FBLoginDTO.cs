namespace HPPanelServices.Model.FileBoundObjects
{
    /// <summary>
    /// https://applications.filebound.com/v4/documentation/objects#Login
    /// </summary>
    public class FBLoginDTO
    {
        /// <summary>
        /// The username to login with
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The password to login with
        /// </summary>
        public string Password { get; set; }
    }
}
