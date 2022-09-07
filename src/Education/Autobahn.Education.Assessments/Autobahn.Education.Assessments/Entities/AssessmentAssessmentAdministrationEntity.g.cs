//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAssessmentAdministration file
/// </summary>
[Table("AssessmentAssessmentAdministration", Schema = "Assessments")]
public partial class AssessmentAssessmentAdministrationEntity : EntityBase, IAssessmentAssessmentAdministration
{
    #region "IAssessmentAssessmentAdministration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAdministration")]
    public Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAdministrationEntity AssessmentAdministrationEntity { get; set; }

    #endregion
}
