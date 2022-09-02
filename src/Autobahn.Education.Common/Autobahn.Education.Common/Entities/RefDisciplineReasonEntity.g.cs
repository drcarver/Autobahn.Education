//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDisciplineReasonEntity.g.cs
//* Name:       Discipline Reason
//* Definition: The reason why the student was disciplined.
//***************************************************************************

/// <summary>
/// Discipline Reason <see cref="RefDisciplineReason"/>
/// <para>
/// The reason why the student was disciplined.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19536">Discipline Reason</a>
/// </para>
/// </summary>
[Table("RefDisciplineReason", Schema = "Common")]
[Comment("The reason why the student was disciplined.")]
public partial class RefDisciplineReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
