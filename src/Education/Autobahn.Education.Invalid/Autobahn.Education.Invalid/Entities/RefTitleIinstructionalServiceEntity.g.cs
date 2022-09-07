//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTitleIinstructionalServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefTitleIinstructionalService file
/// </summary>
[Table("RefTitleIinstructionalService", Schema = "Invalid")]
public partial class RefTitleIinstructionalServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefTitleIinstructionalService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefTitleIinstructionalServices")]
    public Guid RefTitleIinstructionalServicesId { get; set; }

    #endregion
}
