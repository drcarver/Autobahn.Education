//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAltRouteToCertificationOrLicensureEntity.g.cs
//* Name:       Alternative Route to Certification or Licensure
//* Definition: An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
//***************************************************************************

/// <summary>
/// Alternative Route to Certification or Licensure <see cref="RefAltRouteToCertificationOrLicensure"/>
/// <para>
/// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
/// </para>
/// </summary>
[Table("RefAltRouteToCertificationOrLicensure", Schema = "Common")]
[Comment("An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.")]
public partial class RefAltRouteToCertificationOrLicensureEntity : ReferenceBaseEntity, IReferenceBase
{
}
