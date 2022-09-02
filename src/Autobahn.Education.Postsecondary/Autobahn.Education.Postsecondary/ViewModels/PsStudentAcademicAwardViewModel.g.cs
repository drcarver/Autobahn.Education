//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAcademicAward file
/// </summary>
public partial class PsStudentAcademicAwardViewModel : ObservableValidator, IPsStudentAcademicAward
{
    #region "PsStudentAcademicAwardViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentAcademicAwardViewModel Constructor
    /// </summary>
    public PsStudentAcademicAwardViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentAcademicAwardViewModelConstruction();
    }

    /// <summary>
    /// PsStudentAcademicAwardViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentAcademicAwardViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentAcademicAward";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AcademicAwardDate -- (backing property for Academic Award Date)
    private System.String academicAwardDate;

    // AcademicAwardTitle -- (backing property for Academic Award Title)
    private System.String academicAwardTitle;

    // member variable for the RequirementsUrl property
    private System.String requirementsUrl;

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

    #region "IPsStudentAcademicAward Properties"
    /// <summary>
    /// Academic Award Date
    /// <para>
    /// The year, month and day or year and month on which the academic award was conferred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Award Date")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(14,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AcademicAwardDate { get => academicAwardDate; set => SetProperty(ref academicAwardDate, value, true); }

    /// <summary>
    /// Academic Award Title
    /// <para>
    /// The descriptive title for the academic award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Award Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AcademicAwardTitle { get => academicAwardTitle; set => SetProperty(ref academicAwardTitle, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Academic Award Level Conferred
    /// <para>
    /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Award Level Conferred")]
    public Guid? RefAcademicAwardLevelId { get; set; }

    /// <summary>
    /// Academic Award Prerequisite Type
    /// <para>
    /// Prerequisite conditions for earning an academic award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Award Prerequisite Type")]
    public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPescawardLevelType"/> model
    /// </summary>
    public Guid? RefPescawardLevelTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RequirementsUrl { get => requirementsUrl; set => SetProperty(ref requirementsUrl, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentAcademicAward model)
    {
        IsBusy = true;
        Id = model.Id;
        AcademicAwardDate = model.AcademicAwardDate; // Academic Award Date
        AcademicAwardTitle = model.AcademicAwardTitle; // Academic Award Title
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAcademicAwardLevelId = model.RefAcademicAwardLevelId; // Academic Award Level Conferred
        RefAcademicAwardPrerequisiteTypeId = model.RefAcademicAwardPrerequisiteTypeId; // Academic Award Prerequisite Type
        RefPescawardLevelTypeId = model.RefPescawardLevelTypeId; // 
        RequirementsUrl = model.RequirementsUrl; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
