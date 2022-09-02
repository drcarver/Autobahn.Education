//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEmployment file
/// </summary>
[Table("K12studentEmployment", Schema = "K12")]
public partial class K12studentEmploymentEntity : EntityBase, IK12studentEmployment
{
    #region "IK12studentEmployment Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmploymentNaicsCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    [ForeignKey("RefEmployedAfterExit")]
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    [ForeignKey("RefEmployedWhileEnrolled")]
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmployedWhileEnrolled"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedWhileEnrolledEntity RefEmployedWhileEnrolledEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmployedAfterExit"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedAfterExitEntity RefEmployedAfterExitEntity { get; set; }

    #endregion
}
