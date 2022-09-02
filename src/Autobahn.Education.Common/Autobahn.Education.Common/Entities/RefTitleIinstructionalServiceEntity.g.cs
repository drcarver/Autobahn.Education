//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTitleIinstructionalServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefTitleIinstructionalService file
/// </summary>
[Table("RefTitleIinstructionalService", Schema = "Common")]
public partial class RefTitleIinstructionalServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefTitleIinstructionalService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefTitleIinstructionalServices property is obsolete and will be removed in a later version")]
    [ForeignKey("RefTitleIinstructionalServices")]
    public Guid RefTitleIinstructionalServicesId { get; set; }

    #endregion
}
