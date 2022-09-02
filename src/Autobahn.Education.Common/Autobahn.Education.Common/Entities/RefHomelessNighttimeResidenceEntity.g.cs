//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefHomelessNighttimeResidenceEntity.g.cs
//* Name:       Homeless Primary Nighttime Residence
//* Definition: The primary nighttime residence of the person at the time the person was identified as homeless.
//***************************************************************************

/// <summary>
/// Homeless Primary Nighttime Residence <see cref="RefHomelessNighttimeResidence"/>
/// <para>
/// The primary nighttime residence of the person at the time the person was identified as homeless.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19146">Homeless Primary Nighttime Residence</a>
/// </para>
/// </summary>
[Table("RefHomelessNighttimeResidence", Schema = "Common")]
[Comment("The primary nighttime residence of the person at the time the person was identified as homeless.")]
public partial class RefHomelessNighttimeResidenceEntity : ReferenceBaseEntity, IReferenceBase
{
}
