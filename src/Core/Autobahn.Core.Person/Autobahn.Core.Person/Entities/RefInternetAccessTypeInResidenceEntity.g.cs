//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefInternetAccessTypeInResidenceEntity.g.cs
//* Name:       Internet Access Type In Residence
//* Definition: The primary type of internet service used in the student's primary place of residence.
//***************************************************************************

/// <summary>
/// Internet Access Type In Residence <see cref="RefInternetAccessTypeInResidence"/>
/// <para>
/// The primary type of internet service used in the student's primary place of residence.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
/// </para>
/// </summary>
[Table("RefInternetAccessTypeInResidence", Schema = "Person")]
[Comment("The primary type of internet service used in the student's primary place of residence.")]
public partial class RefInternetAccessTypeInResidenceEntity : ReferenceBaseEntity, IReferenceBase
{
}
