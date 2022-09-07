//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilitySiteImprovementLocationTypeEntity.g.cs
//* Name:       Facility Site Improvement Location Type
//* Definition: The type of location of the designed and constructed improvements made to a site.
//***************************************************************************

/// <summary>
/// Facility Site Improvement Location Type <see cref="RefFacilitySiteImprovementLocationType"/>
/// <para>
/// The type of location of the designed and constructed improvements made to a site.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
/// </para>
/// </summary>
[Table("RefFacilitySiteImprovementLocationType", Schema = "Facilities")]
[Comment("The type of location of the designed and constructed improvements made to a site.")]
public partial class RefFacilitySiteImprovementLocationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
