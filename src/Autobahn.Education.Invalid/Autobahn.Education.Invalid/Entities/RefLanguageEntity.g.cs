//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefLanguageEntity.g.cs
//* Name:       ISO 639-2 Language Code
//* Definition: The code for the specific language or dialect that a person uses to communicate.
//***************************************************************************

/// <summary>
/// ISO 639-2 Language Code <see cref="RefLanguage"/>
/// <para>
/// The code for the specific language or dialect that a person uses to communicate.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
/// </para>
/// </summary>
[Table("RefLanguage", Schema = "Invalid")]
[Comment("The code for the specific language or dialect that a person uses to communicate.")]
public partial class RefLanguageEntity : ReferenceBaseEntity, IReferenceBase
{
}
