//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEntryTypeEntity.g.cs
//* Name:       Entry Type
//* Definition: The process by which a student enters a school during a given academic session.
//***************************************************************************

/// <summary>
/// Entry Type <see cref="RefEntryType"/>
/// <para>
/// The process by which a student enters a school during a given academic session.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19099">Entry Type</a>
/// </para>
/// </summary>
[Table("RefEntryType", Schema = "Common")]
[Comment("The process by which a student enters a school during a given academic session.")]
public partial class RefEntryTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
