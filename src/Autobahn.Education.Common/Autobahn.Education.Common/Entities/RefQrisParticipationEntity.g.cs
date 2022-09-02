//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefQrisParticipationEntity.g.cs
//* Name:       Quality Rating and Improvement System Participation
//* Definition: Program site participates in a Quality Rating and Improvement System (QRIS).
//***************************************************************************

/// <summary>
/// Quality Rating and Improvement System Participation <see cref="RefQrisParticipation"/>
/// <para>
/// Program site participates in a Quality Rating and Improvement System (QRIS).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19356">Quality Rating and Improvement System Participation</a>
/// </para>
/// </summary>
[Table("RefQrisParticipation", Schema = "Common")]
[Comment("Program site participates in a Quality Rating and Improvement System (QRIS).")]
public partial class RefQrisParticipationEntity : ReferenceBaseEntity, IReferenceBase
{
}
