//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLevelOfInstitutionEntity.g.cs
//* Name:       Level of Institution
//* Definition: A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
//***************************************************************************

/// <summary>
/// Level of Institution <see cref="RefLevelOfInstitution"/>
/// <para>
/// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
/// </para>
/// </summary>
[Table("RefLevelOfInstitution", Schema = "Common")]
[Comment("A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.")]
public partial class RefLevelOfInstitutionEntity : ReferenceBaseEntity, IReferenceBase
{
}
