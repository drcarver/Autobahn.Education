//***************************************************************************
//* DomainName: Common Models
//* FileName:   CoreKnowledgeAreaEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICoreKnowledgeArea file
/// </summary>
[Table("CoreKnowledgeArea", Schema = "Common")]
public partial class CoreKnowledgeAreaEntity : EntityBase, ICoreKnowledgeArea
{
    #region "ICoreKnowledgeArea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentActivity")]
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Early Learning Core Knowledge Area
    /// <para>
    /// A description of the core knowledge areas addressed by Early Learning professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19812">Early Learning Core Knowledge Area</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefCoreKnowledgeArea")]
    [Comment("A description of the core knowledge areas addressed by Early Learning professional development.")]
    public Guid RefCoreKnowledgeAreaId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentActivityEntity ProfessionalDevelopmentActivityEntity { get; set; }

    /// <summary>
    /// A description of the core knowledge areas addressed by Early Learning professional development.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19812">Early Learning Core Knowledge Area</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCoreKnowledgeAreaEntity RefCoreKnowledgeAreaEntity { get; set; }

    #endregion
}
