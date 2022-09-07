//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonLearningDeviceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonLearningDevice file
/// </summary>
public partial class PersonLearningDeviceViewModel : ObservableValidator, IPersonLearningDevice
{
    #region "PersonLearningDeviceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonLearningDeviceViewModel Constructor
    /// </summary>
    public PersonLearningDeviceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonLearningDeviceViewModelConstruction();
    }

    /// <summary>
    /// PersonLearningDeviceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonLearningDeviceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonLearningDevice";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IPersonLearningDevice Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Primary Learning Device Access
    /// <para>
    /// An indication of whether the primary learning device is shared or not shared with another individual
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Learning Device Access")]
    public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

    /// <summary>
    /// Primary Learning Device Away From School
    /// <para>
    /// The type of device the student uses most often to complete learning activities away from school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Learning Device Away From School")]
    public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

    /// <summary>
    /// Primary Learning Device Provider
    /// <para>
    /// The provider of the primary learning device.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Learning Device Provider")]
    public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonLearningDevice model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefPrimaryLearningDeviceAccessId = model.RefPrimaryLearningDeviceAccessId; // Primary Learning Device Access
        RefPrimaryLearningDeviceAwayFromSchoolId = model.RefPrimaryLearningDeviceAwayFromSchoolId; // Primary Learning Device Away From School
        RefPrimaryLearningDeviceProviderId = model.RefPrimaryLearningDeviceProviderId; // Primary Learning Device Provider
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
