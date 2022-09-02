//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffExperience file
/// </summary>
public partial class StaffExperienceViewModel : ObservableValidator, IStaffExperience
{
    #region "StaffExperienceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffExperienceViewModel Constructor
    /// </summary>
    public StaffExperienceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffExperienceViewModelConstruction();
    }

    /// <summary>
    /// StaffExperienceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffExperienceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffExperience";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the YearsOfPriorAeteachingExperience property
    private Decimal? yearsOfPriorAeteachingExperience;

    // YearsOfPriorTeachingExperience -- (backing property for Years of Prior Teaching Experience)
    private Decimal? yearsOfPriorTeachingExperience;

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

    #region "IStaffExperience Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public Decimal? YearsOfPriorAeteachingExperience { get => yearsOfPriorAeteachingExperience; set => SetProperty(ref yearsOfPriorAeteachingExperience, value, false); }

    /// <summary>
    /// Years of Prior Teaching Experience
    /// <para>
    /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
    /// </para>
    /// </summary>
    [DisplayName("Years of Prior Teaching Experience")]
    public Decimal? YearsOfPriorTeachingExperience { get => yearsOfPriorTeachingExperience; set => SetProperty(ref yearsOfPriorTeachingExperience, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffExperience model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        YearsOfPriorAeteachingExperience = model.YearsOfPriorAeteachingExperience; // 
        YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience; // Years of Prior Teaching Experience
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
