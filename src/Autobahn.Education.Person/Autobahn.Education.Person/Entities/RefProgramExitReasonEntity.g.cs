//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefProgramExitReasonEntity.g.cs
//* Name:       Exit Reason
//* Definition: The documented or assumed reason a student is no longer being served by a special program.
//***************************************************************************

/// <summary>
/// Exit Reason <see cref="RefProgramExitReason"/>
/// <para>
/// The documented or assumed reason a student is no longer being served by a special program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
/// </para>
/// </summary>
[Table("RefProgramExitReason", Schema = "Person")]
[Comment("The documented or assumed reason a student is no longer being served by a special program.")]
public partial class RefProgramExitReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
