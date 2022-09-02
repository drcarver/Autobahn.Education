//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCommunityBasedTypeEntity.g.cs
//* Name:       Community-based Type
//* Definition: Non domestic residence in which the early learning setting is located.
//***************************************************************************

/// <summary>
/// Community-based Type <see cref="RefCommunityBasedType"/>
/// <para>
/// Non domestic residence in which the early learning setting is located.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
/// </para>
/// </summary>
[Table("RefCommunityBasedType", Schema = "Common")]
[Comment("Non domestic residence in which the early learning setting is located.")]
public partial class RefCommunityBasedTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
