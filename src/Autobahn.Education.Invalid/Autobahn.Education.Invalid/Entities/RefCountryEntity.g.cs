//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCountryEntity.g.cs
//* Name:       Country Code
//* Definition: The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
//***************************************************************************

/// <summary>
/// Country Code <see cref="RefCountry"/>
/// <para>
/// The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19050">Country Code</a>
/// </para>
/// </summary>
[Table("RefCountry", Schema = "Invalid")]
[Comment("The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.")]
public partial class RefCountryEntity : ReferenceBaseEntity, IReferenceBase
{
}
