//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefAssessmentSessionStaffRoleTypeEntity.g.cs
//* Name:       Assessment Session Staff Role Type
//* Definition: The type of role served related to the administration of an assessment session.
//***************************************************************************

/// <summary>
/// Assessment Session Staff Role Type <see cref="RefAssessmentSessionStaffRoleType"/>
/// <para>
/// The type of role served related to the administration of an assessment session.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentSessionStaffRoleType", Schema = "Autobahn.Core.Role")]
[Comment("The type of role served related to the administration of an assessment session.")]
public partial class RefAssessmentSessionStaffRoleTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
