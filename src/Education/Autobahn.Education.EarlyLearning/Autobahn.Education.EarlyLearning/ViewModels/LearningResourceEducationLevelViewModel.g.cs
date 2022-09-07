//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   LearningResourceEducationLevelViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceEducationLevel file
/// </summary>
public partial class LearningResourceEducationLevelViewModel : ObservableValidator, ILearningResourceEducationLevel
{
    #region "LearningResourceEducationLevelViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// LearningResourceEducationLevelViewModel Constructor
    /// </summary>
    public LearningResourceEducationLevelViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnLearningResourceEducationLevelViewModelConstruction();
    }

    /// <summary>
    /// LearningResourceEducationLevelViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnLearningResourceEducationLevelViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from LearningResourceEducationLevel";

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

    #region "ILearningResourceEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Education Level�
    /// <para>
    /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Education Level�")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefEducationLevelId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ILearningResourceEducationLevel model)
    {
        IsBusy = true;
        Id = model.Id;
        LearningResourceId = model.LearningResourceId; // 
        RefEducationLevelId = model.RefEducationLevelId; // Learning Resource Education Level�
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
