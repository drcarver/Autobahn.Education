//***************************************************************************
//* DomainName: Competencies
//* FileName:   RubricViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRubric file
/// </summary>
public partial class RubricViewModel : ObservableValidator, IRubric
{
    #region "RubricViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RubricViewModel Constructor
    /// </summary>
    public RubricViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRubricViewModelConstruction();
    }

    /// <summary>
    /// RubricViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRubricViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Rubric";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Identifier -- (backing property for Rubric Identifier)
    private System.String identifier;

    // Title -- (backing property for Rubric Title)
    private System.String title;

    // UrlReference -- (backing property for Rubric URL Reference)
    private System.String urlReference;

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

    #region "IRubric Properties"
    /// <summary>
    /// Rubric Identifier
    /// <para>
    /// An identifier assigned to a rubric.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19412">Rubric Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Rubric Title
    /// <para>
    /// The title of the rubric.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19411">Rubric Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Rubric URL Reference
    /// <para>
    /// The URL location where the rubric may be found.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19413">Rubric URL Reference</a>
    /// </para>
    /// </summary>
    [DisplayName("Rubric URL Reference")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String UrlReference { get => urlReference; set => SetProperty(ref urlReference, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRubric model)
    {
        IsBusy = true;
        Id = model.Id;
        Identifier = model.Identifier; // Rubric Identifier
        Title = model.Title; // Rubric Title
        UrlReference = model.UrlReference; // Rubric URL Reference
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
