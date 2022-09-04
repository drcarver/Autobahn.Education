//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefPersonTelephoneNumberTypeEntity.g.cs
//* Name:       Telephone Number Type
//* Definition: The type of communication number listed for a person.
//***************************************************************************

/// <summary>
/// Telephone Number Type <see cref="RefPersonTelephoneNumberType"/>
/// <para>
/// The type of communication number listed for a person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19280">Telephone Number Type</a>
/// </para>
/// </summary>
[Table("RefPersonTelephoneNumberType", Schema = "Autobahn.Core.Person")]
[Comment("The type of communication number listed for a person.")]
public partial class RefPersonTelephoneNumberTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
