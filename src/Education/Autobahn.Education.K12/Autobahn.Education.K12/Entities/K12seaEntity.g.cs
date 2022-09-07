//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12sea file
/// </summary>
[Table("K12sea", Schema = "K12")]
public partial class K12seaEntity : EntityBase, IK12sea
{
    #region "IK12sea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStateAnsicode"/> model
    /// </summary>
    [ForeignKey("RefStateAnsicode")]
    public Guid? RefStateAnsicodeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefStateAnsicode"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefStateAnsicodeEntity? RefStateAnsicodeEntity { get; set; }

    #endregion
}
