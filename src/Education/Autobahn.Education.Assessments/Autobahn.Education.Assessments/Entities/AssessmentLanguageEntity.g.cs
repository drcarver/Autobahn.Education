//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLanguage file
/// </summary>
[Table("AssessmentLanguage", Schema = "Assessments")]
public partial class AssessmentLanguageEntity : EntityBase, IAssessmentLanguage
{
    #region "IAssessmentLanguage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLanguage"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLanguage")]
    public Guid RefLanguageId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    #endregion
}
