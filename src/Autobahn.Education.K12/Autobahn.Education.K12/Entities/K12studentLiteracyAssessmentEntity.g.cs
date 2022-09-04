//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentLiteracyAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentLiteracyAssessment file
/// </summary>
[Table("K12studentLiteracyAssessment", Schema = "K12")]
public partial class K12studentLiteracyAssessmentEntity : EntityBase, IK12studentLiteracyAssessment
{
    #region "IK12studentLiteracyAssessment Properties"
    public Boolean? LiteracyGoalMetStatus { get; set; }

    public Boolean? LiteracyPostTestStatus { get; set; }

    public Boolean? LiteracyPreTestStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
    /// </summary>
    [ForeignKey("RefLiteracyAssessment")]
    public Guid? RefLiteracyAssessmentId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLiteracyAssessment"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefLiteracyAssessmentEntity? RefLiteracyAssessmentEntity { get; set; }

    #endregion
}
