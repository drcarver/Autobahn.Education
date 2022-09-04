//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefAssociation file
/// </summary>
[Table("CompetencyDefAssociation", Schema = "Competencies")]
public partial class CompetencyDefAssociationEntity : EntityBase, ICompetencyDefAssociation
{
    #region "ICompetencyDefAssociation Properties"
    /// <summary>
    /// Competency Definition Prerequisite Identifier
    /// <para>
    /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
    /// </para>
    /// <para>
    /// <a href="">Competency Definition Prerequisite Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssociatedEntity")]
    [Comment("The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)")]
    public Guid AssociatedEntityId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyDefAssociationIdentifierUri { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Association Connection Citation
    /// <para>
    /// Any citation appropriate to evidence the connection between nodes
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20371">Competency Association Connection Citation</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Any citation appropriate to evidence the connection between nodes")]
    public System.String ConnectionCitation { get; set; }

    /// <summary>
    /// Competency Association Destination Node Name
    /// <para>
    /// Name of the destination node when the Competency Association is used as a connector in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20372">Competency Association Destination Node Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Name of the destination node when the Competency Association is used as a connector in a learning map.")]
    public System.String DestinationNodeName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DestinationNodeUri { get; set; }

    /// <summary>
    /// Competency Association Origin Node Name
    /// <para>
    /// Name of the origin node when the Competency Association is used as a connector in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20374">Competency Association Origin Node Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Name of the origin node when the Competency Association is used as a connector in a learning map.")]
    public System.String OriginNodeName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OriginNodeUri { get; set; }

    /// <summary>
    /// Competency Association Type
    /// <para>
    /// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCompetencyDefAssociationType")]
    [Comment("Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.")]
    public Guid? RefCompetencyDefAssociationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntityType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEntityType")]
    public Guid RefEntityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Competency Alignment Type
    /// <para>
    /// The alignment relationship between the resource and a competency definition object.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearningResourceCompetencyAlignmentType")]
    [Comment("The alignment relationship between the resource and a competency definition object.")]
    public Guid? RefLearningResourceCompetencyAlignmentTypeId { get; set; }

    /// <summary>
    /// Competency Association Weight
    /// <para>
    /// Indicates the relative significance this connection has for the destination node in a learning map.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20376">Competency Association Weight</a>
    /// </para>
    /// </summary>
    [Comment("Indicates the relative significance this connection has for the destination node in a learning map.")]
    public Decimal? Weight { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual CompetencyDefinitionEntity CompetencyDefinitionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEntityType"/> implementation
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual RefEntityTypeEntity RefEntityTypeEntity { get; set; }

    /// <summary>
    /// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual RefCompetencyDefAssociationTypeEntity? RefCompetencyDefAssociationTypeEntity { get; set; }

    /// <summary>
    /// The alignment relationship between the resource and a competency definition object.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19879">Learning Resource Competency Alignment Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourceCompetencyAlignmentTypeEntity? RefLearningResourceCompetencyAlignmentTypeEntity { get; set; }

    #endregion
}
