//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   RefK12leaTitleIsupportServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefK12leaTitleIsupportService file
/// </summary>
[Table("RefK12leaTitleIsupportService", Schema = "K12")]
public partial class RefK12leaTitleIsupportServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefK12leaTitleIsupportService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12leatitleIsupportService"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefK12leatitleIsupportService")]
    public Guid RefK12leatitleIsupportServiceId { get; set; }

    #endregion
}
