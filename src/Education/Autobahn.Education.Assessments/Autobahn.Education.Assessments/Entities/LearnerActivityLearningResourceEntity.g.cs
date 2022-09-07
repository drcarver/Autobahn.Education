//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerActivityLearningResource file
/// </summary>
[Table("LearnerActivityLearningResource", Schema = "Assessments")]
public partial class LearnerActivityLearningResourceEntity : EntityBase, ILearnerActivityLearningResource
{
    #region "ILearnerActivityLearningResource Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearnerActivity")]
    public Guid LearnerActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearnerActivity"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LearnerActivityEntity LearnerActivityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    #endregion
}
