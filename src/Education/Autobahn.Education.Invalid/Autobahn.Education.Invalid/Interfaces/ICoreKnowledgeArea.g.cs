//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ICoreKnowledgeArea.g.cs
//***************************************************************************

/// <summary>
/// The ICoreKnowledgeArea file
/// </summary>
public partial interface ICoreKnowledgeArea
{
    #region "ICoreKnowledgeArea Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Early Learning Core Knowledge Area
    /// <para>
    /// A description of the core knowledge areas addressed by Early Learning professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19812">Early Learning Core Knowledge Area</a>
    /// </para>
    /// </summary>
    Guid RefCoreKnowledgeAreaId { get; set; }

    #endregion
}
