//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMagnetSpecialProgramEntity.g.cs
//* Name:       Magnet or Special Program Emphasis School
//* Definition: A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2)to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, career academy or foreign language).
//***************************************************************************

/// <summary>
/// Magnet or Special Program Emphasis School <see cref="RefMagnetSpecialProgram"/>
/// <para>
/// A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2)to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, career academy or foreign language).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19181">Magnet or Special Program Emphasis School</a>
/// </para>
/// </summary>
[Table("RefMagnetSpecialProgram", Schema = "Common")]
[Comment("A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2)to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, career academy or foreign language).")]
public partial class RefMagnetSpecialProgramEntity : ReferenceBaseEntity, IReferenceBase
{
}
