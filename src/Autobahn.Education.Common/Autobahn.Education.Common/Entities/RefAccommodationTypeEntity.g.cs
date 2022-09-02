//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAccommodationTypeEntity.g.cs
//* Name:       Accommodation Type
//* Definition: The specific accommodation necessary for assessment or instruction.
//***************************************************************************

/// <summary>
/// Accommodation Type <see cref="RefAccommodationType"/>
/// <para>
/// The specific accommodation necessary for assessment or instruction.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
/// </para>
/// </summary>
[Table("RefAccommodationType", Schema = "Common")]
[Comment("The specific accommodation necessary for assessment or instruction.")]
public partial class RefAccommodationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
