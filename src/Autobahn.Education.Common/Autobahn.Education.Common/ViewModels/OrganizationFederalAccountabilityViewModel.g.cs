//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFederalAccountability file
/// </summary>
public partial class OrganizationFederalAccountabilityViewModel : ObservableValidator, IOrganizationFederalAccountability
{
    #region "OrganizationFederalAccountabilityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationFederalAccountabilityViewModel Constructor
    /// </summary>
    public OrganizationFederalAccountabilityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationFederalAccountabilityViewModelConstruction();
    }

    /// <summary>
    /// OrganizationFederalAccountabilityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationFederalAccountabilityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationFederalAccountability";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AccountabilityReportTitle -- (backing property for Accountability Report Title)
    private System.String accountabilityReportTitle;

    // AlternateAypApproachIndicator -- (backing property for Alternate Adequate Yearly Progress Approach Indicator)
    private Boolean? alternateAypApproachIndicator;

    // AmaoAypProgressAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students)
    private Int32? amaoAypProgressAttainmentLepStudents;

    // AmaoProficiencyAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students)
    private Int32? amaoProficiencyAttainmentLepStudents;

    // AmaoProgressAttainmentLepStudents -- (backing property for Annual Measurable Achievement Objective Progress Attainment Status for LEP Students)
    private Int32? amaoProgressAttainmentLepStudents;

    // AypAppealChangedDesignation -- (backing property for Adequate Yearly Progress Appeal Changed Designation)
    private Boolean? aypAppealChangedDesignation;

    // AypAppealProcessDate -- (backing property for Adequate Yearly Progress Appeal Process Date)
    private DateTime? aypAppealProcessDate;

    // AypAppealProcessDesignation -- (backing property for Appealed Adequate Yearly Progress Designation)
    private Boolean? aypAppealProcessDesignation;

    // PersistentlyDangerousStatus -- (backing property for Persistently Dangerous Status)
    private Boolean? persistentlyDangerousStatus;

    // member variable for the RefProficiencyTargetStatusRlaid property
    private Int32? refProficiencyTargetStatusRlaid;

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

    #region "IOrganizationFederalAccountability Properties"
    /// <summary>
    /// Accountability Report Title
    /// <para>
    /// The title of the accountability report.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19005">Accountability Report Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Accountability Report Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AccountabilityReportTitle { get => accountabilityReportTitle; set => SetProperty(ref accountabilityReportTitle, value, true); }

    /// <summary>
    /// Alternate Adequate Yearly Progress Approach Indicator
    /// <para>
    /// An indication of whether the district or school used an approved alternate approach for calculating Adequate Yearly Progress (AYP).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19014">Alternate Adequate Yearly Progress Approach Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Alternate Adequate Yearly Progress Approach Indicator")]
    public Boolean? AlternateAypApproachIndicator { get => alternateAypApproachIndicator; set => SetProperty(ref alternateAypApproachIndicator, value, false); }

    /// <summary>
    /// Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
    /// <para>
    /// An indication of whether the state or district met the annual measurable objectives for the Limited English Proficient (LEP) student subgroup in mathematics and reading/language arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19572">Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [DisplayName("Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students")]
    public Int32? AmaoAypProgressAttainmentLepStudents { get => amaoAypProgressAttainmentLepStudents; set => SetProperty(ref amaoAypProgressAttainmentLepStudents, value, false); }

    /// <summary>
    /// Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
    /// <para>
    /// An indication whether the state, district or school met the Annual Measurable Achievement Objectives (AMAO) for attaining English proficiency for limited English proficient (LEP) students under Title III of ESEA.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19535">Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [DisplayName("Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students")]
    public Int32? AmaoProficiencyAttainmentLepStudents { get => amaoProficiencyAttainmentLepStudents; set => SetProperty(ref amaoProficiencyAttainmentLepStudents, value, false); }

    /// <summary>
    /// Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
    /// <para>
    /// An indication whether the state, district, or school met the Annual Measurable Achievement Objective (AMAO) for making progress in learning English for limited English proficient (LEP) students under Title III of ESEA as amended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19545">Annual Measurable Achievement Objective Progress Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [DisplayName("Annual Measurable Achievement Objective Progress Attainment Status for LEP Students")]
    public Int32? AmaoProgressAttainmentLepStudents { get => amaoProgressAttainmentLepStudents; set => SetProperty(ref amaoProgressAttainmentLepStudents, value, false); }

    /// <summary>
    /// Adequate Yearly Progress Appeal Changed Designation
    /// <para>
    /// An indication that the appeal resulted in a change in a school or district's AYP designation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19433">Adequate Yearly Progress Appeal Changed Designation</a>
    /// </para>
    /// </summary>
    [DisplayName("Adequate Yearly Progress Appeal Changed Designation")]
    public Boolean? AypAppealChangedDesignation { get => aypAppealChangedDesignation; set => SetProperty(ref aypAppealChangedDesignation, value, false); }

    /// <summary>
    /// Adequate Yearly Progress Appeal Process Date
    /// <para>
    /// The last date that an appeal of an AYP designation was processed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19434">Adequate Yearly Progress Appeal Process Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Adequate Yearly Progress Appeal Process Date")]
    public DateTime? AypAppealProcessDate { get => aypAppealProcessDate; set => SetProperty(ref aypAppealProcessDate, value, false); }

    /// <summary>
    /// Appealed Adequate Yearly Progress Designation
    /// <para>
    /// An indication that a school or district appealed its AYP designation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19432">Appealed Adequate Yearly Progress Designation</a>
    /// </para>
    /// </summary>
    [DisplayName("Appealed Adequate Yearly Progress Designation")]
    public Boolean? AypAppealProcessDesignation { get => aypAppealProcessDesignation; set => SetProperty(ref aypAppealProcessDesignation, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Persistently Dangerous Status
    /// <para>
    /// An indication of whether the school is identified as persistently dangerous in accordance with state definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19210">Persistently Dangerous Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Persistently Dangerous Status")]
    public Boolean? PersistentlyDangerousStatus { get => persistentlyDangerousStatus; set => SetProperty(ref persistentlyDangerousStatus, value, false); }

    /// <summary>
    /// Additional Targeted Support and Improvement Status
    /// <para>
    /// The designation given to a school by the state for additional targeted support and improvement as part of its statewide system of annual meaningful differentiation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20902">Additional Targeted Support and Improvement Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Additional Targeted Support and Improvement Status")]
    public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

    /// <summary>
    /// Adequate Yearly Progress Status
    /// <para>
    /// An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19011">Adequate Yearly Progress Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Adequate Yearly Progress Status")]
    public Guid? RefAypStatusId { get; set; }

    /// <summary>
    /// Comprehensive Support and Improvement Status
    /// <para>
    /// The designation given to a school by the state for comprehensive support and improvement as part of its statewide system of annual meaningful differentiation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20904">Comprehensive Support and Improvement Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Comprehensive Support and Improvement Status")]
    public Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

    /// <summary>
    /// Career and Technical Education Graduation Rate Inclusion
    /// <para>
    /// An indication of how CTE concentrators are included in the state's computation of its graduation rate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19075">Career and Technical Education Graduation Rate Inclusion</a>
    /// </para>
    /// </summary>
    [DisplayName("Career and Technical Education Graduation Rate Inclusion")]
    public Guid? RefCteGraduationRateInclusionId { get; set; }

    /// <summary>
    /// Elementary-Middle Additional Indicator Status
    /// <para>
    ///  An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19091">Elementary-Middle Additional Indicator Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Elementary-Middle Additional Indicator Status")]
    public Guid? RefElementaryMiddleAdditionalId { get; set; }

    /// <summary>
    /// Gun Free Schools Act Reporting Status
    /// <para>
    /// An indication of whether the school or local education agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19134">Gun Free Schools Act Reporting Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Gun Free Schools Act Reporting Status")]
    public Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

    /// <summary>
    /// High School Graduation Rate Indicator Status
    /// <para>
    /// An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19140">High School Graduation Rate Indicator Status</a>
    /// </para>
    /// </summary>
    [DisplayName("High School Graduation Rate Indicator Status")]
    public Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

    /// <summary>
    /// Participation Status for Math
    /// <para>
    /// An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19208">Participation Status for Math</a>
    /// </para>
    /// </summary>
    [DisplayName("Participation Status for Math")]
    public Guid? RefParticipationStatusMathId { get; set; }

    /// <summary>
    /// Participation Status for Reading and Language Arts
    /// <para>
    /// An indication of whether the school or district met the 95 percent participation requirement on the reading/language arts assessment in accordance with state definition for the purposes of determining AYP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19209">Participation Status for Reading and Language Arts</a>
    /// </para>
    /// </summary>
    [DisplayName("Participation Status for Reading and Language Arts")]
    public Guid? RefParticipationStatusRlaId { get; set; }

    /// <summary>
    /// Proficiency Target Status for Math
    /// <para>
    /// An indication of whether the school or district met the math proficiency target in accordance with state definition for the purposes of determining AYP.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19221">Proficiency Target Status for Math</a>
    /// </para>
    /// </summary>
    [DisplayName("Proficiency Target Status for Math")]
    public Guid? RefProficiencyTargetStatusMathId { get; set; }

    public Int32? RefProficiencyTargetStatusRlaid { get => refProficiencyTargetStatusRlaid; set => SetProperty(ref refProficiencyTargetStatusRlaid, value, false); }

    /// <summary>
    /// Reconstituted Status
    /// <para>
    /// An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19230">Reconstituted Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Reconstituted Status")]
    public Guid? RefReconstitutedStatusId { get; set; }

    /// <summary>
    /// Targeted Support and Improvement Status
    /// <para>
    /// The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20910">Targeted Support and Improvement Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Targeted Support and Improvement Status")]
    public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationFederalAccountability model)
    {
        IsBusy = true;
        Id = model.Id;
        AccountabilityReportTitle = model.AccountabilityReportTitle; // Accountability Report Title
        AlternateAypApproachIndicator = model.AlternateAypApproachIndicator; // Alternate Adequate Yearly Progress Approach Indicator
        AmaoAypProgressAttainmentLepStudents = model.AmaoAypProgressAttainmentLepStudents; // Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
        AmaoProficiencyAttainmentLepStudents = model.AmaoProficiencyAttainmentLepStudents; // Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
        AmaoProgressAttainmentLepStudents = model.AmaoProgressAttainmentLepStudents; // Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
        AypAppealChangedDesignation = model.AypAppealChangedDesignation; // Adequate Yearly Progress Appeal Changed Designation
        AypAppealProcessDate = model.AypAppealProcessDate; // Adequate Yearly Progress Appeal Process Date
        AypAppealProcessDesignation = model.AypAppealProcessDesignation; // Appealed Adequate Yearly Progress Designation
        OrganizationId = model.OrganizationId; // 
        PersistentlyDangerousStatus = model.PersistentlyDangerousStatus; // Persistently Dangerous Status
        RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId; // Additional Targeted Support and Improvement Status
        RefAypStatusId = model.RefAypStatusId; // Adequate Yearly Progress Status
        RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId; // Comprehensive Support and Improvement Status
        RefCteGraduationRateInclusionId = model.RefCteGraduationRateInclusionId; // Career and Technical Education Graduation Rate Inclusion
        RefElementaryMiddleAdditionalId = model.RefElementaryMiddleAdditionalId; // Elementary-Middle Additional Indicator Status
        RefGunFreeSchoolsActReportingStatusId = model.RefGunFreeSchoolsActReportingStatusId; // Gun Free Schools Act Reporting Status
        RefHighSchoolGraduationRateIndicatorId = model.RefHighSchoolGraduationRateIndicatorId; // High School Graduation Rate Indicator Status
        RefParticipationStatusMathId = model.RefParticipationStatusMathId; // Participation Status for Math
        RefParticipationStatusRlaId = model.RefParticipationStatusRlaId; // Participation Status for Reading and Language Arts
        RefProficiencyTargetStatusMathId = model.RefProficiencyTargetStatusMathId; // Proficiency Target Status for Math
        RefProficiencyTargetStatusRlaid = model.RefProficiencyTargetStatusRlaid; // 
        RefReconstitutedStatusId = model.RefReconstitutedStatusId; // Reconstituted Status
        RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId; // Targeted Support and Improvement Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
