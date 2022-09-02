//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAccommodationsNeededTypeEntity.g.cs
//* Name:       Accommodations Needed Type
//* Definition: Codes identifying the set of health accommodations.
//***************************************************************************

/// <summary>
/// Accommodations Needed Type <see cref="RefAccommodationsNeededType"/>
/// <para>
/// Codes identifying the set of health accommodations.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20243">Accommodations Needed Type</a>
/// </para>
/// </summary>
[Table("RefAccommodationsNeededType", Schema = "Common")]
[Comment("Codes identifying the set of health accommodations.")]
public partial class RefAccommodationsNeededTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
