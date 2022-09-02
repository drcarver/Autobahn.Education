//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCteGraduationRateInclusionEntity.g.cs
//* Name:       Career and Technical Education Graduation Rate Inclusion
//* Definition: An indication of how CTE concentrators are included in the state's computation of its graduation rate.
//***************************************************************************

/// <summary>
/// Career and Technical Education Graduation Rate Inclusion <see cref="RefCteGraduationRateInclusion"/>
/// <para>
/// An indication of how CTE concentrators are included in the state's computation of its graduation rate.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19075">Career and Technical Education Graduation Rate Inclusion</a>
/// </para>
/// </summary>
[Table("RefCteGraduationRateInclusion", Schema = "Common")]
[Comment("An indication of how CTE concentrators are included in the state's computation of its graduation rate.")]
public partial class RefCteGraduationRateInclusionEntity : ReferenceBaseEntity, IReferenceBase
{
}
