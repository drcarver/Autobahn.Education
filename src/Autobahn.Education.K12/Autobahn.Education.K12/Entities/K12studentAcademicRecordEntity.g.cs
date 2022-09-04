//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicRecordEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicRecord file
/// </summary>
[Table("K12studentAcademicRecord", Schema = "K12")]
public partial class K12studentAcademicRecordEntity : EntityBase, IK12studentAcademicRecord
{
    #region "IK12studentAcademicRecord Properties"
    public DateTime? ClassRankingDate { get; set; }

    public Decimal? CreditsAttemptedCumulative { get; set; }

    public Decimal? CreditsEarnedCumulative { get; set; }

    public DateTime? DiplomaOrCredentialAwardDate { get; set; }

    public Decimal? GradePointAverageCumulative { get; set; }

    public Decimal? GradePointsEarnedCumulative { get; set; }

    public Int32? HighSchoolStudentClassRank { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    public DateTime? ProjectedGraduationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
    /// </summary>
    [ForeignKey("RefGpaWeightedIndicator")]
    public Guid? RefGpaWeightedIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
    /// </summary>
    [ForeignKey("RefHighSchoolDiplomaDistinctionType")]
    public Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
    /// </summary>
    [ForeignKey("RefHighSchoolDiplomaType")]
    public Guid? RefHighSchoolDiplomaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    [ForeignKey("RefPreAndPostTestIndicator")]
    public Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
    /// </summary>
    [ForeignKey("RefProfessionalTechnicalCredentialType")]
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    [ForeignKey("RefProgressLevel")]
    public Guid? RefProgressLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
    /// </summary>
    [ForeignKey("RefPsEnrollmentAction")]
    public Guid? RefPsEnrollmentActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
    /// </summary>
    [ForeignKey("RefTechnologyLiteracyStatus")]
    public Guid? RefTechnologyLiteracyStatusId { get; set; }

    public Int32? TotalNumberInClass { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefGpaWeightedIndicator"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefGpaWeightedIndicatorEntity? RefGpaWeightedIndicatorEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefHighSchoolDiplomaType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefHighSchoolDiplomaTypeEntity? RefHighSchoolDiplomaTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefHighSchoolDiplomaDistinctionType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefHighSchoolDiplomaDistinctionTypeEntity? RefHighSchoolDiplomaDistinctionTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTechnologyLiteracyStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefTechnologyLiteracyStatusEntity? RefTechnologyLiteracyStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPsEnrollmentAction"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefPsEnrollmentActionEntity? RefPsEnrollmentActionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPreAndPostTestIndicator"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefPreAndPostTestIndicatorEntity? RefPreAndPostTestIndicatorEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProfessionalTechnicalCredentialType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefProfessionalTechnicalCredentialTypeEntity? RefProfessionalTechnicalCredentialTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProgressLevel"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefProgressLevelEntity? RefProgressLevelEntity { get; set; }

    #endregion
}
