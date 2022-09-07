//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCohortEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCohort file
/// </summary>
public partial class K12studentCohortModel : AutobahnBaseModel, IK12studentCohort
{
    #region "IK12studentCohort Properties"
    public System.String CohortDescription { get; set; }

    public System.String CohortGraduationYear { get; set; }

    public System.String CohortYear { get; set; }

    public System.String GraduationRateSurveyCohortYear { get; set; }

    public Boolean? GraduationRateSurveyIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
