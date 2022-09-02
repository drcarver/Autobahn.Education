//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEmploymentContractTypeEntity.g.cs
//* Name:       Contract Type
//* Definition: The type of employment contract used by an institution.
//***************************************************************************

/// <summary>
/// Contract Type <see cref="RefEmploymentContractType"/>
/// <para>
/// The type of employment contract used by an institution.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19714">Contract Type</a>
/// </para>
/// </summary>
[Table("RefEmploymentContractType", Schema = "Common")]
[Comment("The type of employment contract used by an institution.")]
public partial class RefEmploymentContractTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
