//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentResultPerformanceLevel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultPerformanceLevel file
/// </summary>
public partial interface IAssessmentResultPerformanceLevel
{
    #region "IAssessmentResultPerformanceLevel Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
    /// </summary>
    Guid AssessmentPerformanceLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    Guid AssessmentResultId { get; set; }

    #endregion
}
