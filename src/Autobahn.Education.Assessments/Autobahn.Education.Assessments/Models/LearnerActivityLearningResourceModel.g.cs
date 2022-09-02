//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerActivityLearningResource file
/// </summary>
public partial class LearnerActivityLearningResourceModel : AutobahnBaseModel, ILearnerActivityLearningResource
{
    #region "ILearnerActivityLearningResource Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
    /// </summary>
    public Guid LearnerActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    #endregion
}
