//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildService file
/// </summary>
[Table("ElchildService", Schema = "Common")]
public partial class ElchildServiceEntity : EntityBase, IElchildService
{
    #region "IElchildService Properties"
    public Boolean? Eceapeligibility { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EligibilityPriorityPoints { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
    /// </summary>
    [Obsolete("The RefEarlyChildhoodServicesOffered property is obsolete and will be removed in a later version")]
    [ForeignKey("RefEarlyChildhoodServicesOffered")]
    public Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
    /// </summary>
    [Obsolete("The RefEarlyChildhoodServicesReceived property is obsolete and will be removed in a later version")]
    [ForeignKey("RefEarlyChildhoodServicesReceived")]
    public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceType"/> model
    /// </summary>
    [ForeignKey("RefElserviceType")]
    public Guid? RefElserviceTypeId { get; set; }

    public DateTime? ServiceDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElserviceType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElserviceTypeEntity RefElserviceTypeEntity { get; set; }

    #endregion
}
