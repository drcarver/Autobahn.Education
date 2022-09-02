//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSubtestEldevelopmentalDomain.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestEldevelopmentalDomain file
/// </summary>
public partial interface IAssessmentSubtestEldevelopmentalDomain
{
    #region "IAssessmentSubtestEldevelopmentalDomain Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
