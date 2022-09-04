//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefContinuationOfServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefContinuationOfService file
/// </summary>
[Table("RefContinuationOfService", Schema = "Invalid")]
public partial class RefContinuationOfServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefContinuationOfService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContinuationOfServicesReason"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefContinuationOfServicesReason")]
    public Guid RefContinuationOfServicesReasonId { get; set; }

    #endregion
}
