//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAllergyViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAllergy file
/// </summary>
public partial class PersonAllergyViewModel : ObservableValidator, IPersonAllergy
{
    #region "PersonAllergyViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonAllergyViewModel Constructor
    /// </summary>
    public PersonAllergyViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonAllergyViewModelConstruction();
    }

    /// <summary>
    /// PersonAllergyViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonAllergyViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonAllergy";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ReactionDescription -- (backing property for Allergy Reaction Description)
    private System.String reactionDescription;

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

    #region "IPersonAllergy Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Allergy Reaction Description
    /// <para>
    /// Describes symptoms know to be associated with a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Allergy Reaction Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ReactionDescription { get => reactionDescription; set => SetProperty(ref reactionDescription, value, true); }

    /// <summary>
    /// Allergy Severity
    /// <para>
    /// The level of severity of a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
    /// </para>
    /// </summary>
    [DisplayName("Allergy Severity")]
    public Guid? RefAllergySeverityId { get; set; }

    /// <summary>
    /// Allergy Type
    /// <para>
    /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Allergy Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefAllergyTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonAllergy model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        ReactionDescription = model.ReactionDescription; // Allergy Reaction Description
        RefAllergySeverityId = model.RefAllergySeverityId; // Allergy Severity
        RefAllergyTypeId = model.RefAllergyTypeId; // Allergy Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
