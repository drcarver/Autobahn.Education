//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeCertificationTypeEntity.g.cs
//* Name:       Adult Education Certification Type
//* Definition: An indication of the category of the adult education certification a person holds.
//***************************************************************************

/// <summary>
/// Adult Education Certification Type <see cref="RefAeCertificationType"/>
/// <para>
/// An indication of the category of the adult education certification a person holds.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
/// </para>
/// </summary>
[Table("RefAeCertificationType", Schema = "AdultEducation")]
[Comment("An indication of the category of the adult education certification a person holds.")]
public partial class RefAeCertificationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
