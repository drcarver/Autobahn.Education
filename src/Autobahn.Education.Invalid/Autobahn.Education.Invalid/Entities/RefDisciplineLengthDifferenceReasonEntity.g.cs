//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefDisciplineLengthDifferenceReasonEntity.g.cs
//* Name:       Discipline Action Length Difference Reason
//* Definition: The reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.
//***************************************************************************

/// <summary>
/// Discipline Action Length Difference Reason <see cref="RefDisciplineLengthDifferenceReason"/>
/// <para>
/// The reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19602">Discipline Action Length Difference Reason</a>
/// </para>
/// </summary>
[Table("RefDisciplineLengthDifferenceReason", Schema = "Invalid")]
[Comment("The reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment.")]
public partial class RefDisciplineLengthDifferenceReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
