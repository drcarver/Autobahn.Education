//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSubtestLevelsForWhichDesigned.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestLevelsForWhichDesigned file
/// </summary>
public partial interface IAssessmentSubtestLevelsForWhichDesigned
{
    #region "IAssessmentSubtestLevelsForWhichDesigned Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGrade"/> model
    /// </summary>
    Guid RefGradeId { get; set; }

    #endregion
}
