//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentLiteracyAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentLiteracyAssessment file
/// </summary>
public partial class K12studentLiteracyAssessmentModel : AutobahnBaseModel, IK12studentLiteracyAssessment
{
    #region "IK12studentLiteracyAssessment Properties"
    public Boolean? LiteracyGoalMetStatus { get; set; }

    public Boolean? LiteracyPostTestStatus { get; set; }

    public Boolean? LiteracyPreTestStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
    /// </summary>
    public Guid? RefLiteracyAssessmentId { get; set; }

    #endregion
}
