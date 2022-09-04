//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCriterion file
/// </summary>
[Table("CredentialDefCriterion", Schema = "Credentials")]
public partial class CredentialDefCriterionEntity : EntityBase, ICredentialDefCriterion
{
    #region "ICredentialDefCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [ForeignKey("CompetencySet")]
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefCriteria")]
    public Guid CredentialDefCriteriaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefinition")]
    public Guid CredentialDefinitionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Criteria { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CriteriaUrl { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EstimatedDuration { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumDuration { get; set; }

    public Int32? MinimumAge { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumDuration { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
    /// </summary>
    [ForeignKey("RefCredentialDefAssessMethodType")]
    public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialDefinitionEntity CredentialDefinitionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CompetencySetEntity? CompetencySetEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCredentialDefAssessMethodType"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual RefCredentialDefAssessMethodTypeEntity? RefCredentialDefAssessMethodTypeEntity { get; set; }

    #endregion
}
