//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   OrganizationEntity.cs
//**********************************************************

/// <summary>
/// An organization, is an entity—such as a company, an 
/// institution, or an association—comprising one or 
/// more people and having a particular purpose.
/// </summary>
[Table("Organization", Schema = "Core")]
public partial class OrganizationEntity : EntityBase, IOrganization
{
    /// <summary>
    /// The short name of the organization
    /// </summary>
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(30)]
    public string ShortName { get; set; }

    /// <summary>
    /// The stock symbol for companies
    /// </summary>
    [StringLength(4)]
    public string Symbol { get; set; }

    /// <summary>
    /// The type of organization
    /// </summary>
    public Guid? RefOrganizationTypeId { get; set; }
}
