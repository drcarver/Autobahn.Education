//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFacilitiesPlanTypeEntity.g.cs
//* Name:       Facilities Plan Type
//* Definition: The type of management and accountability plan.
//***************************************************************************

/// <summary>
/// Facilities Plan Type <see cref="RefFacilitiesPlanType"/>
/// <para>
/// The type of management and accountability plan.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
/// </para>
/// </summary>
[Table("RefFacilitiesPlanType", Schema = "Common")]
[Comment("The type of management and accountability plan.")]
public partial class RefFacilitiesPlanTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
