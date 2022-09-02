//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAdultEducationProgramExitReasonEntity.g.cs
//* Name:       Adult Education Program Exit Reason
//* Definition: The documented or assumed reason the person is no longer being served by the adult education program.
//***************************************************************************

/// <summary>
/// Adult Education Program Exit Reason <see cref="RefAdultEducationProgramExitReason"/>
/// <para>
/// The documented or assumed reason the person is no longer being served by the adult education program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20915">Adult Education Program Exit Reason</a>
/// </para>
/// </summary>
[Table("RefAdultEducationProgramExitReason", Schema = "Common")]
[Comment("The documented or assumed reason the person is no longer being served by the adult education program.")]
public partial class RefAdultEducationProgramExitReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
