//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentAssessmentAdministration.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAssessmentAdministration file
/// </summary>
public partial interface IAssessmentAssessmentAdministration
{
    #region "IAssessmentAssessmentAdministration Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid AssessmentId { get; set; }

    #endregion
}
