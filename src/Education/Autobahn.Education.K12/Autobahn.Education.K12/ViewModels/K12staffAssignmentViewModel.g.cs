//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12staffAssignmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffAssignment file
/// </summary>
public partial class K12staffAssignmentViewModel : ObservableValidator, IK12staffAssignment
{
    #region "K12staffAssignmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12staffAssignmentViewModel Constructor
    /// </summary>
    public K12staffAssignmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12staffAssignmentViewModelConstruction();
    }

    /// <summary>
    /// K12staffAssignmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12staffAssignmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12staffAssignment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ContributionPercentage property
    private Decimal? contributionPercentage;

    // member variable for the FullTimeEquivalency property
    private Decimal? fullTimeEquivalency;

    // member variable for the HighlyQualifiedTeacherIndicator property
    private Boolean? highlyQualifiedTeacherIndicator;

    // member variable for the ItinerantTeacher property
    private Boolean? itinerantTeacher;

    // member variable for the PrimaryAssignment property
    private Boolean? primaryAssignment;

    // member variable for the SpecialEducationParaprofessional property
    private Boolean? specialEducationParaprofessional;

    // member variable for the SpecialEducationRelatedServicesPersonnel property
    private Boolean? specialEducationRelatedServicesPersonnel;

    // member variable for the SpecialEducationTeacher property
    private Boolean? specialEducationTeacher;

    // member variable for the TeacherOfRecord property
    private Boolean? teacherOfRecord;

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

    #region "IK12staffAssignment Properties"
    public Decimal? ContributionPercentage { get => contributionPercentage; set => SetProperty(ref contributionPercentage, value, false); }

    public Decimal? FullTimeEquivalency { get => fullTimeEquivalency; set => SetProperty(ref fullTimeEquivalency, value, false); }

    public Boolean? HighlyQualifiedTeacherIndicator { get => highlyQualifiedTeacherIndicator; set => SetProperty(ref highlyQualifiedTeacherIndicator, value, false); }

    public Boolean? ItinerantTeacher { get => itinerantTeacher; set => SetProperty(ref itinerantTeacher, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public Boolean? PrimaryAssignment { get => primaryAssignment; set => SetProperty(ref primaryAssignment, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
    /// </summary>
    public Guid? RefClassroomPositionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEdfactsTeacherInexperiencedStatus"/> model
    /// </summary>
    public Guid? RefEdfactsTeacherInexperiencedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
    /// </summary>
    public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    public Guid? RefK12staffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
    /// </summary>
    public Guid? RefMepStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
    /// </summary>
    public Guid? RefOutOfFieldStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
    /// </summary>
    public Guid? RefProfessionalEducationJobClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
    /// </summary>
    public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
    /// </summary>
    public Guid? RefSpecialEducationStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
    /// </summary>
    public Guid? RefTeachingAssignmentRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramStaffCategory"/> model
    /// </summary>
    public Guid? RefTitleIprogramStaffCategoryId { get; set; }

    public Boolean? SpecialEducationParaprofessional { get => specialEducationParaprofessional; set => SetProperty(ref specialEducationParaprofessional, value, false); }

    public Boolean? SpecialEducationRelatedServicesPersonnel { get => specialEducationRelatedServicesPersonnel; set => SetProperty(ref specialEducationRelatedServicesPersonnel, value, false); }

    public Boolean? SpecialEducationTeacher { get => specialEducationTeacher; set => SetProperty(ref specialEducationTeacher, value, false); }

    public Boolean? TeacherOfRecord { get => teacherOfRecord; set => SetProperty(ref teacherOfRecord, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12staffAssignment model)
    {
        IsBusy = true;
        Id = model.Id;
        ContributionPercentage = model.ContributionPercentage; // 
        FullTimeEquivalency = model.FullTimeEquivalency; // 
        HighlyQualifiedTeacherIndicator = model.HighlyQualifiedTeacherIndicator; // 
        ItinerantTeacher = model.ItinerantTeacher; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        PrimaryAssignment = model.PrimaryAssignment; // 
        RefClassroomPositionTypeId = model.RefClassroomPositionTypeId; // 
        RefEdfactsTeacherInexperiencedStatusId = model.RefEdfactsTeacherInexperiencedStatusId; // 
        RefEmergencyOrProvisionalCredentialStatusId = model.RefEmergencyOrProvisionalCredentialStatusId; // 
        RefK12staffClassificationId = model.RefK12staffClassificationId; // 
        RefMepStaffCategoryId = model.RefMepStaffCategoryId; // 
        RefOutOfFieldStatusId = model.RefOutOfFieldStatusId; // 
        RefProfessionalEducationJobClassificationId = model.RefProfessionalEducationJobClassificationId; // 
        RefSpecialEducationAgeGroupTaughtId = model.RefSpecialEducationAgeGroupTaughtId; // 
        RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // 
        RefTeachingAssignmentRoleId = model.RefTeachingAssignmentRoleId; // 
        RefTitleIprogramStaffCategoryId = model.RefTitleIprogramStaffCategoryId; // 
        SpecialEducationParaprofessional = model.SpecialEducationParaprofessional; // 
        SpecialEducationRelatedServicesPersonnel = model.SpecialEducationRelatedServicesPersonnel; // 
        SpecialEducationTeacher = model.SpecialEducationTeacher; // 
        TeacherOfRecord = model.TeacherOfRecord; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
