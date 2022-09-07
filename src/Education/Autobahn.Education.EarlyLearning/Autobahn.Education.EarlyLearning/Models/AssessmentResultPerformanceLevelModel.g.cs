//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   AssessmentResultPerformanceLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultPerformanceLevel file
/// </summary>
public partial class AssessmentResultPerformanceLevelModel : AutobahnBaseModel, IAssessmentResultPerformanceLevel
{
    #region "IAssessmentResultPerformanceLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
    /// </summary>
    public Guid AssessmentPerformanceLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    public Guid AssessmentResultId { get; set; }

    #endregion
}
