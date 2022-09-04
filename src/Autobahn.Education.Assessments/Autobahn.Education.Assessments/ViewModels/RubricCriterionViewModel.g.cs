//***************************************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRubricCriterion file
/// </summary>
public partial class RubricCriterionViewModel : ObservableValidator, IRubricCriterion
{
    #region "RubricCriterionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RubricCriterionViewModel Constructor
    /// </summary>
    public RubricCriterionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRubricCriterionViewModelConstruction();
    }

    /// <summary>
    /// RubricCriterionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRubricCriterionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RubricCriterion";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Category -- (backing property for Rubric Criterion Category)
    private System.String category;

    // Position -- (backing property for Rubric Criterion Position)
    private Int32? position;

    // Title -- (backing property for Rubric Criterion Title)
    private System.String title;

    // Weight -- (backing property for Rubric Criterion Weight)
    private Decimal? weight;

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

    #region "IRubricCriterion Properties"
    /// <summary>
    /// Rubric Criterion Category
    /// <para>
    /// A textual label for category by which Rubric Criterion may be grouped.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20441">Rubric Criterion Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Category")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Category { get => category; set => SetProperty(ref category, value, true); }

    /// <summary>
    /// Rubric Criterion Position
    /// <para>
    /// A numeric value representing this criterion's position in the criteria list for this rubric.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20448">Rubric Criterion Position</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Position")]
    public Int32? Position { get => position; set => SetProperty(ref position, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    public Guid RubricId { get; set; }

    /// <summary>
    /// Rubric Criterion Title
    /// <para>
    /// The title of the rubric criterion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20449">Rubric Criterion Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Rubric Criterion Weight
    /// <para>
    /// A numeric weight assigned to this Rubric Criterion, used for scored rubrics.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20450">Rubric Criterion Weight</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Weight")]
    public Decimal? Weight { get => weight; set => SetProperty(ref weight, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRubricCriterion model)
    {
        IsBusy = true;
        Id = model.Id;
        Category = model.Category; // Rubric Criterion Category
        Position = model.Position; // Rubric Criterion Position
        RubricId = model.RubricId; // 
        Title = model.Title; // Rubric Criterion Title
        Weight = model.Weight; // Rubric Criterion Weight
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
