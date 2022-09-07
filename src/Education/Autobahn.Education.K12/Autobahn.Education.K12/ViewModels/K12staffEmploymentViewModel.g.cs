//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12staffEmploymentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffEmployment file
/// </summary>
public partial class K12staffEmploymentViewModel : ObservableValidator, IK12staffEmployment
{
    #region "K12staffEmploymentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12staffEmploymentViewModel Constructor
    /// </summary>
    public K12staffEmploymentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12staffEmploymentViewModelConstruction();
    }

    /// <summary>
    /// K12staffEmploymentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12staffEmploymentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12staffEmployment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ContractDaysOfServicePerYear property
    private Decimal? contractDaysOfServicePerYear;

    // member variable for the MepPersonnelIndicator property
    private Boolean? mepPersonnelIndicator;

    // member variable for the SalaryForTeachingAssignmentOnlyIndicator property
    private Boolean? salaryForTeachingAssignmentOnlyIndicator;

    // member variable for the TitleItargetedAssistanceStaffFunded property
    private Boolean? titleItargetedAssistanceStaffFunded;

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

    #region "IK12staffEmployment Properties"
    public Decimal? ContractDaysOfServicePerYear { get => contractDaysOfServicePerYear; set => SetProperty(ref contractDaysOfServicePerYear, value, false); }

    public Boolean? MepPersonnelIndicator { get => mepPersonnelIndicator; set => SetProperty(ref mepPersonnelIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    public Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    public Guid? RefK12staffClassificationId { get; set; }

    public Boolean? SalaryForTeachingAssignmentOnlyIndicator { get => salaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref salaryForTeachingAssignmentOnlyIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    public Guid StaffEmploymentId { get; set; }

    public Boolean? TitleItargetedAssistanceStaffFunded { get => titleItargetedAssistanceStaffFunded; set => SetProperty(ref titleItargetedAssistanceStaffFunded, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12staffEmployment model)
    {
        IsBusy = true;
        Id = model.Id;
        ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear; // 
        MepPersonnelIndicator = model.MepPersonnelIndicator; // 
        RefEmploymentStatusId = model.RefEmploymentStatusId; // 
        RefK12staffClassificationId = model.RefK12staffClassificationId; // 
        SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator; // 
        StaffEmploymentId = model.StaffEmploymentId; // 
        TitleItargetedAssistanceStaffFunded = model.TitleItargetedAssistanceStaffFunded; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
