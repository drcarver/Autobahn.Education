//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediumEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedium file
/// </summary>
public partial class LearningResourcePhysicalMediumModel : AutobahnBaseModel, ILearningResourcePhysicalMedium
{
    #region "ILearningResourcePhysicalMedium Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
    /// </summary>
    public Guid LearningResourcePhysicalMediaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
    /// </summary>
    public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion
}
