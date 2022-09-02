//***************************************************************************
//* DomainName: Assessments
//* FileName:   ILearnerActivityLearningResource.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerActivityLearningResource file
/// </summary>
public partial interface ILearnerActivityLearningResource
{
    #region "ILearnerActivityLearningResource Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
    /// </summary>
    Guid LearnerActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    #endregion
}
