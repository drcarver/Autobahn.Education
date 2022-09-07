//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   CourseSectionLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionLevel file
/// </summary>
[Table("CourseSectionLevel", Schema = "EarlyLearning")]
public partial class CourseSectionLevelEntity : EntityBase, ICourseSectionLevel
{
    #region "ICourseSectionLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CourseSection")]
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Course Level Type
    /// <para>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefCourseLevelType")]
    [Comment("The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.")]
    public Guid RefCourseLevelTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity CourseSectionEntity { get; set; }

    /// <summary>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseLevelTypeEntity RefCourseLevelTypeEntity { get; set; }

    #endregion
}
