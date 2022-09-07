//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentAcademicRecord.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicRecord file
/// </summary>
public partial interface IK12studentAcademicRecord
{
    #region "IK12studentAcademicRecord Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ClassRankingDate { get; set; }

    Decimal? CreditsAttemptedCumulative { get; set; }

    Decimal? CreditsEarnedCumulative { get; set; }

    DateTime? DiplomaOrCredentialAwardDate { get; set; }

    Decimal? GradePointAverageCumulative { get; set; }

    Decimal? GradePointsEarnedCumulative { get; set; }

    Int32? HighSchoolStudentClassRank { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    DateTime? ProjectedGraduationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
    /// </summary>
    Guid? RefGpaWeightedIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaDistinctionType"/> model
    /// </summary>
    Guid? RefHighSchoolDiplomaDistinctionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
    /// </summary>
    Guid? RefHighSchoolDiplomaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
    /// </summary>
    Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    Guid? RefProgressLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsEnrollmentAction"/> model
    /// </summary>
    Guid? RefPsEnrollmentActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTechnologyLiteracyStatus"/> model
    /// </summary>
    Guid? RefTechnologyLiteracyStatusId { get; set; }

    Int32? TotalNumberInClass { get; set; }

    #endregion
}
