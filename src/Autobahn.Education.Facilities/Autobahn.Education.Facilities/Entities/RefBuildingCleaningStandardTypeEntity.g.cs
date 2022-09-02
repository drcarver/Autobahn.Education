//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingCleaningStandardTypeEntity.g.cs
//* Name:       Building Cleaning Standard Type
//* Definition: The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
//***************************************************************************

/// <summary>
/// Building Cleaning Standard Type <see cref="RefBuildingCleaningStandardType"/>
/// <para>
/// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
/// </para>
/// </summary>
[Table("RefBuildingCleaningStandardType", Schema = "Facilities")]
[Comment("The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.")]
public partial class RefBuildingCleaningStandardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
