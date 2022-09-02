//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentRequirementViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentRequirement file
/// </summary>
public partial class ProfessionalDevelopmentRequirementViewModel : ObservableValidator, IProfessionalDevelopmentRequirement
{
    #region "ProfessionalDevelopmentRequirementViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProfessionalDevelopmentRequirementViewModel Constructor
    /// </summary>
    public ProfessionalDevelopmentRequirementViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProfessionalDevelopmentRequirementViewModelConstruction();
    }

    /// <summary>
    /// ProfessionalDevelopmentRequirementViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProfessionalDevelopmentRequirementViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProfessionalDevelopmentRequirement";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // RequiredTrainingClockHours -- (backing property for Required Training Clock Hours)
    private Decimal? requiredTrainingClockHours;

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

    #region "IProfessionalDevelopmentRequirement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Required Training Clock Hours
    /// <para>
    /// Number of clock hours of training required for providers to meet requirements of the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
    /// </para>
    /// </summary>
    [DisplayName("Required Training Clock Hours")]
    public Decimal? RequiredTrainingClockHours { get => requiredTrainingClockHours; set => SetProperty(ref requiredTrainingClockHours, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProfessionalDevelopmentRequirement model)
    {
        IsBusy = true;
        Id = model.Id;
        CompetencySetId = model.CompetencySetId; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RequiredTrainingClockHours = model.RequiredTrainingClockHours; // Required Training Clock Hours
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
