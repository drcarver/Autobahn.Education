//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFrequencyOfServiceEntity.g.cs
//* Name:       Frequency of Service
//* Definition: The frequency at which a service is planned to occur.
//***************************************************************************

/// <summary>
/// Frequency of Service <see cref="RefFrequencyOfService"/>
/// <para>
/// The frequency at which a service is planned to occur.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20323">Frequency of Service</a>
/// </para>
/// </summary>
[Table("RefFrequencyOfService", Schema = "Common")]
[Comment("The frequency at which a service is planned to occur.")]
public partial class RefFrequencyOfServiceEntity : ReferenceBaseEntity, IReferenceBase
{
}
