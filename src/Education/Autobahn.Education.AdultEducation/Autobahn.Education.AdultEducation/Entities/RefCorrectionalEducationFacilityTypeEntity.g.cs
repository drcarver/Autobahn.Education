//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefCorrectionalEducationFacilityTypeEntity.g.cs
//* Name:       Correctional Education Facility Type
//* Definition: The type of facility in which an inmate receives correctional education services.
//***************************************************************************

/// <summary>
/// Correctional Education Facility Type <see cref="RefCorrectionalEducationFacilityType"/>
/// <para>
/// The type of facility in which an inmate receives correctional education services.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20262">Correctional Education Facility Type</a>
/// </para>
/// </summary>
[Table("RefCorrectionalEducationFacilityType", Schema = "AdultEducation")]
[Comment("The type of facility in which an inmate receives correctional education services.")]
public partial class RefCorrectionalEducationFacilityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
