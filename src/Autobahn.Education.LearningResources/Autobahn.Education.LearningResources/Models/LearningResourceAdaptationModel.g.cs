//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceAdaptation file
/// </summary>
public partial class LearningResourceAdaptationModel : AutobahnBaseModel, ILearningResourceAdaptation
{
    #region "ILearningResourceAdaptation Properties"
    public System.String AdaptationUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    #endregion
}
