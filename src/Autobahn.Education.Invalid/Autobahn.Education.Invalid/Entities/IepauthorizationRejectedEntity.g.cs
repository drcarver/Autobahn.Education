//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IepauthorizationRejectedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorizationRejected file
/// </summary>
[Table("IepauthorizationRejected", Schema = "Invalid")]
public partial class IepauthorizationRejectedEntity : EntityBase, IIepauthorizationRejected
{
    #region "IIepauthorizationRejected Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIepauthorization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Iepauthorization")]
    public Guid IepauthorizationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String PortionDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String PortionExplanation { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIepauthorization"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IepauthorizationEntity IepauthorizationEntity { get; set; }

    #endregion
}
