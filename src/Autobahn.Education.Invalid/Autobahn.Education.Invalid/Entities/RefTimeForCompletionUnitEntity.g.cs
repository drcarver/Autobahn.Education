//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTimeForCompletionUnitEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefTimeForCompletionUnit file
/// </summary>
[Table("RefTimeForCompletionUnit", Schema = "Invalid")]
public partial class RefTimeForCompletionUnitEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefTimeForCompletionUnit Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefTimeForCompletionUnits")]
    public Guid RefTimeForCompletionUnitsId { get; set; }

    #endregion
}
