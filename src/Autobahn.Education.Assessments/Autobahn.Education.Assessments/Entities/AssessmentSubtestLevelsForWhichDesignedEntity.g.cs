//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestLevelsForWhichDesignedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestLevelsForWhichDesigned file
/// </summary>
[Table("AssessmentSubtestLevelsForWhichDesigned", Schema = "Assessments")]
public partial class AssessmentSubtestLevelsForWhichDesignedEntity : EntityBase, IAssessmentSubtestLevelsForWhichDesigned
{
    #region "IAssessmentSubtestLevelsForWhichDesigned Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The AssessmentSubTest property is obsolete and will be removed in a later version")]
    [ForeignKey("AssessmentSubTest")]
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGrade"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefGrade property is obsolete and will be removed in a later version")]
    [ForeignKey("RefGrade")]
    public Guid RefGradeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
