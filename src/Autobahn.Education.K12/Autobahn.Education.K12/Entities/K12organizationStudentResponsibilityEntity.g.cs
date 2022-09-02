//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12organizationStudentResponsibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12organizationStudentResponsibility file
/// </summary>
[Table("K12organizationStudentResponsibility", Schema = "K12")]
public partial class K12organizationStudentResponsibilityEntity : EntityBase, IK12organizationStudentResponsibility
{
    #region "IK12organizationStudentResponsibility Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12responsibilityType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefK12responsibilityType")]
    public Guid RefK12responsibilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
    /// </summary>
    [ForeignKey("RefStudentSchoolAffiliationStateDefinedStatus")]
    public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefK12responsibilityType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefK12responsibilityTypeEntity RefK12responsibilityTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefStudentSchoolAffiliationStateDefinedStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefStudentSchoolAffiliationStateDefinedStatusEntity RefStudentSchoolAffiliationStateDefinedStatusEntity { get; set; }

    #endregion
}
