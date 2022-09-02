//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolImprovementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolImprovement file
/// </summary>
[Table("K12schoolImprovement", Schema = "K12")]
public partial class K12schoolImprovementEntity : EntityBase, IK12schoolImprovement
{
    #region "IK12schoolImprovement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    [Obsolete("The RefSchoolImprovementFunds property is obsolete and will be removed in a later version")]
    [ForeignKey("RefSchoolImprovementFunds")]
    public Guid? RefSchoolImprovementFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    [ForeignKey("RefSchoolImprovementStatus")]
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
    /// </summary>
    [ForeignKey("RefSigInterventionType")]
    public Guid? RefSigInterventionTypeId { get; set; }

    public DateTime? SchoolImprovementExitDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12schoolEntity K12schoolEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSchoolImprovementStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefSchoolImprovementStatusEntity RefSchoolImprovementStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSigInterventionType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefSigInterventionTypeEntity RefSigInterventionTypeEntity { get; set; }

    #endregion
}
