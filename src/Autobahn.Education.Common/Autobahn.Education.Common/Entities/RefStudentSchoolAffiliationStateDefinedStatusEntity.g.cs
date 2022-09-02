//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefStudentSchoolAffiliationStateDefinedStatusEntity.g.cs
//* Name:       Student School Affiliation State Defined Status
//* Definition: An indication of the nature of a student's affiliation, as defined by the state, with a public school and used generally, but not exclusively, for the purpose of determining residency, funding, or accountability.
//***************************************************************************

/// <summary>
/// Student School Affiliation State Defined Status <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/>
/// <para>
/// An indication of the nature of a student's affiliation, as defined by the state, with a public school and used generally, but not exclusively, for the purpose of determining residency, funding, or accountability.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20968">Student School Affiliation State Defined Status</a>
/// </para>
/// </summary>
[Table("RefStudentSchoolAffiliationStateDefinedStatus", Schema = "Common")]
[Comment("An indication of the nature of a student's affiliation, as defined by the state, with a public school and used generally, but not exclusively, for the purpose of determining residency, funding, or accountability.")]
public partial class RefStudentSchoolAffiliationStateDefinedStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
