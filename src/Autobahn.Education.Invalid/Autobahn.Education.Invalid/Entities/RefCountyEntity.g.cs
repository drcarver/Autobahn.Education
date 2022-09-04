//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCountyEntity.g.cs
//* Name:       County ANSI Code
//* Definition: County code as defined for the identification of counties and equivalent areas of the United States, Puerto Rico, and the insular areas as established by the American National Standards Institute (ANSI) Inter-National Committee for Information Technology Standards (INCITS) in specification BSR INCITS 31-200x or more current updates. See https://www.census.gov/library/reference/code-lists/ansi.html#par_statelist.
//***************************************************************************

/// <summary>
/// County ANSI Code <see cref="RefCounty"/>
/// <para>
/// County code as defined for the identification of counties and equivalent areas of the United States, Puerto Rico, and the insular areas as established by the American National Standards Institute (ANSI) Inter-National Committee for Information Technology Standards (INCITS) in specification BSR INCITS 31-200x or more current updates. See https://www.census.gov/library/reference/code-lists/ansi.html#par_statelist.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20176">County ANSI Code</a>
/// </para>
/// </summary>
[Table("RefCounty", Schema = "Invalid")]
[Comment("County code as defined for the identification of counties and equivalent areas of the United States, Puerto Rico, and the insular areas as established by the American National Standards Institute (ANSI) Inter-National Committee for Information Technology Standards (INCITS) in specification BSR INCITS 31-200x or more current updates. See https://www.census.gov/library/reference/code-lists/ansi.html#par_statelist.")]
public partial class RefCountyEntity : ReferenceBaseEntity, IReferenceBase
{
}
