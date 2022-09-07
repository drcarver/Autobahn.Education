//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefAllergyTypeEntity.g.cs
//* Name:       Allergy Type
//* Definition: Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
//***************************************************************************

/// <summary>
/// Allergy Type <see cref="RefAllergyType"/>
/// <para>
/// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
/// </para>
/// </summary>
[Table("RefAllergyType", Schema = "Person")]
[Comment("Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.")]
public partial class RefAllergyTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
