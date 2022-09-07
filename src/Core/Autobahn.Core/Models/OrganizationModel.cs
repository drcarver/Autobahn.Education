//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   OrganizationModel.cs
//**********************************************************

/// <summary>
/// An organization, is an entity—such as a company, an 
/// institution, or an association—comprising one or 
/// more people and having a particular purpose.
/// </summary>
public partial class OrganizationModel : AutobahnBaseModel, IOrganization
{
    /// <summary>
    /// The Name of the Organization
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The short name of the organization
    /// </summary>
    public string? ShortName { get; set; }

    /// <summary>
    /// The type of organization
    /// </summary>
    public Guid? RefOrganizationTypeId { get; set; }
}