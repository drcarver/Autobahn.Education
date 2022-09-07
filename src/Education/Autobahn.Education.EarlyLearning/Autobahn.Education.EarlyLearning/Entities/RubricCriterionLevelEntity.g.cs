//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RubricCriterionLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRubricCriterionLevel file
/// </summary>
[Table("RubricCriterionLevel", Schema = "EarlyLearning")]
public partial class RubricCriterionLevelEntity : EntityBase, IRubricCriterionLevel
{
    #region "IRubricCriterionLevel Properties"
    /// <summary>
    /// Rubric Criterion Level Feedback
    /// <para>
    /// Pre-defined feedback text to be relayed to the person or organization being evaluated.  This may include guidance and suggestions for improvement or development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20444">Rubric Criterion Level Feedback</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Pre-defined feedback text to be relayed to the person or organization being evaluated.  This may include guidance and suggestions for improvement or development.")]
    public System.String Feedback { get; set; }

    /// <summary>
    /// Rubric Criterion Level Position
    /// <para>
    /// A numeric value representing the level's position in the list of levels defined for the Rubric Criterion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20445">Rubric Criterion Level Position</a>
    /// </para>
    /// </summary>
    [Comment("A numeric value representing the level's position in the list of levels defined for the Rubric Criterion.")]
    public Int32? Position { get; set; }

    /// <summary>
    /// Rubric Criterion Level Quality Label
    /// <para>
    /// A qualitative description of this degree of achievement used for column headers or row labels in tabular rubrics.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20446">Rubric Criterion Level Quality Label</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A qualitative description of this degree of achievement used for column headers or row labels in tabular rubrics.")]
    public System.String Quality { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RubricCriterion")]
    public Guid RubricCriterionId { get; set; }

    /// <summary>
    /// Rubric Criterion Level Score
    /// <para>
    /// The points awarded for achieving this level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20447">Rubric Criterion Level Score</a>
    /// </para>
    /// </summary>
    [Comment("The points awarded for achieving this level.")]
    public Decimal? Score { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RubricCriterionEntity RubricCriterionEntity { get; set; }

    #endregion
}
