//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodProgramTypeOffered file
/// </summary>
public partial class EarlyChildhoodProgramTypeOfferedViewModel : ObservableValidator, IEarlyChildhoodProgramTypeOffered
{
    #region "EarlyChildhoodProgramTypeOfferedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// EarlyChildhoodProgramTypeOfferedViewModel Constructor
    /// </summary>
    public EarlyChildhoodProgramTypeOfferedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnEarlyChildhoodProgramTypeOfferedViewModelConstruction();
    }

    /// <summary>
    /// EarlyChildhoodProgramTypeOfferedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnEarlyChildhoodProgramTypeOfferedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from EarlyChildhoodProgramTypeOffered";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
    private Boolean? inclusiveSettingIndicator;

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

    #region "IEarlyChildhoodProgramTypeOffered Properties"
    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Inclusive Setting Indicator")]
    public Boolean? InclusiveSettingIndicator { get => inclusiveSettingIndicator; set => SetProperty(ref inclusiveSettingIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Community-based Type
    /// <para>
    /// Non domestic residence in which the early learning setting is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Community-based Type")]
    public Guid? RefCommunityBasedTypeId { get; set; }

    /// <summary>
    /// Early Childhood Program Enrollment Type
    /// <para>
    /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Early Childhood Program Enrollment Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IEarlyChildhoodProgramTypeOffered model)
    {
        IsBusy = true;
        Id = model.Id;
        InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
        OrganizationId = model.OrganizationId; // 
        RefCommunityBasedTypeId = model.RefCommunityBasedTypeId; // Community-based Type
        RefEarlyChildhoodProgramEnrollmentTypeId = model.RefEarlyChildhoodProgramEnrollmentTypeId; // Early Childhood Program Enrollment Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
