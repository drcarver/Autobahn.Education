//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourceMediaFeature.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceMediaFeature file
/// </summary>
public partial interface ILearningResourceMediaFeature
{
    #region "ILearningResourceMediaFeature Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Media Feature Type
    /// <para>
    /// Accessible content features included with the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
    /// </para>
    /// </summary>
    Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    #endregion
}
