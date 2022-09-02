//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourcePhysicalMedium.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedium file
/// </summary>
public partial interface ILearningResourcePhysicalMedium
{
    #region "ILearningResourcePhysicalMedium Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
    /// </summary>
    Guid LearningResourcePhysicalMediaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
    /// </summary>
    Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion
}
