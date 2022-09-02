//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentItem file
/// </summary>
[Table("AssessmentFormSectionAssessmentItem", Schema = "Assessments")]
public partial class AssessmentFormSectionAssessmentItemEntity : EntityBase, IAssessmentFormSectionAssessmentItem
{
    #region "IAssessmentFormSectionAssessmentItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormSection")]
    public Guid AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The AssessmentFormSectionItem property is obsolete and will be removed in a later version")]
    [ForeignKey("AssessmentFormSectionItem")]
    public Guid AssessmentFormSectionItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItem")]
    public Guid AssessmentItemId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 SequenceNumber { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormSectionEntity AssessmentFormSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemEntity AssessmentItemEntity { get; set; }

    #endregion
}
