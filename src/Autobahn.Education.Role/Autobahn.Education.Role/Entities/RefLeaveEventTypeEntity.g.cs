//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefLeaveEventTypeEntity.g.cs
//* Name:       Leave Event Type
//* Definition: The type of the leave event.
//***************************************************************************

/// <summary>
/// Leave Event Type <see cref="RefLeaveEventType"/>
/// <para>
/// The type of the leave event.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
/// </para>
/// </summary>
[Table("RefLeaveEventType", Schema = "Role")]
[Comment("The type of the leave event.")]
public partial class RefLeaveEventTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
