//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolIndicatorStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolIndicatorStatus file
/// </summary>
[Table("K12schoolIndicatorStatus", Schema = "K12")]
public partial class K12schoolIndicatorStatusEntity : EntityBase, IK12schoolIndicatorStatus
{
    #region "IK12schoolIndicatorStatus Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorStatus { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorStatusSubgroup { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
    /// </summary>
    [ForeignKey("RefIndicatorStateDefinedStatus")]
    public Guid? RefIndicatorStateDefinedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
    /// </summary>
    [ForeignKey("RefIndicatorStatusCustomType")]
    public Guid? RefIndicatorStatusCustomTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
    /// </summary>
    [ForeignKey("RefIndicatorStatusSubgroupType")]
    public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefIndicatorStatusType")]
    public Guid RefIndicatorStatusTypeId { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefIndicatorStatusType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefIndicatorStatusTypeEntity RefIndicatorStatusTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIndicatorStateDefinedStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefIndicatorStateDefinedStatusEntity? RefIndicatorStateDefinedStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIndicatorStatusSubgroupType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefIndicatorStatusSubgroupTypeEntity? RefIndicatorStatusSubgroupTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIndicatorStatusCustomType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefIndicatorStatusCustomTypeEntity? RefIndicatorStatusCustomTypeEntity { get; set; }

    #endregion
}
