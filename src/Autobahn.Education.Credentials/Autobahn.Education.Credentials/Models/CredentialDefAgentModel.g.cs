//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgent file
/// </summary>
public partial class CredentialDefAgentModel : AutobahnBaseModel, ICredentialDefAgent
{
    #region "ICredentialDefAgent Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid? PersonId { get; set; }

    /// <summary>
    /// Credential Definition Agent Role Type
    /// <para>
    /// The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20895">Credential Definition Agent Role Type</a>
    /// </para>
    /// </summary>
    public Guid? RefCredentialDefAgentRoleTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    public Guid? RefCtdlorganizationTypeId { get; set; }

    #endregion
}
