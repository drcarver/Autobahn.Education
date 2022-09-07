//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefPromotionReasonEntity.g.cs
//* Name:       Promotion Reason
//* Definition: The nature of the student's promotion or progress at the end of a given school term.
//***************************************************************************

/// <summary>
/// Promotion Reason <see cref="RefPromotionReason"/>
/// <para>
/// The nature of the student's promotion or progress at the end of a given school term.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19521">Promotion Reason</a>
/// </para>
/// </summary>
[Table("RefPromotionReason", Schema = "Invalid")]
[Comment("The nature of the student's promotion or progress at the end of a given school term.")]
public partial class RefPromotionReasonEntity : ReferenceBaseEntity, IReferenceBase
{
}
