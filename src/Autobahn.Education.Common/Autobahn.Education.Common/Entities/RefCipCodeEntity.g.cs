//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCipCodeEntity.g.cs
//* Name:       Classification of Instructional Program Code
//* Definition: A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
//***************************************************************************

/// <summary>
/// Classification of Instructional Program Code <see cref="RefCipCode"/>
/// <para>
/// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
/// </para>
/// </summary>
[Table("RefCipCode", Schema = "Common")]
[Comment("A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.")]
public partial class RefCipCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
