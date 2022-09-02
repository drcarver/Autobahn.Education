//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedia file
/// </summary>
public partial class LearningResourcePhysicalMediaModel : AutobahnBaseModel, ILearningResourcePhysicalMedia
{
    #region "ILearningResourcePhysicalMedia Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Physical Media Type
    /// <para>
    /// A type of physical media on which the Learning Resource is delivered or available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
    /// </para>
    /// </summary>
    public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion
}
