//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolAuthorizerAgencyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolAuthorizerAgency file
/// </summary>
[Table("K12charterSchoolAuthorizerAgency", Schema = "K12")]
public partial class K12charterSchoolAuthorizerAgencyEntity : EntityBase, IK12charterSchoolAuthorizerAgency
{
    #region "IK12charterSchoolAuthorizerAgency Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefCharterSchoolAuthorizerType")]
    public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCharterSchoolAuthorizerType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCharterSchoolAuthorizerTypeEntity RefCharterSchoolAuthorizerTypeEntity { get; set; }

    #endregion
}
