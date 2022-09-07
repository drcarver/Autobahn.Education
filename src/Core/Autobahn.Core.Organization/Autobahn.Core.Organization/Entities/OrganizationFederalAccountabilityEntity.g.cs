//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationFederalAccountabilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFederalAccountability file
/// </summary>
[Table("OrganizationFederalAccountability", Schema = "Organization")]
public partial class OrganizationFederalAccountabilityEntity : EntityBase, IOrganizationFederalAccountability
{
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title of the accountability report.")]
    public System.String AccountabilityReportTitle { get; set; }

    /// <summary>
    /// Alternate Adequate Yearly Progress Approach Indicator
    /// <para>
    /// An indication of whether the district or school used an approved alternate approach for calculating Adequate Yearly Progress (AYP).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19014">Alternate Adequate Yearly Progress Approach Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication of whether the district or school used an approved alternate approach for calculating Adequate Yearly Progress (AYP).")]
    public Boolean? AlternateAypApproachIndicator { get; set; }

    /// <summary>
    /// Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students
    /// <para>
    /// An indication of whether the state or district met the annual measurable objectives for the Limited English Proficient (LEP) student subgroup in mathematics and reading/language arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19572">Annual Measurable Achievement Objective AYP Progress Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [Comment("An indication of whether the state or district met the annual measurable objectives for the Limited English Proficient (LEP) student subgroup in mathematics and reading/language arts.")]
    public Int32? AmaoAypProgressAttainmentLepStudents { get; set; }

    /// <summary>
    /// Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students
    /// <para>
    /// An indication whether the state, district or school met the Annual Measurable Achievement Objectives (AMAO) for attaining English proficiency for limited English proficient (LEP) students under Title III of ESEA.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19535">Annual Measurable Achievement Objective Proficiency Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [Comment("An indication whether the state, district or school met the Annual Measurable Achievement Objectives (AMAO) for attaining English proficiency for limited English proficient (LEP) students under Title III of ESEA.")]
    public Int32? AmaoProficiencyAttainmentLepStudents { get; set; }

    /// <summary>
    /// Annual Measurable Achievement Objective Progress Attainment Status for LEP Students
    /// <para>
    /// An indication whether the state, district, or school met the Annual Measurable Achievement Objective (AMAO) for making progress in learning English for limited English proficient (LEP) students under Title III of ESEA as amended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19545">Annual Measurable Achievement Objective Progress Attainment Status for LEP Students</a>
    /// </para>
    /// </summary>
    [Comment("An indication whether the state, district, or school met the Annual Measurable Achievement Objective (AMAO) for making progress in learning English for limited English proficient (LEP) students under Title III of ESEA as amended.")]
    public Int32? AmaoProgressAttainmentLepStudents { get; set; }

    /// <summary>
    /// Adequate Yearly Progress Appeal Changed Designation
    /// <para>
    /// An indication that the appeal resulted in a change in a school or district's AYP designation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19433">Adequate Yearly Progress Appeal Changed Designation</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the appeal resulted in a change in a school or district's AYP designation.")]
    public Boolean? AypAppealChangedDesignation { get; set; }

    /// <summary>
    /// Adequate Yearly Progress Appeal Process Date
    /// <para>
    /// The last date that an appeal of an AYP designation was processed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19434">Adequate Yearly Progress Appeal Process Date</a>
    /// </para>
    /// </summary>
    [Comment("The last date that an appeal of an AYP designation was processed.")]
    public DateTime? AypAppealProcessDate { get; set; }

    /// <summary>
    /// Appealed Adequate Yearly Progress Designation
    /// <para>
    /// An indication that a school or district appealed its AYP designation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19432">Appealed Adequate Yearly Progress Designation</a>
    /// </para>
    /// </summary>
    [Comment("An indication that a school or district appealed its AYP designation.")]
    public Boolean? AypAppealProcessDesignation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
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
    [Comment("An indication of whether the school is identified as persistently dangerous in accordance with state definition.")]
    public Boolean? PersistentlyDangerousStatus { get; set; }

    /// <summary>
    /// Additional Targeted Support and Improvement Status
    /// <para>
    /// The designation given to a school by the state for additional targeted support and improvement as part of its statewide system of annual meaningful differentiation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20902">Additional Targeted Support and Improvement Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAdditionalTargetedSupportAndImprovementStatus")]
    [Comment("The designation given to a school by the state for additional targeted support and improvement as part of its statewide system of annual meaningful differentiation.")]
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
    [ForeignKey("RefAypStatus")]
    [Comment("An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.")]
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
    [ForeignKey("RefComprehensiveSupportAndImprovementStatus")]
    [Comment("The designation given to a school by the state for comprehensive support and improvement as part of its statewide system of annual meaningful differentiation.")]
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
    [ForeignKey("RefCteGraduationRateInclusion")]
    [Comment("An indication of how CTE concentrators are included in the state's computation of its graduation rate.")]
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
    [ForeignKey("RefElementaryMiddleAdditional")]
    [Comment(" An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).")]
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
    [ForeignKey("RefGunFreeSchoolsActReportingStatus")]
    [Comment("An indication of whether the school or local education agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.")]
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
    [ForeignKey("RefHighSchoolGraduationRateIndicator")]
    [Comment("An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.")]
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
    [ForeignKey("RefParticipationStatusMath")]
    [Comment("An indication of whether the school or district met the 95 percent participation requirement in the mathematics assessment in accordance with state definition for the purposes of determining AYP.")]
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
    [ForeignKey("RefParticipationStatusRla")]
    [Comment("An indication of whether the school or district met the 95 percent participation requirement on the reading/language arts assessment in accordance with state definition for the purposes of determining AYP.")]
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
    [ForeignKey("RefProficiencyTargetStatusMath")]
    [Comment("An indication of whether the school or district met the math proficiency target in accordance with state definition for the purposes of determining AYP.")]
    public Guid? RefProficiencyTargetStatusMathId { get; set; }

    public Int32? RefProficiencyTargetStatusRlaid { get; set; }

    /// <summary>
    /// Reconstituted Status
    /// <para>
    /// An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19230">Reconstituted Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefReconstitutedStatus")]
    [Comment("An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).")]
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
    [ForeignKey("RefTargetedSupportAndImprovementStatus")]
    [Comment("The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.")]
    public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19011">Adequate Yearly Progress Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefAypStatusEntity? RefAypStatusEntity { get; set; }

    /// <summary>
    /// An indication of whether the school or local education agency (LEA) submitted a Gun-Free Schools Act (GFSA) of 1994 report to the state, as defined by Title 18, Section 921.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19134">Gun Free Schools Act Reporting Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefGunFreeSchoolsActReportingStatusEntity? RefGunFreeSchoolsActReportingStatusEntity { get; set; }

    /// <summary>
    /// An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19140">High School Graduation Rate Indicator Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefHighSchoolGraduationRateIndicatorEntity? RefHighSchoolGraduationRateIndicatorEntity { get; set; }

    /// <summary>
    /// An indication that the school was restructured, transformed or otherwise changed as a consequence of the state's accountability system under ESEA or as a result of School Improvement Grants (SIG).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19230">Reconstituted Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefReconstitutedStatusEntity? RefReconstitutedStatusEntity { get; set; }

    /// <summary>
    ///  An indication of whether the school or district met the Elementary/Middle Additional Indicator requirement in accordance with state definition for the purpose of determining Adequate Yearly Progress (AYP).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19091">Elementary-Middle Additional Indicator Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefElementaryMiddleAdditionalEntity? RefElementaryMiddleAdditionalEntity { get; set; }

    /// <summary>
    /// An indication of how CTE concentrators are included in the state's computation of its graduation rate.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19075">Career and Technical Education Graduation Rate Inclusion</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefCteGraduationRateInclusionEntity? RefCteGraduationRateInclusionEntity { get; set; }

    /// <summary>
    /// The designation given to a school by the state for additional targeted support and improvement as part of its statewide system of annual meaningful differentiation.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20902">Additional Targeted Support and Improvement Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefAdditionalTargetedSupportAndImprovementStatusEntity? RefAdditionalTargetedSupportAndImprovementStatusEntity { get; set; }

    /// <summary>
    /// The designation given to a school by the state for comprehensive support and improvement as part of its statewide system of annual meaningful differentiation.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20904">Comprehensive Support and Improvement Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefComprehensiveSupportAndImprovementStatusEntity? RefComprehensiveSupportAndImprovementStatusEntity { get; set; }

    /// <summary>
    /// The designation given to a school by the state for targeted support and improvement as part of its statewide system of annual meaningful differentiation.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20910">Targeted Support and Improvement Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefTargetedSupportAndImprovementStatusEntity? RefTargetedSupportAndImprovementStatusEntity { get; set; }

    #endregion
}
