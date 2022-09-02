//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDevelopmentalEducationTypeEntity.g.cs
//* Name:       Developmental Education Type
//* Definition: An indicator of the category of developmental education.
//***************************************************************************

/// <summary>
/// Developmental Education Type <see cref="RefDevelopmentalEducationType"/>
/// <para>
/// An indicator of the category of developmental education.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
/// </para>
/// </summary>
[Table("RefDevelopmentalEducationType", Schema = "Common")]
[Comment("An indicator of the category of developmental education.")]
public partial class RefDevelopmentalEducationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
