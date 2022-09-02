//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentLevelsForWhichDesigned.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLevelsForWhichDesigned file
/// </summary>
public partial interface IAssessmentLevelsForWhichDesigned
{
    #region "IAssessmentLevelsForWhichDesigned Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    Guid RefGradeLevelId { get; set; }

    #endregion
}
