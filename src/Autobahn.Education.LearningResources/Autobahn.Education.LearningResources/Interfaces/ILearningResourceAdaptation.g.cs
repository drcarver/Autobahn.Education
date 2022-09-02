//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourceAdaptation.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceAdaptation file
/// </summary>
public partial interface ILearningResourceAdaptation
{
    #region "ILearningResourceAdaptation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String AdaptationUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    #endregion
}
