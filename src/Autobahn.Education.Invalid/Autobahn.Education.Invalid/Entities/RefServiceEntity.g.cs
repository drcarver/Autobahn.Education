//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefService file
/// </summary>
[Table("RefService", Schema = "Invalid")]
public partial class RefServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServices"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefServices")]
    public Guid RefServicesId { get; set; }

    #endregion
}
