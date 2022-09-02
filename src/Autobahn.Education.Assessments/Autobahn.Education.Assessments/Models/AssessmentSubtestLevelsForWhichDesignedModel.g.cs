//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestLevelsForWhichDesignedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestLevelsForWhichDesigned file
/// </summary>
public partial class AssessmentSubtestLevelsForWhichDesignedModel : AutobahnBaseModel, IAssessmentSubtestLevelsForWhichDesigned
{
    #region "IAssessmentSubtestLevelsForWhichDesigned Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGrade"/> model
    /// </summary>
    public Guid RefGradeId { get; set; }

    #endregion
}
