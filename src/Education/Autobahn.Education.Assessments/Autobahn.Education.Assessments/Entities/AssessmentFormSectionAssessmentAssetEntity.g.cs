//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentAsset file
/// </summary>
[Table("AssessmentFormSectionAssessmentAsset", Schema = "Assessments")]
public partial class AssessmentFormSectionAssessmentAssetEntity : EntityBase, IAssessmentFormSectionAssessmentAsset
{
    #region "IAssessmentFormSectionAssessmentAsset Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAsset")]
    public Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormSection")]
    public Guid AssessmentFormSectionId { get; set; }

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
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAssetEntity AssessmentAssetEntity { get; set; }

    #endregion
}
