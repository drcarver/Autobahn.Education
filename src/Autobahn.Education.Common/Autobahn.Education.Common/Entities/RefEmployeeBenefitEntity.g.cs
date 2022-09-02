//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEmployeeBenefitEntity.g.cs
//* Name:       Full-Time Employee Benefits
//* Definition: The benefits offered by a program/facility/employer for full-time staff.
//***************************************************************************

/// <summary>
/// Full-Time Employee Benefits <see cref="RefEmployeeBenefit"/>
/// <para>
/// The benefits offered by a program/facility/employer for full-time staff.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
/// </para>
/// </summary>
[Table("RefEmployeeBenefit", Schema = "Common")]
[Comment("The benefits offered by a program/facility/employer for full-time staff.")]
public partial class RefEmployeeBenefitEntity : ReferenceBaseEntity, IReferenceBase
{
}
