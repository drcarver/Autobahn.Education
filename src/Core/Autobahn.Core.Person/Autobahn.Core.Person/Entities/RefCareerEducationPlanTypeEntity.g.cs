//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefCareerEducationPlanTypeEntity.g.cs
//* Name:       Career Education Plan Type
//* Definition: An indication of whether an individual completed an individualized guidance and counseling plan
//***************************************************************************

/// <summary>
/// Career Education Plan Type <see cref="RefCareerEducationPlanType"/>
/// <para>
/// An indication of whether an individual completed an individualized guidance and counseling plan
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20256">Career Education Plan Type</a>
/// </para>
/// </summary>
[Table("RefCareerEducationPlanType", Schema = "Person")]
[Comment("An indication of whether an individual completed an individualized guidance and counseling plan")]
public partial class RefCareerEducationPlanTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
