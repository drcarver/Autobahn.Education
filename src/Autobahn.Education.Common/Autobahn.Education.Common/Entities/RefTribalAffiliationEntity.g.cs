//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTribalAffiliationEntity.g.cs
//* Name:       Tribal Affiliation
//* Definition: The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.
//***************************************************************************

/// <summary>
/// Tribal Affiliation <see cref="RefTribalAffiliation"/>
/// <para>
/// The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20638">Tribal Affiliation</a>
/// </para>
/// </summary>
[Table("RefTribalAffiliation", Schema = "Common")]
[Comment("The Native American tribal entity recognized and eligible to receive services from the United States Bureau of Indian Affairs to which a person is affiliated.")]
public partial class RefTribalAffiliationEntity : ReferenceBaseEntity, IReferenceBase
{
}
