//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefService file
/// </summary>
[Table("RefService", Schema = "Common")]
public partial class RefServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServices"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefServices property is obsolete and will be removed in a later version")]
    [ForeignKey("RefServices")]
    public Guid RefServicesId { get; set; }

    #endregion
}
