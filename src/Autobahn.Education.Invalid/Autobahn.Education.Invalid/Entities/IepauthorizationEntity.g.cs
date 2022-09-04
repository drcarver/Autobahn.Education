//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IepauthorizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorization file
/// </summary>
[Table("Iepauthorization", Schema = "Invalid")]
public partial class IepauthorizationEntity : EntityBase, IIepauthorization
{
    #region "IIepauthorization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAuthorizationDocument"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AuthorizationDocument")]
    public Guid AuthorizationDocumentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepauthorizationDocumentType"/> model
    /// </summary>
    [ForeignKey("RefIepauthorizationDocumentType")]
    public Guid? RefIepauthorizationDocumentTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIepauthorizationDocumentType"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefIepauthorizationDocumentTypeEntity? RefIepauthorizationDocumentTypeEntity { get; set; }

    #endregion
}
