//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicHonorEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicHonor file
/// </summary>
[Table("K12studentAcademicHonor", Schema = "K12")]
public partial class K12studentAcademicHonorEntity : EntityBase, IK12studentAcademicHonor
{
    #region "IK12studentAcademicHonor Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String HonorDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
    /// </summary>
    [ForeignKey("RefAcademicHonorType")]
    public Guid? RefAcademicHonorTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAcademicHonorType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefAcademicHonorTypeEntity? RefAcademicHonorTypeEntity { get; set; }

    #endregion
}
