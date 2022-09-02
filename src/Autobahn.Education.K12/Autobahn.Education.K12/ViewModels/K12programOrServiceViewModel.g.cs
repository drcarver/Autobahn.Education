//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12programOrServiceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12programOrService file
/// </summary>
public partial class K12programOrServiceViewModel : ObservableValidator, IK12programOrService
{
    #region "K12programOrServiceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12programOrServiceViewModel Constructor
    /// </summary>
    public K12programOrServiceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12programOrServiceViewModelConstruction();
    }

    /// <summary>
    /// K12programOrServiceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12programOrServiceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12programOrService";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ProgramInMultiplePurposeFacility property
    private Boolean? programInMultiplePurposeFacility;

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

    #region "IK12programOrService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public Boolean? ProgramInMultiplePurposeFacility { get => programInMultiplePurposeFacility; set => SetProperty(ref programInMultiplePurposeFacility, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
    /// </summary>
    public Guid? RefKindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
    /// </summary>
    public Guid? RefMepProjectTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
    /// </summary>
    public Guid? RefMepSessionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
    /// </summary>
    public Guid? RefPrekindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
    /// </summary>
    public Guid? RefProgramGiftedEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
    /// </summary>
    public Guid? RefTitleIinstructionalServicesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramType"/> model
    /// </summary>
    public Guid? RefTitleIprogramTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12programOrService model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationId = model.OrganizationId; // 
        ProgramInMultiplePurposeFacility = model.ProgramInMultiplePurposeFacility; // 
        RefKindergartenDailyLengthId = model.RefKindergartenDailyLengthId; // 
        RefMepProjectTypeId = model.RefMepProjectTypeId; // 
        RefMepSessionTypeId = model.RefMepSessionTypeId; // 
        RefPrekindergartenDailyLengthId = model.RefPrekindergartenDailyLengthId; // 
        RefProgramGiftedEligibilityId = model.RefProgramGiftedEligibilityId; // 
        RefTitleIinstructionalServicesId = model.RefTitleIinstructionalServicesId; // 
        RefTitleIprogramTypeId = model.RefTitleIprogramTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
