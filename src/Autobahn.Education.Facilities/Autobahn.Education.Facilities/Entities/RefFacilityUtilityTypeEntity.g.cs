//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityUtilityTypeEntity.g.cs
//* Name:       Facility Utility Type
//* Definition: The type of utility used in the operation of a facility.
//***************************************************************************

/// <summary>
/// Facility Utility Type <see cref="RefFacilityUtilityType"/>
/// <para>
/// The type of utility used in the operation of a facility.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20860">Facility Utility Type</a>
/// </para>
/// </summary>
[Table("RefFacilityUtilityType", Schema = "Facilities")]
[Comment("The type of utility used in the operation of a facility.")]
public partial class RefFacilityUtilityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
