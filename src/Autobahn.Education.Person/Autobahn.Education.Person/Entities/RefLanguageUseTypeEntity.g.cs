//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefLanguageUseTypeEntity.g.cs
//* Name:       Language Type
//* Definition: An indication of the function and context in which a person uses a language to communicate.
//***************************************************************************

/// <summary>
/// Language Type <see cref="RefLanguageUseType"/>
/// <para>
/// An indication of the function and context in which a person uses a language to communicate.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
/// </para>
/// </summary>
[Table("RefLanguageUseType", Schema = "Person")]
[Comment("An indication of the function and context in which a person uses a language to communicate.")]
public partial class RefLanguageUseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
