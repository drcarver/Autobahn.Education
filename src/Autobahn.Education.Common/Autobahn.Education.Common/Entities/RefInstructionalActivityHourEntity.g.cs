//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefInstructionalActivityHourEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefInstructionalActivityHour file
/// </summary>
[Table("RefInstructionalActivityHour", Schema = "Common")]
public partial class RefInstructionalActivityHourEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefInstructionalActivityHour Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefInstructionalActivityHours"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefInstructionalActivityHours property is obsolete and will be removed in a later version")]
    [ForeignKey("RefInstructionalActivityHours")]
    public Guid RefInstructionalActivityHoursId { get; set; }

    #endregion
}
