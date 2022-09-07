//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CoreKnowledgeAreaEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICoreKnowledgeArea file
/// </summary>
public partial class CoreKnowledgeAreaModel : AutobahnBaseModel, ICoreKnowledgeArea
{
    #region "ICoreKnowledgeArea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
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
    public Guid RefCoreKnowledgeAreaId { get; set; }

    #endregion
}
