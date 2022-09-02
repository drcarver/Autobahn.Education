//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElorganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganization file
/// </summary>
[Table("Elorganization", Schema = "Common")]
public partial class ElorganizationEntity : EntityBase, IElorganization
{
    #region "IElorganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
    /// </summary>
    [ForeignKey("RefProfitStatus")]
    public Guid? RefProfitStatusId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProfitStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProfitStatusEntity RefProfitStatusEntity { get; set; }

    #endregion
}
