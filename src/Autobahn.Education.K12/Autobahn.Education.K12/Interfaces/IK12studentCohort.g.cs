//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentCohort.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCohort file
/// </summary>
public partial interface IK12studentCohort
{
    #region "IK12studentCohort Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String CohortDescription { get; set; }

    System.String CohortGraduationYear { get; set; }

    System.String CohortYear { get; set; }

    System.String GraduationRateSurveyCohortYear { get; set; }

    Boolean? GraduationRateSurveyIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
