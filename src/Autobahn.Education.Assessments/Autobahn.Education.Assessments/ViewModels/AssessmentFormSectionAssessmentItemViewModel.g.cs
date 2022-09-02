//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentItem file
/// </summary>
public partial class AssessmentFormSectionAssessmentItemViewModel : ObservableValidator, IAssessmentFormSectionAssessmentItem
{
    #region "AssessmentFormSectionAssessmentItemViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentFormSectionAssessmentItemViewModel Constructor
    /// </summary>
    public AssessmentFormSectionAssessmentItemViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentFormSectionAssessmentItemViewModelConstruction();
    }

    /// <summary>
    /// AssessmentFormSectionAssessmentItemViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentFormSectionAssessmentItemViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentFormSectionAssessmentItem";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the SequenceNumber property
    private System.Int32 sequenceNumber;

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

    #region "IAssessmentFormSectionAssessmentItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
    /// </summary>
    public Guid AssessmentFormSectionItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 SequenceNumber { get => sequenceNumber; set => SetProperty(ref sequenceNumber, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentFormSectionAssessmentItem model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentFormSectionId = model.AssessmentFormSectionId; // 
        AssessmentFormSectionItemId = model.AssessmentFormSectionItemId; // 
        AssessmentItemId = model.AssessmentItemId; // 
        SequenceNumber = model.SequenceNumber; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
