//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefContinuationOfServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefContinuationOfService file
/// </summary>
[Table("RefContinuationOfService", Schema = "Common")]
public partial class RefContinuationOfServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefContinuationOfService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefContinuationOfServicesReason property is obsolete and will be removed in a later version")]
    [ForeignKey("RefContinuationOfServicesReason")]
    public Guid RefContinuationOfServicesReasonId { get; set; }

    #endregion
}
