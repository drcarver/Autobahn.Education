//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAeStaff file
/// </summary>
public partial class AeStaffViewModel : ObservableValidator, IAeStaff
{
    #region "AeStaffViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AeStaffViewModel Constructor
    /// </summary>
    public AeStaffViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAeStaffViewModelConstruction();
    }

    /// <summary>
    /// AeStaffViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAeStaffViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AeStaff";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // YearsOfPriorAeTeachingExperience -- (backing property for Years of Prior Adult Education Teaching Experience)
    private Decimal? yearsOfPriorAeTeachingExperience;

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

    #region "IAeStaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Adult Education Staff Classification
    /// <para>
    /// The titles of employment, official status, or rank of adult education staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
    /// </para>
    /// </summary>
    [DisplayName("Adult Education Staff Classification")]
    public Guid? RefAeStaffClassificationId { get; set; }

    /// <summary>
    /// Adult Education Staff Employment Status
    /// <para>
    /// The condition under which a person has agreed to serve as an employee.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Adult Education Staff Employment Status")]
    public Guid? RefAeStaffEmploymentStatusId { get; set; }

    /// <summary>
    /// Years of Prior Adult Education Teaching Experience
    /// <para>
    /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
    /// </para>
    /// </summary>
    [DisplayName("Years of Prior Adult Education Teaching Experience")]
    public Decimal? YearsOfPriorAeTeachingExperience { get => yearsOfPriorAeTeachingExperience; set => SetProperty(ref yearsOfPriorAeTeachingExperience, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAeStaff model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAeStaffClassificationId = model.RefAeStaffClassificationId; // Adult Education Staff Classification
        RefAeStaffEmploymentStatusId = model.RefAeStaffEmploymentStatusId; // Adult Education Staff Employment Status
        YearsOfPriorAeTeachingExperience = model.YearsOfPriorAeTeachingExperience; // Years of Prior Adult Education Teaching Experience
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
