//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElenrollmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollment file
/// </summary>
public partial class ElenrollmentViewModel : ObservableValidator, IElenrollment
{
    #region "ElenrollmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElenrollmentViewModel Constructor
    /// </summary>
    public ElenrollmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElenrollmentViewModelConstruction();
    }

    /// <summary>
    /// ElenrollmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElenrollmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Elenrollment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the EnrollmentDate property
    private DateTime? enrollmentDate;

    // member variable for the NumberOfDaysInAttendance property
    private Decimal? numberOfDaysInAttendance;

    // member variable for the RefIdeaenvironmentElid property
    private Int32? refIdeaenvironmentElid;

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

    #region "IElenrollment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    public Guid? ElclassSectionId { get; set; }

    public DateTime? EnrollmentDate { get => enrollmentDate; set => SetProperty(ref enrollmentDate, value, false); }

    public Decimal? NumberOfDaysInAttendance { get => numberOfDaysInAttendance; set => SetProperty(ref numberOfDaysInAttendance, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    public Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
    /// </summary>
    public Guid? RefFoodServiceParticipationId { get; set; }

    public Int32? RefIdeaenvironmentElid { get => refIdeaenvironmentElid; set => SetProperty(ref refIdeaenvironmentElid, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    public Guid? RefServiceOptionId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElenrollment model)
    {
        IsBusy = true;
        Id = model.Id;
        ElclassSectionId = model.ElclassSectionId; // 
        EnrollmentDate = model.EnrollmentDate; // 
        NumberOfDaysInAttendance = model.NumberOfDaysInAttendance; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefElfederalFundingTypeId = model.RefElfederalFundingTypeId; // 
        RefFoodServiceParticipationId = model.RefFoodServiceParticipationId; // 
        RefIdeaenvironmentElid = model.RefIdeaenvironmentElid; // 
        RefServiceOptionId = model.RefServiceOptionId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
