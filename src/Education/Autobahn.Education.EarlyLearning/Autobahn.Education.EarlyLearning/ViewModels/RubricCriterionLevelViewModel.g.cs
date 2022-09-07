//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RubricCriterionLevelViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRubricCriterionLevel file
/// </summary>
public partial class RubricCriterionLevelViewModel : ObservableValidator, IRubricCriterionLevel
{
    #region "RubricCriterionLevelViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RubricCriterionLevelViewModel Constructor
    /// </summary>
    public RubricCriterionLevelViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRubricCriterionLevelViewModelConstruction();
    }

    /// <summary>
    /// RubricCriterionLevelViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRubricCriterionLevelViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RubricCriterionLevel";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Feedback -- (backing property for Rubric Criterion Level Feedback)
    private System.String feedback;

    // Position -- (backing property for Rubric Criterion Level Position)
    private Int32? position;

    // Quality -- (backing property for Rubric Criterion Level Quality Label)
    private System.String quality;

    // Score -- (backing property for Rubric Criterion Level Score)
    private Decimal? score;

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

    #region "IRubricCriterionLevel Properties"
    /// <summary>
    /// Rubric Criterion Level Feedback
    /// <para>
    /// Pre-defined feedback text to be relayed to the person or organization being evaluated.  This may include guidance and suggestions for improvement or development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20444">Rubric Criterion Level Feedback</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Level Feedback")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Feedback { get => feedback; set => SetProperty(ref feedback, value, true); }

    /// <summary>
    /// Rubric Criterion Level Position
    /// <para>
    /// A numeric value representing the level's position in the list of levels defined for the Rubric Criterion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20445">Rubric Criterion Level Position</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Level Position")]
    public Int32? Position { get => position; set => SetProperty(ref position, value, false); }

    /// <summary>
    /// Rubric Criterion Level Quality Label
    /// <para>
    /// A qualitative description of this degree of achievement used for column headers or row labels in tabular rubrics.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20446">Rubric Criterion Level Quality Label</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Level Quality Label")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Quality { get => quality; set => SetProperty(ref quality, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
    /// </summary>
    public Guid RubricCriterionId { get; set; }

    /// <summary>
    /// Rubric Criterion Level Score
    /// <para>
    /// The points awarded for achieving this level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20447">Rubric Criterion Level Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Criterion Level Score")]
    public Decimal? Score { get => score; set => SetProperty(ref score, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRubricCriterionLevel model)
    {
        IsBusy = true;
        Id = model.Id;
        Feedback = model.Feedback; // Rubric Criterion Level Feedback
        Position = model.Position; // Rubric Criterion Level Position
        Quality = model.Quality; // Rubric Criterion Level Quality Label
        RubricCriterionId = model.RubricCriterionId; // 
        Score = model.Score; // Rubric Criterion Level Score
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
