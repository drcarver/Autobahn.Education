//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCipUseEntity.g.cs
//* Name:       Classification of Instructional Program Use
//* Definition: An indicator of whether the CIP Code is referencing an enrollment program or an award program.
//***************************************************************************

/// <summary>
/// Classification of Instructional Program Use <see cref="RefCipUse"/>
/// <para>
/// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19044">Classification of Instructional Program Use</a>
/// </para>
/// </summary>
[Table("RefCipUse", Schema = "Invalid")]
[Comment("An indicator of whether the CIP Code is referencing an enrollment program or an award program.")]
public partial class RefCipUseEntity : ReferenceBaseEntity, IReferenceBase
{
}
