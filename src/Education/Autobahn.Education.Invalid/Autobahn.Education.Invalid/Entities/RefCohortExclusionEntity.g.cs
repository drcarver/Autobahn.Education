//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCohortExclusionEntity.g.cs
//* Name:       Cohort Exclusion
//* Definition: Those persons who may be removed (deleted) from a cohort (or subcohort). For the Graduation Rates and Fall Enrollment retention rate reporting, persons may be removed from a cohort if they left the institution for one of the following reasons: death or total and permanent disability; service in the armed forces (including those called to active duty); service with a foreign aid service of the federal government, such as the Peace Corps; or service on official church missions.
//***************************************************************************

/// <summary>
/// Cohort Exclusion <see cref="RefCohortExclusion"/>
/// <para>
/// Those persons who may be removed (deleted) from a cohort (or subcohort). For the Graduation Rates and Fall Enrollment retention rate reporting, persons may be removed from a cohort if they left the institution for one of the following reasons: death or total and permanent disability; service in the armed forces (including those called to active duty); service with a foreign aid service of the federal government, such as the Peace Corps; or service on official church missions.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19106">Cohort Exclusion</a>
/// </para>
/// </summary>
[Table("RefCohortExclusion", Schema = "Invalid")]
[Comment("Those persons who may be removed (deleted) from a cohort (or subcohort). For the Graduation Rates and Fall Enrollment retention rate reporting, persons may be removed from a cohort if they left the institution for one of the following reasons: death or total and permanent disability; service in the armed forces (including those called to active duty); service with a foreign aid service of the federal government, such as the Peace Corps; or service on official church missions.")]
public partial class RefCohortExclusionEntity : ReferenceBaseEntity, IReferenceBase
{
}
