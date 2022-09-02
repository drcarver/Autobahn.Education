//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCategory file
/// </summary>
public partial class CredentialDefCategoryViewModel : ObservableValidator, ICredentialDefCategory
{
    #region "CredentialDefCategoryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialDefCategoryViewModel Constructor
    /// </summary>
    public CredentialDefCategoryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialDefCategoryViewModelConstruction();
    }

    /// <summary>
    /// CredentialDefCategoryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialDefCategoryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialDefCategory";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Category -- (backing property for Credential Definition Category Type)
    private System.String category;

    // CategorySystem -- (backing property for Credential Definition Category System)
    private System.String categorySystem;

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

    #region "ICredentialDefCategory Properties"
    /// <summary>
    /// Credential Definition Category Type
    /// <para>
    /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19892">Credential Definition Category Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Category Type")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Category { get => category; set => SetProperty(ref category, value, true); }

    /// <summary>
    /// Credential Definition Category System
    /// <para>
    /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Category System")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CategorySystem { get => categorySystem; set => SetProperty(ref categorySystem, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialDefCategory model)
    {
        IsBusy = true;
        Id = model.Id;
        Category = model.Category; // Credential Definition Category Type
        CategorySystem = model.CategorySystem; // Credential Definition Category System
        CredentialDefinitionId = model.CredentialDefinitionId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
