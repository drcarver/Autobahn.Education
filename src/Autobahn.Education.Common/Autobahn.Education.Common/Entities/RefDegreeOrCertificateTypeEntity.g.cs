//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDegreeOrCertificateTypeEntity.g.cs
//* Name:       Degree or Certificate Type
//* Definition: The type of degree or certificate earned by a person.
//***************************************************************************

/// <summary>
/// Degree or Certificate Type <see cref="RefDegreeOrCertificateType"/>
/// <para>
/// The type of degree or certificate earned by a person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19342">Degree or Certificate Type</a>
/// </para>
/// </summary>
[Table("RefDegreeOrCertificateType", Schema = "Common")]
[Comment("The type of degree or certificate earned by a person.")]
public partial class RefDegreeOrCertificateTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
