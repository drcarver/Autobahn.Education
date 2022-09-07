//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLevelsForWhichDesigned file
/// </summary>
public partial class AssessmentLevelsForWhichDesignedModel : AutobahnBaseModel, IAssessmentLevelsForWhichDesigned
{
    #region "IAssessmentLevelsForWhichDesigned Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    public Guid RefGradeLevelId { get; set; }

    #endregion
}
