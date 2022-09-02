//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCipVersionEntity.g.cs
//* Name:       Classification of Instructional Program Version
//* Definition: The version of CIP being reported.
//***************************************************************************

/// <summary>
/// Classification of Instructional Program Version <see cref="RefCipVersion"/>
/// <para>
/// The version of CIP being reported.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
/// </para>
/// </summary>
[Table("RefCipVersion", Schema = "Common")]
[Comment("The version of CIP being reported.")]
public partial class RefCipVersionEntity : ReferenceBaseEntity, IReferenceBase
{
}
