//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeOffered file
/// </summary>
[Table("K12schoolGradeOffered", Schema = "K12")]
public partial class K12schoolGradeOfferedEntity : EntityBase, IK12schoolGradeOffered
{
    #region "IK12schoolGradeOffered Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefGradeLevel")]
    public Guid RefGradeLevelId { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefGradeLevel"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefGradeLevelEntity RefGradeLevelEntity { get; set; }

    #endregion
}
