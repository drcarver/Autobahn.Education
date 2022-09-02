//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAssessmentAdministration file
/// </summary>
public partial class AssessmentAssessmentAdministrationModel : AutobahnBaseModel, IAssessmentAssessmentAdministration
{
    #region "IAssessmentAssessmentAdministration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    #endregion
}
