//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgramEntryReasonEntity.g.cs
//* Name:       Program Entry Reason
//* Definition: The documented or assumed reason a person is being served by a program.
//***************************************************************************

/// <summary>
/// Program Entry Reason <see cref="RefProgramEntryReason"/>
/// <para>
/// The documented or assumed reason a person is being served by a program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
/// </para>
/// </summary>
[Table("RefProgramEntryReason", Schema = "Common")]
[Comment("The documented or assumed reason a person is being served by a program.")]
public partial class RefProgramEntryReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
