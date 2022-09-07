//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAypStatusEntity.g.cs
//* Name:       Adequate Yearly Progress Status
//* Definition: An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.
//***************************************************************************

/// <summary>
/// Adequate Yearly Progress Status <see cref="RefAypStatus"/>
/// <para>
/// An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19011">Adequate Yearly Progress Status</a>
/// </para>
/// </summary>
[Table("RefAypStatus", Schema = "Common")]
[Comment("An indication of whether the state, district, or school met the Adequate Yearly Progress (AYP) requirements for the school year, as determined by the state-established criteria.")]
public partial class RefAypStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
