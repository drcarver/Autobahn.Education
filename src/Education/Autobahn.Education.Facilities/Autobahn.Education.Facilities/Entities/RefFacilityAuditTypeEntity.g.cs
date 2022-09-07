//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityAuditTypeEntity.g.cs
//* Name:       Facility Audit Type
//* Definition: The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
//***************************************************************************

/// <summary>
/// Facility Audit Type <see cref="RefFacilityAuditType"/>
/// <para>
/// The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20845">Facility Audit Type</a>
/// </para>
/// </summary>
[Table("RefFacilityAuditType", Schema = "Facilities")]
[Comment("The type of systematic review or audit of facility quality, management, decision making processes, controls, schedule and cost.")]
public partial class RefFacilityAuditTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
