//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefVisaTypeEntity.g.cs
//* Name:       Visa Type
//* Definition: An indicator of a non-US citizen's Visa type.
//***************************************************************************

/// <summary>
/// Visa Type <see cref="RefVisaType"/>
/// <para>
/// An indicator of a non-US citizen's Visa type.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19196">Visa Type</a>
/// </para>
/// </summary>
[Table("RefVisaType", Schema = "Common")]
[Comment("An indicator of a non-US citizen's Visa type.")]
public partial class RefVisaTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
