//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAcademicRankEntity.g.cs
//* Name:       Academic Rank
//* Definition: The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as "No Academic Rank."
//***************************************************************************

/// <summary>
/// Academic Rank <see cref="RefAcademicRank"/>
/// <para>
/// The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as "No Academic Rank."
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19717">Academic Rank</a>
/// </para>
/// </summary>
[Table("RefAcademicRank", Schema = "Common")]
[Comment("The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as \u0022No Academic Rank.\u0022")]
public partial class RefAcademicRankEntity : ReferenceBaseEntity, IReferenceBase
{
}
