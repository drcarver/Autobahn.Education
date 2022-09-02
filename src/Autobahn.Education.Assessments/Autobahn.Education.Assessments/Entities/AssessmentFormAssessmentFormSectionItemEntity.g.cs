//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSectionItem file
/// </summary>
[Table("AssessmentFormAssessmentFormSectionItem", Schema = "Assessments")]
public partial class AssessmentFormAssessmentFormSectionItemEntity : EntityBase, IAssessmentFormAssessmentFormSectionItem
{
    #region "IAssessmentFormAssessmentFormSectionItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormAssessmentFormSection")]
    public Guid AssessmentFormAssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentForm")]
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormSection")]
    public Guid AssessmentFormSectionId { get; set; }

    public Int32? SequenceNumber { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormAssessmentFormSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormAssessmentFormSectionEntity AssessmentFormAssessmentFormSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormEntity AssessmentFormEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormSectionEntity AssessmentFormSectionEntity { get; set; }

    #endregion
}
