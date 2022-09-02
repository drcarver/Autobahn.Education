//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefServiceFrequencyEntity.g.cs
//* Name:       Individualized Program Planned Service Frequency
//* Definition: The frequency that a service is planned to be provided.
//***************************************************************************

/// <summary>
/// Individualized Program Planned Service Frequency <see cref="RefServiceFrequency"/>
/// <para>
/// The frequency that a service is planned to be provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20492">Individualized Program Planned Service Frequency</a>
/// </para>
/// </summary>
[Table("RefServiceFrequency", Schema = "Common")]
[Comment("The frequency that a service is planned to be provided.")]
public partial class RefServiceFrequencyEntity : ReferenceBaseEntity, IReferenceBase
{
}
