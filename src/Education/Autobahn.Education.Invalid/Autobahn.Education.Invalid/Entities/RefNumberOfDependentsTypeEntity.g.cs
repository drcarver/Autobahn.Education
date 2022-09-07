//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefNumberOfDependentsTypeEntity.g.cs
//* Name:       Number of Dependents Type
//* Definition: The student's relationship to the dependents who live with the student or receive more than half of the student's support
//***************************************************************************

/// <summary>
/// Number of Dependents Type <see cref="RefNumberOfDependentsType"/>
/// <para>
/// The student's relationship to the dependents who live with the student or receive more than half of the student's support
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20949">Number of Dependents Type</a>
/// </para>
/// </summary>
[Table("RefNumberOfDependentsType", Schema = "Invalid")]
[Comment("The student's relationship to the dependents who live with the student or receive more than half of the student's support")]
public partial class RefNumberOfDependentsTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
