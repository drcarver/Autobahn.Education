//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSection file
/// </summary>
public partial class AssessmentFormAssessmentFormSectionViewModel : ObservableValidator, IAssessmentFormAssessmentFormSection
{
    #region "AssessmentFormAssessmentFormSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentFormAssessmentFormSectionViewModel Constructor
    /// </summary>
    public AssessmentFormAssessmentFormSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentFormAssessmentFormSectionViewModelConstruction();
    }

    /// <summary>
    /// AssessmentFormAssessmentFormSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentFormAssessmentFormSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentFormAssessmentFormSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the SequenceNumber property
    private Int32? sequenceNumber;

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

    #region "IAssessmentFormAssessmentFormSection Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormSectionId { get; set; }

    public Int32? SequenceNumber { get => sequenceNumber; set => SetProperty(ref sequenceNumber, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentFormAssessmentFormSection model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentFormId = model.AssessmentFormId; // 
        AssessmentFormSectionId = model.AssessmentFormSectionId; // 
        SequenceNumber = model.SequenceNumber; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
