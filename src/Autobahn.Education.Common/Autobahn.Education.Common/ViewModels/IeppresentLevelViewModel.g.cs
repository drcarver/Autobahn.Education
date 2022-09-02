//***************************************************************************
//* DomainName: Common Models
//* FileName:   IeppresentLevelViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIeppresentLevel file
/// </summary>
public partial class IeppresentLevelViewModel : ObservableValidator, IIeppresentLevel
{
    #region "IeppresentLevelViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IeppresentLevelViewModel Constructor
    /// </summary>
    public IeppresentLevelViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIeppresentLevelViewModelConstruction();
    }

    /// <summary>
    /// IeppresentLevelViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIeppresentLevelViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IeppresentLevel";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AcademicDescription property
    private System.String academicDescription;

    // member variable for the FunctionalDescription property
    private System.String functionalDescription;

    // member variable for the GeneralEducationDescription property
    private System.String generalEducationDescription;

    // member variable for the ParentConcernDescription property
    private System.String parentConcernDescription;

    // member variable for the PreschoolDescription property
    private System.String preschoolDescription;

    // member variable for the StudentConcernDescription property
    private System.String studentConcernDescription;

    // member variable for the StudentStrengthsDescription property
    private System.String studentStrengthsDescription;

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

    #region "IIeppresentLevel Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.String AcademicDescription { get => academicDescription; set => SetProperty(ref academicDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String FunctionalDescription { get => functionalDescription; set => SetProperty(ref functionalDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String GeneralEducationDescription { get => generalEducationDescription; set => SetProperty(ref generalEducationDescription, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String ParentConcernDescription { get => parentConcernDescription; set => SetProperty(ref parentConcernDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String PreschoolDescription { get => preschoolDescription; set => SetProperty(ref preschoolDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String StudentConcernDescription { get => studentConcernDescription; set => SetProperty(ref studentConcernDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String StudentStrengthsDescription { get => studentStrengthsDescription; set => SetProperty(ref studentStrengthsDescription, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIeppresentLevel model)
    {
        IsBusy = true;
        Id = model.Id;
        AcademicDescription = model.AcademicDescription; // 
        FunctionalDescription = model.FunctionalDescription; // 
        GeneralEducationDescription = model.GeneralEducationDescription; // 
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        ParentConcernDescription = model.ParentConcernDescription; // 
        PreschoolDescription = model.PreschoolDescription; // 
        StudentConcernDescription = model.StudentConcernDescription; // 
        StudentStrengthsDescription = model.StudentStrengthsDescription; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
