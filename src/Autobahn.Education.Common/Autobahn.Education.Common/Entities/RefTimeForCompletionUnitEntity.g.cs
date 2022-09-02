//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTimeForCompletionUnitEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefTimeForCompletionUnit file
/// </summary>
[Table("RefTimeForCompletionUnit", Schema = "Common")]
public partial class RefTimeForCompletionUnitEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefTimeForCompletionUnit Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefTimeForCompletionUnits property is obsolete and will be removed in a later version")]
    [ForeignKey("RefTimeForCompletionUnits")]
    public Guid RefTimeForCompletionUnitsId { get; set; }

    #endregion
}
