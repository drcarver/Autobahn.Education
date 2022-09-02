//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOtherNameTypeEntity.g.cs
//* Name:       Other Name Type
//* Definition: The types of previous, alternate or other names for a person.
//***************************************************************************

/// <summary>
/// Other Name Type <see cref="RefOtherNameType"/>
/// <para>
/// The types of previous, alternate or other names for a person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19627">Other Name Type</a>
/// </para>
/// </summary>
[Table("RefOtherNameType", Schema = "Common")]
[Comment("The types of previous, alternate or other names for a person.")]
public partial class RefOtherNameTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
