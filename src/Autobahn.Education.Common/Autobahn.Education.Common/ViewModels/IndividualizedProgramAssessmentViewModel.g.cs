//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessment file
/// </summary>
public partial class IndividualizedProgramAssessmentViewModel : ObservableValidator, IIndividualizedProgramAssessment
{
    #region "IndividualizedProgramAssessmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramAssessmentViewModel Constructor
    /// </summary>
    public IndividualizedProgramAssessmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramAssessmentViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramAssessmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramAssessmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramAssessment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the IepalternativeAssessmentRationale property
    private System.String iepalternativeAssessmentRationale;

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

    #region "IIndividualizedProgramAssessment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String IepalternativeAssessmentRationale { get => iepalternativeAssessmentRationale; set => SetProperty(ref iepalternativeAssessmentRationale, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramAssessment model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentId = model.AssessmentId; // 
        IepalternativeAssessmentRationale = model.IepalternativeAssessmentRationale; // 
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
