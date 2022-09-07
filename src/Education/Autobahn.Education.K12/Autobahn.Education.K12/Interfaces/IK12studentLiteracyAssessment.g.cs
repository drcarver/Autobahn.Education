//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentLiteracyAssessment.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentLiteracyAssessment file
/// </summary>
public partial interface IK12studentLiteracyAssessment
{
    #region "IK12studentLiteracyAssessment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? LiteracyGoalMetStatus { get; set; }

    Boolean? LiteracyPostTestStatus { get; set; }

    Boolean? LiteracyPreTestStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
    /// </summary>
    Guid? RefLiteracyAssessmentId { get; set; }

    #endregion
}
