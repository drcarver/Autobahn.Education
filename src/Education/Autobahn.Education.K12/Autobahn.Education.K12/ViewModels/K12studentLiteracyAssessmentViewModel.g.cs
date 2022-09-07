//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentLiteracyAssessmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentLiteracyAssessment file
/// </summary>
public partial class K12studentLiteracyAssessmentViewModel : ObservableValidator, IK12studentLiteracyAssessment
{
    #region "K12studentLiteracyAssessmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentLiteracyAssessmentViewModel Constructor
    /// </summary>
    public K12studentLiteracyAssessmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentLiteracyAssessmentViewModelConstruction();
    }

    /// <summary>
    /// K12studentLiteracyAssessmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentLiteracyAssessmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentLiteracyAssessment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the LiteracyGoalMetStatus property
    private Boolean? literacyGoalMetStatus;

    // member variable for the LiteracyPostTestStatus property
    private Boolean? literacyPostTestStatus;

    // member variable for the LiteracyPreTestStatus property
    private Boolean? literacyPreTestStatus;

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

    #region "IK12studentLiteracyAssessment Properties"
    public Boolean? LiteracyGoalMetStatus { get => literacyGoalMetStatus; set => SetProperty(ref literacyGoalMetStatus, value, false); }

    public Boolean? LiteracyPostTestStatus { get => literacyPostTestStatus; set => SetProperty(ref literacyPostTestStatus, value, false); }

    public Boolean? LiteracyPreTestStatus { get => literacyPreTestStatus; set => SetProperty(ref literacyPreTestStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
    /// </summary>
    public Guid? RefLiteracyAssessmentId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentLiteracyAssessment model)
    {
        IsBusy = true;
        Id = model.Id;
        LiteracyGoalMetStatus = model.LiteracyGoalMetStatus; // 
        LiteracyPostTestStatus = model.LiteracyPostTestStatus; // 
        LiteracyPreTestStatus = model.LiteracyPreTestStatus; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefLiteracyAssessmentId = model.RefLiteracyAssessmentId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
