//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   RefPsLepTypeEntity.g.cs
//* Name:       Limited English Proficiency - Postsecondary
//* Definition: The term "individual with limited English proficiency" means a secondary school student, an adult, or an out-of-school youth, who has limited ability in speaking, reading, writing, or understanding the English language AND whose native language is a language other than English; OR who lives in a family or community environment in which a language other than English is the dominant language. 
//***************************************************************************

/// <summary>
/// Limited English Proficiency - Postsecondary <see cref="RefPsLepType"/>
/// <para>
/// The term "individual with limited English proficiency" means a secondary school student, an adult, or an out-of-school youth, who has limited ability in speaking, reading, writing, or understanding the English language AND whose native language is a language other than English; OR who lives in a family or community environment in which a language other than English is the dominant language. 
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19179">Limited English Proficiency - Postsecondary</a>
/// </para>
/// </summary>
[Table("RefPsLepType", Schema = "Postsecondary")]
[Comment("The term \u0022individual with limited English proficiency\u0022 means a secondary school student, an adult, or an out-of-school youth, who has limited ability in speaking, reading, writing, or understanding the English language AND whose native language is a language other than English; OR who lives in a family or community environment in which a language other than English is the dominant language. ")]
public partial class RefPsLepTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
