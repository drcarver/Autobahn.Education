//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityStandardTypeEntity.g.cs
//* Name:       Facility Standard Type
//* Definition: An indication of the district or state requirements or guidelines for the design and construction of school facilities.
//***************************************************************************

/// <summary>
/// Facility Standard Type <see cref="RefFacilityStandardType"/>
/// <para>
/// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
/// </para>
/// </summary>
[Table("RefFacilityStandardType", Schema = "Facilities")]
[Comment("An indication of the district or state requirements or guidelines for the design and construction of school facilities.")]
public partial class RefFacilityStandardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
