//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourcePhysicalMedia.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedia file
/// </summary>
public partial interface ILearningResourcePhysicalMedia
{
    #region "ILearningResourcePhysicalMedia Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Physical Media Type
    /// <para>
    /// A type of physical media on which the Learning Resource is delivered or available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
    /// </para>
    /// </summary>
    Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion
}
