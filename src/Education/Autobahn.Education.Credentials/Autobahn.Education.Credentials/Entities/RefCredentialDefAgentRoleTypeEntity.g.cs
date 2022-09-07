//***************************************************************************
//* DomainName: Credentials
//* FileName:   RefCredentialDefAgentRoleTypeEntity.g.cs
//* Name:       Credential Definition Agent Role Type
//* Definition: The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
//***************************************************************************

/// <summary>
/// Credential Definition Agent Role Type <see cref="RefCredentialDefAgentRoleType"/>
/// <para>
/// The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20895">Credential Definition Agent Role Type</a>
/// </para>
/// </summary>
[Table("RefCredentialDefAgentRoleType", Schema = "Credentials")]
[Comment("The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.")]
public partial class RefCredentialDefAgentRoleTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
