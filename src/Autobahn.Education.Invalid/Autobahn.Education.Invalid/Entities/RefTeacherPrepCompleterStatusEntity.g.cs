//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTeacherPrepCompleterStatusEntity.g.cs
//* Name:       Teacher Preparation Program Completer Status
//* Definition: An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
//***************************************************************************

/// <summary>
/// Teacher Preparation Program Completer Status <see cref="RefTeacherPrepCompleterStatus"/>
/// <para>
/// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
/// </para>
/// </summary>
[Table("RefTeacherPrepCompleterStatus", Schema = "Invalid")]
[Comment("An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.")]
public partial class RefTeacherPrepCompleterStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
