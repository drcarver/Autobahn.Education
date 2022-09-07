//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefEarlyChildhoodServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefEarlyChildhoodService file
/// </summary>
[Table("RefEarlyChildhoodService", Schema = "EarlyLearning")]
public partial class RefEarlyChildhoodServiceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefEarlyChildhoodService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServices"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEarlyChildhoodServices")]
    public Guid RefEarlyChildhoodServicesId { get; set; }

    #endregion
}
