//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefNonPromotionReasonEntity.g.cs
//* Name:       Nonpromotion Reason
//* Definition: The primary reason as to why a staff member determined that a student should not be promoted (or be demoted).
//***************************************************************************

/// <summary>
/// Nonpromotion Reason <see cref="RefNonPromotionReason"/>
/// <para>
/// The primary reason as to why a staff member determined that a student should not be promoted (or be demoted).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19522">Nonpromotion Reason</a>
/// </para>
/// </summary>
[Table("RefNonPromotionReason", Schema = "Common")]
[Comment("The primary reason as to why a staff member determined that a student should not be promoted (or be demoted).")]
public partial class RefNonPromotionReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
