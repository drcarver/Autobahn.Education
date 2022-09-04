//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestEldevelopmentalDomainEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestEldevelopmentalDomain file
/// </summary>
[Table("AssessmentSubtestEldevelopmentalDomain", Schema = "Assessments")]
public partial class AssessmentSubtestEldevelopmentalDomainEntity : EntityBase, IAssessmentSubtestEldevelopmentalDomain
{
    #region "IAssessmentSubtestEldevelopmentalDomain Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubTest")]
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentEldevelopmentalDomain")]
    public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSubTestEntity AssessmentSubTestEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAssessmentEldevelopmentalDomain"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentEldevelopmentalDomainEntity RefAssessmentEldevelopmentalDomainEntity { get; set; }

    #endregion
}
