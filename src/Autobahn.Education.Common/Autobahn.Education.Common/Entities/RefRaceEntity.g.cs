//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefRaceEntity.g.cs
//* Name:       American Indian or Alaska Native
//* Definition: A person having origins in any of the original peoples of North and South America (including Central America), and who maintains cultural identification through tribal affiliation or community attachment.
//***************************************************************************

/// <summary>
/// American Indian or Alaska Native <see cref="RefRace"/>
/// <para>
/// A person having origins in any of the original peoples of North and South America (including Central America), and who maintains cultural identification through tribal affiliation or community attachment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19655">American Indian or Alaska Native</a>
/// </para>
/// </summary>
[Table("RefRace", Schema = "Common")]
[Comment("A person having origins in any of the original peoples of North and South America (including Central America), and who maintains cultural identification through tribal affiliation or community attachment.")]
public partial class RefRaceEntity : ReferenceBaseEntity, IReferenceBase
{
}
