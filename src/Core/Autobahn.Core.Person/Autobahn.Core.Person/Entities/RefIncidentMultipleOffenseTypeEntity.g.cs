//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefIncidentMultipleOffenseTypeEntity.g.cs
//* Name:       Incident Multiple Offense Type
//* Definition: An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.
//***************************************************************************

/// <summary>
/// Incident Multiple Offense Type <see cref="RefIncidentMultipleOffenseType"/>
/// <para>
/// An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20337">Incident Multiple Offense Type</a>
/// </para>
/// </summary>
[Table("RefIncidentMultipleOffenseType", Schema = "Person")]
[Comment("An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.")]
public partial class RefIncidentMultipleOffenseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
