//***************************************************************************
//* DomainName: Assessments
//* FileName:   PersonAssessmentPersonalNeedsProfileEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAssessmentPersonalNeedsProfile file
/// </summary>
[Table("PersonAssessmentPersonalNeedsProfile", Schema = "Assessments")]
public partial class PersonAssessmentPersonalNeedsProfileEntity : EntityBase, IPersonAssessmentPersonalNeedsProfile
{
    #region "IPersonAssessmentPersonalNeedsProfile Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfile")]
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPersonalNeedsProfileEntity AssessmentPersonalNeedsProfileEntity { get; set; }

    #endregion
}
