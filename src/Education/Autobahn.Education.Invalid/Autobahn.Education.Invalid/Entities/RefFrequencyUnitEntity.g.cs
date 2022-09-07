//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefFrequencyUnitEntity.g.cs
//* Name:       Frequency Unit
//* Definition: The unit of time by which a cycle is defined.
//***************************************************************************

/// <summary>
/// Frequency Unit <see cref="RefFrequencyUnit"/>
/// <para>
/// The unit of time by which a cycle is defined.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
/// </para>
/// </summary>
[Table("RefFrequencyUnit", Schema = "Invalid")]
[Comment("The unit of time by which a cycle is defined.")]
public partial class RefFrequencyUnitEntity : ReferenceBaseEntity, IReferenceBase
{
}
