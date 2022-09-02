//***************************************************************************
//* DomainName: Common Models
//* FileName:   DataCollectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IDataCollection file
/// </summary>
public partial class DataCollectionViewModel : ObservableValidator, IDataCollection
{
    #region "DataCollectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// DataCollectionViewModel Constructor
    /// </summary>
    public DataCollectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnDataCollectionViewModelConstruction();
    }

    /// <summary>
    /// DataCollectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnDataCollectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from DataCollection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DataCollectionAcademicSchoolYear -- (backing property for Data Collection Academic School Year)
    private System.String dataCollectionAcademicSchoolYear;

    // DataCollectionCloseDate -- (backing property for Data Collection Close Date)
    private DateTime? dataCollectionCloseDate;

    // DataCollectionDescription -- (backing property for Data Collection Description)
    private System.String dataCollectionDescription;

    // DataCollectionName -- (backing property for Data Collection Name)
    private System.String dataCollectionName;

    // DataCollectionOpenDate -- (backing property for Data Collection Open Date)
    private DateTime? dataCollectionOpenDate;

    // DataCollectionSchoolYear -- (backing property for Data Collection School Year)
    private System.String dataCollectionSchoolYear;

    // SourceSystemDataCollectionIdentifier -- (backing property for Source System Data Collection Identifier)
    private System.String sourceSystemDataCollectionIdentifier;

    // SourceSystemName -- (backing property for Source System Name)
    private System.String sourceSystemName;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "IDataCollection Properties"
    /// <summary>
    /// Data Collection Academic School Year
    /// <para>
    /// The year for a reported school session for which the data is applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20920">Data Collection Academic School Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Academic School Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DataCollectionAcademicSchoolYear { get => dataCollectionAcademicSchoolYear; set => SetProperty(ref dataCollectionAcademicSchoolYear, value, true); }

    /// <summary>
    /// Data Collection Close Date
    /// <para>
    /// The date the data collection closes or ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20921">Data Collection Close Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Close Date")]
    public DateTime? DataCollectionCloseDate { get => dataCollectionCloseDate; set => SetProperty(ref dataCollectionCloseDate, value, false); }

    /// <summary>
    /// Data Collection Description
    /// <para>
    /// The description of what is included in the data within the context of the data collection based on the source system and collection period as defined by the Data Collection Open Date and Data Collection Close Date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20922">Data Collection Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String DataCollectionDescription { get => dataCollectionDescription; set => SetProperty(ref dataCollectionDescription, value, true); }

    /// <summary>
    /// Data Collection Name
    /// <para>
    /// A human readable name used to identify the data within the collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20923">Data Collection Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DataCollectionName { get => dataCollectionName; set => SetProperty(ref dataCollectionName, value, true); }

    /// <summary>
    /// Data Collection Open Date
    /// <para>
    /// The date the data collection opens or commences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20924">Data Collection Open Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Open Date")]
    public DateTime? DataCollectionOpenDate { get => dataCollectionOpenDate; set => SetProperty(ref dataCollectionOpenDate, value, false); }

    /// <summary>
    /// Data Collection School Year
    /// <para>
    /// The year for a reported school session in which the data collection occurs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20925">Data Collection School Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection School Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DataCollectionSchoolYear { get => dataCollectionSchoolYear; set => SetProperty(ref dataCollectionSchoolYear, value, true); }

    /// <summary>
    /// Data Collection Status
    /// <para>
    /// A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20926">Data Collection Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Data Collection Status")]
    public Guid? RefDataCollectionStatusId { get; set; }

    /// <summary>
    /// Source System Data Collection Identifier
    /// <para>
    /// The identifier specified by the source system that uniquely identifies the data collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20960">Source System Data Collection Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Source System Data Collection Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(36,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SourceSystemDataCollectionIdentifier { get => sourceSystemDataCollectionIdentifier; set => SetProperty(ref sourceSystemDataCollectionIdentifier, value, true); }

    /// <summary>
    /// Source System Name
    /// <para>
    /// The name of the source system that provided the data within the collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20961">Source System Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Source System Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SourceSystemName { get => sourceSystemName; set => SetProperty(ref sourceSystemName, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IDataCollection model)
    {
        IsBusy = true;
        Id = model.Id;
        DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear; // Data Collection Academic School Year
        DataCollectionCloseDate = model.DataCollectionCloseDate; // Data Collection Close Date
        DataCollectionDescription = model.DataCollectionDescription; // Data Collection Description
        DataCollectionName = model.DataCollectionName; // Data Collection Name
        DataCollectionOpenDate = model.DataCollectionOpenDate; // Data Collection Open Date
        DataCollectionSchoolYear = model.DataCollectionSchoolYear; // Data Collection School Year
        RefDataCollectionStatusId = model.RefDataCollectionStatusId; // Data Collection Status
        SourceSystemDataCollectionIdentifier = model.SourceSystemDataCollectionIdentifier; // Source System Data Collection Identifier
        SourceSystemName = model.SourceSystemName; // Source System Name
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
