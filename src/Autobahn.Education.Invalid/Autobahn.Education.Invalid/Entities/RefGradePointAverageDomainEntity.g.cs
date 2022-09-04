//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefGradePointAverageDomainEntity.g.cs
//* Name:       Grade Point Average Domain
//* Definition: The domain to which the Grade Point Average is referencing.
//***************************************************************************

/// <summary>
/// Grade Point Average Domain <see cref="RefGradePointAverageDomain"/>
/// <para>
/// The domain to which the Grade Point Average is referencing.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19739">Grade Point Average Domain</a>
/// </para>
/// </summary>
[Table("RefGradePointAverageDomain", Schema = "Invalid")]
[Comment("The domain to which the Grade Point Average is referencing.")]
public partial class RefGradePointAverageDomainEntity : ReferenceBaseEntity, IReferenceBase
{
}
