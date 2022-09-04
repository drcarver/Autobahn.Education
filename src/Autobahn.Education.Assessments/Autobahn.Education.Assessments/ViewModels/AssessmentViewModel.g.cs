//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessment file
/// </summary>
public partial class AssessmentViewModel : ObservableValidator, IAssessment
{
    #region "AssessmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentViewModel Constructor
    /// </summary>
    public AssessmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentViewModelConstruction();
    }

    /// <summary>
    /// AssessmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Assessment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentFamilyShortName -- (backing property for Assessment Family Short Name)
    private System.String assessmentFamilyShortName;

    // AssessmentFamilyTitle -- (backing property for Assessment Family Title)
    private System.String assessmentFamilyTitle;

    // AssessmentRevisionDate -- (backing property for Assessment Revision Date)
    private DateTime? assessmentRevisionDate;

    // member variable for the Guid property
    private System.String guid;

    // IdentificationSystem -- (backing property for Assessment Identification System)
    private Int32? identificationSystem;

    // Identifier -- (backing property for Assessment Identifier)
    private System.String identifier;

    // Objective -- (backing property for Assessment Objective)
    private System.String objective;

    // Provider -- (backing property for Assessment Provider)
    private System.String provider;

    // ShortName -- (backing property for Assessment Short Name)
    private System.String shortName;

    // Title -- (backing property for Assessment Title)
    private System.String title;

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

    #region "IAssessment Properties"
    /// <summary>
    /// Assessment Family Short Name
    /// <para>
    /// The abbreviated title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19934">Assessment Family Short Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Family Short Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFamilyShortName { get => assessmentFamilyShortName; set => SetProperty(ref assessmentFamilyShortName, value, true); }

    /// <summary>
    /// Assessment Family Title
    /// <para>
    /// The full title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus, such as Graduate Record Exam or National Assessment of Educational Progress.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19933">Assessment Family Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Family Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFamilyTitle { get => assessmentFamilyTitle; set => SetProperty(ref assessmentFamilyTitle, value, true); }

    /// <summary>
    /// Assessment Revision Date
    /// <para>
    /// The month, day, and year that the conceptual design for the assessment was most recently revised substantially.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20519">Assessment Revision Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Revision Date")]
    public DateTime? AssessmentRevisionDate { get => assessmentRevisionDate; set => SetProperty(ref assessmentRevisionDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Guid { get => guid; set => SetProperty(ref guid, value, true); }

    /// <summary>
    /// Assessment Identification System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19158">Assessment Identification System</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Identification System")]
    public Int32? IdentificationSystem { get => identificationSystem; set => SetProperty(ref identificationSystem, value, false); }

    /// <summary>
    /// Assessment Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity.  This may be the publisher identifier.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19152">Assessment Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Assessment Objective
    /// <para>
    /// This is the objective that the assessment is measuring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19373">Assessment Objective</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Objective")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Objective { get => objective; set => SetProperty(ref objective, value, true); }

    /// <summary>
    /// Assessment Provider
    /// <para>
    /// Identifies the provider or publisher of the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20009">Assessment Provider</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Provider")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Provider { get => provider; set => SetProperty(ref provider, value, true); }

    /// <summary>
    /// Assessment Academic Subject
    /// <para>
    /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Academic Subject")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Assessment Purpose
    /// <para>
    /// The reason for which an assessment is designed or delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Purpose")]
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Assessment Type Administered to Children with Disabilities
    /// <para>
    /// The types of assessments administered to children with disabilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19405">Assessment Type Administered to Children with Disabilities</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Type Administered to Children with Disabilities")]
    public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    /// <summary>
    /// Assessment Type
    /// <para>
    /// The category of an assessment based on format and content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19029">Assessment Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Type")]
    public Guid? RefAssessmentTypeId { get; set; }

    /// <summary>
    /// Assessment Short Name
    /// <para>
    /// An abbreviated title for an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19932">Assessment Short Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Short Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ShortName { get => shortName; set => SetProperty(ref shortName, value, true); }

    /// <summary>
    /// Assessment Title
    /// <para>
    /// The title or name of the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19028">Assessment Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessment model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentFamilyShortName = model.AssessmentFamilyShortName; // Assessment Family Short Name
        AssessmentFamilyTitle = model.AssessmentFamilyTitle; // Assessment Family Title
        AssessmentRevisionDate = model.AssessmentRevisionDate; // Assessment Revision Date
        Guid = model.Guid; // 
        IdentificationSystem = model.IdentificationSystem; // Assessment Identification System
        Identifier = model.Identifier; // Assessment Identifier
        Objective = model.Objective; // Assessment Objective
        Provider = model.Provider; // Assessment Provider
        RefAcademicSubjectId = model.RefAcademicSubjectId; // Assessment Academic Subject
        RefAssessmentPurposeId = model.RefAssessmentPurposeId; // Assessment Purpose
        RefAssessmentTypeChildrenWithDisabilitiesId = model.RefAssessmentTypeChildrenWithDisabilitiesId; // Assessment Type Administered to Children with Disabilities
        RefAssessmentTypeId = model.RefAssessmentTypeId; // Assessment Type
        ShortName = model.ShortName; // Assessment Short Name
        Title = model.Title; // Assessment Title
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
