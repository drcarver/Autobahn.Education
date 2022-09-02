//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCorrectiveActionTypeEntity.g.cs
//* Name:       Corrective Action Type
//* Definition: The types of corrective actions under ESEA as amended.
//***************************************************************************

/// <summary>
/// Corrective Action Type <see cref="RefCorrectiveActionType"/>
/// <para>
/// The types of corrective actions under ESEA as amended.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19049">Corrective Action Type</a>
/// </para>
/// </summary>
[Table("RefCorrectiveActionType", Schema = "Common")]
[Comment("The types of corrective actions under ESEA as amended.")]
public partial class RefCorrectiveActionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefCorrectiveActionType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectiveAction"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefCorrectiveAction property is obsolete and will be removed in a later version")]
    [ForeignKey("RefCorrectiveAction")]
    public Guid RefCorrectiveActionId { get; set; }

    #endregion
}
