//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceMediaFeature file
/// </summary>
public partial class LearningResourceMediaFeatureModel : AutobahnBaseModel, ILearningResourceMediaFeature
{
    #region "ILearningResourceMediaFeature Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Media Feature Type
    /// <para>
    /// Accessible content features included with the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
    /// </para>
    /// </summary>
    public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    #endregion
}
