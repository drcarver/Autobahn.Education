//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefDisciplinaryActionTakenEntity.g.cs
//* Name:       Disciplinary Action Taken
//* Definition: Identifies the consequences of an incident for the student(s) involved in an incident as perpetrator(s).
//***************************************************************************

/// <summary>
/// Disciplinary Action Taken <see cref="RefDisciplinaryActionTaken"/>
/// <para>
/// Identifies the consequences of an incident for the student(s) involved in an incident as perpetrator(s).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19479">Disciplinary Action Taken</a>
/// </para>
/// </summary>
[Table("RefDisciplinaryActionTaken", Schema = "Invalid")]
[Comment("Identifies the consequences of an incident for the student(s) involved in an incident as perpetrator(s).")]
public partial class RefDisciplinaryActionTakenEntity : ReferenceBaseEntity, IReferenceBase
{
}
