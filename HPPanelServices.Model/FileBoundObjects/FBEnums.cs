
namespace HPPanelServices.Model.FileBoundObjects.FBEnums
{
    public enum AssignmentActionType
    {
        Unknown = 0,
        ActionLink = 1,
        DueDate = -9999,
        Cancel = -9998,
        Reassign = -9997,
        Reject = -9996,
        Approve = -9995,
        Checklist = -9994,
        VerifyPassword = -9993
    };

    public enum DocSetRole
    {
        None = 0,
        FirstDoc_Excluded = 1,
        FirstDoc_Included = 2,
        Sibling = 3,
        FirstDoc_All = -1
    };

    public enum DocumentRouteAction
    {
        Every_Document = 0,
        First_Document_In_File = 1,
        Every_Page = 3
    };

    public enum DocumentSaveStyle
    {
        CreateRevision = 0,
        SkipRevision = 1,
        ProjectLevelRouting = 2,
        BypassProjectLevelRouting = 3,
        Unknown = -999,
        OverrideUser = 4,
        OverrideLock = 5
    };

    public enum DocumentStatus
    {
        Deleted = 0,
        Active = 1,
        Archived = 2,
        Scanned = 3,
        Revision = -2,
        EformGenerated = 4,
        Unindexed = 5,
        Indexing_Queued = 500,
        Indexing_QueuedError = 509,
        Indexing_OCR = 510,
        Indexing_OCRError = 519,
        Indexing_TemplateMatch = 520,
        Indexing_TemplateMatchError = 529,
        Indexing_Manual = 590,
        Indexing_Error = 599,
        Recycled = 7,
        Recycle_Processing = 700,
        QualityControl = 800,
        Indexing_All = -5,
        Indexing_AllIndexable = -555,
        Indexing_AllProcessing = -554,
        ActiveOrArchived = -998,
        Unknown = -999
    };

    public enum FieldType
    {
        Unknown = 0,
        Text = 1,
        Number = 2,
        DateField = 3,
        TerminalDigit = 4,
        AutoCounter = 5,
        OptionList = 6,
        AutoText = 7,
        Special1 = 8,
        ProjectLink = 9
    };

    public enum FileSaveStyle
    {
        MergeFirst = 0,
        NewFile = 1,
        KeyFieldMerge = 2
    };

    public enum FileStatus
    {
        Deleted = 0,
        Active = 1,
        Scanned = 3,
        Recycled = 7,
        Recycle_Processing = 700,
        QualityControl = 800,
        UnIndexed = -1,
        Unknown = -999
    };

    public enum IndexingQueueDocs
    {
        AllUsers = 0,
        GlobalIndexingUserOnly = 1
    };

    public enum ObjectSyncFlag
    {
        NoChange = 0,
        Add = 1,
        Edit = 2,
        Delete = 3,
        Restore = 4
    };

    public enum ObjectType
    {
        Any = -1,
        AnyBase = -2,
        AnyBaseCollection = -3,
        AnyBase_Or_Business = -4,
        AnyBaseCollection_Or_Business = -5,
        AnyFileBoundObject = -6,
        Unknown = 0,
        Business = 1,
        Project = 2,
        Group = 3,
        User = 4,
        File = 5,
        Document = 6,
        Archive = 7,
        Audit = 8,
        Batch = 9,
        Box = 10,
        CAR = 11,
        ChecklistItem = 12,
        Checkout = 13,
        Divider = 14,
        DocLocation = 15,
        DocumentRel = 16,
        DocumentSec = 17,
        DocumentSig = 18,
        Eform = 20,
        EformData = 21,
        EformDetail = 22,
        ExtraData = 23,
        Field = 24,
        CheckListDef = 25,
        FileLabel = 26,
        Label = 27,
        Monitor = 28,
        Overlay = 29,
        Password = 30,
        Reason = 31,
        Request = 32,
        Route = 33,
        RouteStep = 34,
        RouteStepTask = 35,
        Separator = 36,
        Stamp = 37,
        RoutedItem = 38,
        Annotation = 39,
        ExtendedProperty = 40,
        Server = 41,
        Setting = 42,
        AnnotationCollection = 43,
        ProjectCollection = 44,
        GroupCollection = 45,
        UserCollection = 46,
        FileCollection = 47,
        DocumentCollection = 48,
        ArchiveCollection = 49,
        AuditCollection = 50,
        BatchCollection = 51,
        BoxCollection = 52,
        CARCollection = 53,
        ChecklistItemCollection = 54,
        CheckoutCollection = 55,
        DividerCollection = 56,
        DocLocationCollection = 57,
        DocumentRelCollection = 58,
        DocumentSecCollection = 59,
        DocumentSigCollection = 60,
        EformCollection = 62,
        EformDataCollection = 63,
        EformDetailCollection = 64,
        ExtraDataCollection = 65,
        FieldCollection = 66,
        ChecklistDefCollection = 67,
        FileLabelCollection = 68,
        LabelCollection = 69,
        MonitorCollection = 70,
        OverlayCollection = 71,
        PasswordCollection = 72,
        ReasonCollection = 73,
        RequestCollection = 74,
        RouteCollection = 75,
        RouteStepCollection = 76,
        RouteStepTaskCollection = 77,
        SeparatorCollection = 78,
        StampCollection = 79,
        RoutedItemCollection = 80,
        ExtendedPropertyCollection = 81,
        ServerCollection = 82,
        SettingCollection = 83,
        Plugin = 84,
        PluginCollection = 85,
        Report = 86,
        ReportCollection = 87,
        ReportParm = 88,
        ReportParmCollection = 89,
        Vendor = 90,
        VendorCollection = 91,
        EformProcess = 92,
        EformProcessCollection = 93,
        EformProcessStep = 94,
        EformProcessStepCollection = 95,
        EformGroup = 96,
        EformGroupCollection = 97,
        FileSecurity = 98,
        FileSecurityCollection = 99,
        FieldSecurity = 100,
        FieldSecurityCollection = 101,
        ReportSort = 102,
        ReportSortCollection = 103,
        Chain = 104,
        ChainCollection = 105,
        ChainModule = 106,
        ChainModuleCollection = 107,
        RouteStepFieldUpdate = 108,
        RouteStepFieldUpdateCollection = 109,
        Word = 110,
        WordCollection = 111,
        Clipboard = 112,
        Login = 113,
        Search = 114,
        DocumentNote = 115,
        Page = 116,
        PageCollection = 117,
        RouteStepChecklist = 118,
        RouteStepChecklistCollection = 119,
        Scope = 120,
        ScopeCollection = 121,
        Widget = 122,
        WidgetCollection = 123,
        ProcessRouteRevision = 124,
        ProcessRouteRevisionCollection = 125,
        ScheduledJob = 126,
        ScheduledJobCollection = 127,
        ScheduledJobExec = 128,
        ScheduledJobExecCollection = 129,
        RecycleBin = 130,
        ServerGroup = 131,
        ServerGroupCollection = 132,
        AutomationEvent = 133,
        AutomationEventCollection = 134,
        RoutePath = 1353,
        RoutePathCollection = 136,
        Template = 137,
        TemplateCollection = 138,
        FBRegexPattern = 139,
        FBRegexPatternCollection = 140,
        UserGridSetting = 141,
        UserGridSettingsCollection = 142,
        FormToken = 143,
        FormTokenCollection = 144,
        Dashboard = 145,
        DashboardCollection = 146,
        SearchPortalField = 147,
        SearchPortalFieldCollection = 148,
        SearchPortalAccessCode = 149,
        SearchPortalAccessCodeCollection = 150,
        UserSetting = 151,
        UserSettingsCollection = 152
    };

    public enum RenditionAction
    {
        AllPages = 0,
        FirstPageOnly = 1,
        Custom = 2
    };

    public enum RenditionPerformed
    {
        NoRenditions = 0,
        OnUpload = 1,
        DataAccessed = 2,
        ScheduledJob = 3,
        MainSettings = 4
    };

    public enum ReportLevel
    {
        LevelAll = 0,
        LevelGlobal = 1,
        LevelProject = 2,
        LevelCustom = 3
    };

    public enum ReportParmType
    {
        Unknown = 0,
        Text = 1,
        Number = 2,
        DateField = 3,
        OptionList = 6,
        CheckBox = 10,
        UserList = 101,
        ProjectList = 102,
        FieldList = 103,
        RouteList = 104,
        ReasonList = 105,
        ProjectListFieldSelection = 106,
        ObjectCheckBoxList = 107,
        GroupListUserSelection = 108,
        EntityTypeList = 109,
        ActivityTypeList = 110,
        ProjectListRouteSelection = 111,
        RouteStepList = 112
    };

    public enum ReportStandard
    {
        Miscellaneous = 0,
        System_UserLoginReport = 1,
        System_UserRightsReport = 2,
        System_FailedLoginReport = 3,
        System_SystemUsageReport = 4,
        System_SystemChangeLogReport = 5,
        System_OutdatedArchivesReport = 6,
        Project_ActivityReport = 100,
        Project_FileInventoryReport = 101,
        Project_FileCheckoutReport = 102,
        Project_FileActivityReport = 103,
        Project_FileInactivityReport = 104,
        Project_FileDestructionReport = 105,
        Project_FileDeficiencyReport = 106,
        Project_FileAuditManagerReport = 107,
        Project_FilePendingRequestsReport = 108,
        Project_FileEntryReport = 109,
        Project_DocumentCountReport = 110,
        Project_DocumentActivityReport = 111,
        Project_DocumentInactivityReport = 112,
        Project_WorkflowStatusReport = 113,
        Project_FileDocumentDeletionReport = 114,
        Project_DocumentLockReport = 115,
        Static_CustomReport = 116
    };

    public enum RoutedItemDirection
    {
        Unknown = -999,
        Backward = 0,
        Forward = 1,
        Reassign = 2
    };

    public enum RoutedItemStatus
    {
        WaitingOnChildRoute = -1,
        Inactive = 0,
        Active = 1,
        Unknown = -999
    };

    public enum RouteStepStatusFlag
    {
        None = 0,
        Red = 1,
        Blue = 2,
        Green = 3,
        Yellow = 4,
        LightBlue = 5,
        Purple = 6,
        Brown = 7,
        Magenta = 8,
        Black = 9,
        PulseRed = 10,
        PulseBlue = 11,
        PulseGreen = 12,
        PulseYellow = 13,
        PulseLightBlue = 14,
        PulsePurple = 15,
        PulseBrown = 16,
        PulseMagenta = 17,
        Orange = 18,
        PulseOrange = 19
    };

    public enum RouteStepTaskButtonAction
    {
        None = 0,
        Print = 1,
        NewRoute = 3,
        PlugIn = 4,
        ShowChecklist = 5,
        ReassignToUser = 6
    };

    public enum RouteStepTaskWorkflowAction
    {
        None = 0,
        Complete = 1,
        Reject = 2,
        Cancel = 3,
        Move = 4,
        MoveWithList = 5,
        MoveWithListMulti = 6
    };

    public enum RouteStepType
    {
        Standard = 0,
        MultiAll = 1,
        MultiLoad = 2,
        MultiQueue = 3,
        MultiVote = 4
    };

    public enum RouteType
    {
        AllRoutable = -999,
        AllAutomation = -998,
        Regular = 0,
        AdHoc = 1,
        Unknown = 2,
        Process = 3,
        PublishedProcess = 4,
        GlobalSearch = 5,
        Renditions = 6,
        AutoIndex = 7,
        ExchangeImport = 8,
        FolderImport = 9,
        SocialMedia = 10,
        ActiveDirectory = 11,
        AutoOCR = 12,
        SiteOCR = 13,
        RecycleBinCleaner = 14,
        AutoReport = 15,
        ScheduledWorkflow = 16
    };

    public enum RouteWaitState
    {
        DontWait = 0,
        Wait = 1,
        Pending = 2
    };

    public enum SearchPortalFieldStatus
    {
        Unknown = -999,
        Deleted = 0,
        Active = 1
    }

    public enum ServerOCRType
    {
        NoServerOCR = 0,
        ServerOCR = 1,
        ServerOCRWords = 2,
        MainSettings = 3
    };

    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    };

    public enum SortOrder
    {
        Ascending = 0,
        Descending = 1
    };

    public enum TriState
    {
        DontCare = -999,
        False = 0,
        True = 1
    };

    public enum ViewerContextType
    {
        Unknown = -999,
        None = 0,
        Viewer = 1,
        AdminViewer = 2,
        ScanViewer = 3,
        ReportViewer = 4,
        Portal = 5,
        CustomViewer = 999
    };

    public enum Scopes
    {
        ProjectName = 1,
        FileNotes = 2,
        FileIndex = 3,
        Field2 = 4,
        Field3 = 5,
        Field4 = 6,
        Field5 = 7,
        Field6 = 8,
        Field7 = 9,
        Field8 = 10,
        Field9 = 11,
        Field10 = 12,
        Field11 = 13,
        Field12 = 14,
        Field13 = 15,
        Field14 = 16,
        Field15 = 17,
        Field16 = 18,
        Field17 = 19,
        Field18 = 20,
        Field19 = 21,
        Field20 = 22,
        DocumentNotes = 23,
        Separator = 24,
        Divider = 25,
        DocumentName = 26,
        Fulltext = 27,
        Comment = 28,
        Text = 29,
        EformDetailsFieldValue = 30,
        EformDataFieldValue = 31,
        ExtraDataValue = 32,
        FileKeyField = 33
    }
}
