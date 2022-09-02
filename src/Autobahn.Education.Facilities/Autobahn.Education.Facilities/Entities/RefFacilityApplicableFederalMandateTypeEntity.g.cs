//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityApplicableFederalMandateTypeEntity.g.cs
//* Name:       Facility Applicable Federal Mandate Type
//* Definition: The particular federal law, regulation, or standard that pertains to a school facility.
//***************************************************************************

/// <summary>
/// Facility Applicable Federal Mandate Type <see cref="RefFacilityApplicableFederalMandateType"/>
/// <para>
/// The particular federal law, regulation, or standard that pertains to a school facility.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
/// </para>
/// </summary>
[Table("RefFacilityApplicableFederalMandateType", Schema = "Facilities")]
[Comment("The particular federal law, regulation, or standard that pertains to a school facility.")]
public partial class RefFacilityApplicableFederalMandateTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
