//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEmploymentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEmployment file
/// </summary>
public partial class ElstaffEmploymentViewModel : ObservableValidator, IElstaffEmployment
{
    #region "ElstaffEmploymentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElstaffEmploymentViewModel Constructor
    /// </summary>
    public ElstaffEmploymentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElstaffEmploymentViewModelConstruction();
    }

    /// <summary>
    /// ElstaffEmploymentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElstaffEmploymentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElstaffEmployment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the HourlyWage property
    private Decimal? hourlyWage;

    // member variable for the HoursWorkedPerWeek property
    private Decimal? hoursWorkedPerWeek;

    // member variable for the StaffApprovalIndicator property
    private Boolean? staffApprovalIndicator;

    // member variable for the UnionMembershipStatus property
    private Boolean? unionMembershipStatus;

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

    #region "IElstaffEmployment Properties"
    public Decimal? HourlyWage { get => hourlyWage; set => SetProperty(ref hourlyWage, value, false); }

    public Decimal? HoursWorkedPerWeek { get => hoursWorkedPerWeek; set => SetProperty(ref hoursWorkedPerWeek, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEleducationStaffClassification"/> model
    /// </summary>
    public Guid? RefEleducationStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElemploymentSeparationReason"/> model
    /// </summary>
    public Guid? RefElemploymentSeparationReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceProfessionalStaffClassification"/> model
    /// </summary>
    public Guid? RefElserviceProfessionalStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    public Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
    /// </summary>
    public Guid? RefWageCollectionMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
    /// </summary>
    public Guid? RefWageVerificationId { get; set; }

    public Boolean? StaffApprovalIndicator { get => staffApprovalIndicator; set => SetProperty(ref staffApprovalIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    public Guid StaffEmploymentId { get; set; }

    public Boolean? UnionMembershipStatus { get => unionMembershipStatus; set => SetProperty(ref unionMembershipStatus, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElstaffEmployment model)
    {
        IsBusy = true;
        Id = model.Id;
        HourlyWage = model.HourlyWage; // 
        HoursWorkedPerWeek = model.HoursWorkedPerWeek; // 
        RefEleducationStaffClassificationId = model.RefEleducationStaffClassificationId; // 
        RefElemploymentSeparationReasonId = model.RefElemploymentSeparationReasonId; // 
        RefElserviceProfessionalStaffClassificationId = model.RefElserviceProfessionalStaffClassificationId; // 
        RefEmploymentStatusId = model.RefEmploymentStatusId; // 
        RefWageCollectionMethodId = model.RefWageCollectionMethodId; // 
        RefWageVerificationId = model.RefWageVerificationId; // 
        StaffApprovalIndicator = model.StaffApprovalIndicator; // 
        StaffEmploymentId = model.StaffEmploymentId; // 
        UnionMembershipStatus = model.UnionMembershipStatus; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
