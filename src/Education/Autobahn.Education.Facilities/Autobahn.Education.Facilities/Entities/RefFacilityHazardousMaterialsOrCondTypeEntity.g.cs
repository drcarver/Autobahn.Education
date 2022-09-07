//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityHazardousMaterialsOrCondTypeEntity.g.cs
//* Name:       Facility Hazardous Materials or Condition Type
//* Definition: The type of hazardous materials or conditions tested for at a site or building.
//***************************************************************************

/// <summary>
/// Facility Hazardous Materials or Condition Type <see cref="RefFacilityHazardousMaterialsOrCondType"/>
/// <para>
/// The type of hazardous materials or conditions tested for at a site or building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20855">Facility Hazardous Materials or Condition Type</a>
/// </para>
/// </summary>
[Table("RefFacilityHazardousMaterialsOrCondType", Schema = "Facilities")]
[Comment("The type of hazardous materials or conditions tested for at a site or building.")]
public partial class RefFacilityHazardousMaterialsOrCondTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
