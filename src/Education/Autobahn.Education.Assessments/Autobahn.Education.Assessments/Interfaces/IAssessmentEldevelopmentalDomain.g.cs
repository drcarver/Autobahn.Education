//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentEldevelopmentalDomain.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentEldevelopmentalDomain file
/// </summary>
public partial interface IAssessmentEldevelopmentalDomain
{
    #region "IAssessmentEldevelopmentalDomain Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
