//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsstudentProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsstudentProgram file
/// </summary>
[Table("PsstudentProgram", Schema = "Postsecondary")]
public partial class PsstudentProgramEntity : EntityBase, IPsstudentProgram
{
    #region "IPsstudentProgram Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsProgram"/> model
    /// </summary>
    [ForeignKey("PsProgram")]
    public Guid? PsProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    [ForeignKey("RefCareerCluster")]
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCipUse"/> model
    /// </summary>
    [ForeignKey("RefCipUse")]
    public Guid? RefCipUseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
    /// </summary>
    [ForeignKey("RefTransferOutIndicator")]
    public Guid? RefTransferOutIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    [ForeignKey("RefWorkbasedLearningOpportunityType")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCipUse"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCipUseEntity? RefCipUseEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsProgram"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual PsProgramEntity? PsProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWorkbasedLearningOpportunityType"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefWorkbasedLearningOpportunityTypeEntity? RefWorkbasedLearningOpportunityTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTransferOutIndicator"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefTransferOutIndicatorEntity? RefTransferOutIndicatorEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCareerCluster"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCareerClusterEntity? RefCareerClusterEntity { get; set; }

    #endregion
}
