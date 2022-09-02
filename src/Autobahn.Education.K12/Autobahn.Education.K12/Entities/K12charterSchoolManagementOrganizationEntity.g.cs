//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolManagementOrganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolManagementOrganization file
/// </summary>
[Table("K12charterSchoolManagementOrganization", Schema = "K12")]
public partial class K12charterSchoolManagementOrganizationEntity : EntityBase, IK12charterSchoolManagementOrganization
{
    #region "IK12charterSchoolManagementOrganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
    /// </summary>
    [ForeignKey("RefCharterSchoolManagementOrganizationType")]
    public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCharterSchoolManagementOrganizationType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCharterSchoolManagementOrganizationTypeEntity RefCharterSchoolManagementOrganizationTypeEntity { get; set; }

    #endregion
}
