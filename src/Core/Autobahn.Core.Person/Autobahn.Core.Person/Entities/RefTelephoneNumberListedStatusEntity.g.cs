//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefTelephoneNumberListedStatusEntity.g.cs
//* Name:       Telephone Number Listed Status
//* Definition: An indication of whether a telephone number is listed under a directory assistance service.
//***************************************************************************

/// <summary>
/// Telephone Number Listed Status <see cref="RefTelephoneNumberListedStatus"/>
/// <para>
/// An indication of whether a telephone number is listed under a directory assistance service.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
/// </para>
/// </summary>
[Table("RefTelephoneNumberListedStatus", Schema = "Person")]
[Comment("An indication of whether a telephone number is listed under a directory assistance service.")]
public partial class RefTelephoneNumberListedStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
