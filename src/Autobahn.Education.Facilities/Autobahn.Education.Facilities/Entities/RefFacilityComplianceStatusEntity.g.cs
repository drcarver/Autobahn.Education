//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityComplianceStatusEntity.g.cs
//* Name:       Facility Compliance Status
//* Definition: An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
//***************************************************************************

/// <summary>
/// Facility Compliance Status <see cref="RefFacilityComplianceStatus"/>
/// <para>
/// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
/// </para>
/// </summary>
[Table("RefFacilityComplianceStatus", Schema = "Facilities")]
[Comment("An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.")]
public partial class RefFacilityComplianceStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
