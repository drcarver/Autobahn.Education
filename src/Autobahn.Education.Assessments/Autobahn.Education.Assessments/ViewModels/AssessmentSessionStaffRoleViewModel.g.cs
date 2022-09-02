//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSessionStaffRole file
/// </summary>
public partial class AssessmentSessionStaffRoleViewModel : ObservableValidator, IAssessmentSessionStaffRole
{
    #region "AssessmentSessionStaffRoleViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentSessionStaffRoleViewModel Constructor
    /// </summary>
    public AssessmentSessionStaffRoleViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentSessionStaffRoleViewModelConstruction();
    }

    /// <summary>
    /// AssessmentSessionStaffRoleViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentSessionStaffRoleViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentSessionStaffRole";

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

    #region "IAssessmentSessionStaffRole Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    public Guid? AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    public Guid? AssessmentSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Session Staff Role Type
    /// <para>
    /// The type of role served related to the administration of an assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Staff Role Type")]
    public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentSessionStaffRole model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentParticipantSessionId = model.AssessmentParticipantSessionId; // 
        AssessmentSessionId = model.AssessmentSessionId; // 
        PersonId = model.PersonId; // 
        RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId; // Assessment Session Staff Role Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
