//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationEmployeeBenefit file
/// </summary>
public partial class OrganizationEmployeeBenefitViewModel : ObservableValidator, IOrganizationEmployeeBenefit
{
    #region "OrganizationEmployeeBenefitViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationEmployeeBenefitViewModel Constructor
    /// </summary>
    public OrganizationEmployeeBenefitViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationEmployeeBenefitViewModelConstruction();
    }

    /// <summary>
    /// OrganizationEmployeeBenefitViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationEmployeeBenefitViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationEmployeeBenefit";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FullTimeBenefitIndicator -- (backing property for Full-Time Employee Benefits)
    private Boolean? fullTimeBenefitIndicator;

    // PartTimeBenefitIndicator -- (backing property for Part-Time Employee Benefits)
    private Boolean? partTimeBenefitIndicator;

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

    #region "IOrganizationEmployeeBenefit Properties"
    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Full-Time Employee Benefits")]
    public Boolean? FullTimeBenefitIndicator { get => fullTimeBenefitIndicator; set => SetProperty(ref fullTimeBenefitIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Part-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for part-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Part-Time Employee Benefits")]
    public Boolean? PartTimeBenefitIndicator { get => partTimeBenefitIndicator; set => SetProperty(ref partTimeBenefitIndicator, value, false); }

    /// <summary>
    /// Full-Time Employee Benefits
    /// <para>
    /// The benefits offered by a program/facility/employer for full-time staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Full-Time Employee Benefits")]
    public Guid? RefEmployeeBenefitId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationEmployeeBenefit model)
    {
        IsBusy = true;
        Id = model.Id;
        FullTimeBenefitIndicator = model.FullTimeBenefitIndicator; // Full-Time Employee Benefits
        OrganizationId = model.OrganizationId; // 
        PartTimeBenefitIndicator = model.PartTimeBenefitIndicator; // Part-Time Employee Benefits
        RefEmployeeBenefitId = model.RefEmployeeBenefitId; // Full-Time Employee Benefits
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
