//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefEarlyChildhoodCredentialEntity.g.cs
//* Name:       Early Childhood Credential
//* Definition: The credential related to early childhood education or development held by a person.
//***************************************************************************

/// <summary>
/// Early Childhood Credential <see cref="RefEarlyChildhoodCredential"/>
/// <para>
/// The credential related to early childhood education or development held by a person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
/// </para>
/// </summary>
[Table("RefEarlyChildhoodCredential", Schema = "EarlyLearning")]
[Comment("The credential related to early childhood education or development held by a person.")]
public partial class RefEarlyChildhoodCredentialEntity : ReferenceBaseEntity, IReferenceBase
{
}
