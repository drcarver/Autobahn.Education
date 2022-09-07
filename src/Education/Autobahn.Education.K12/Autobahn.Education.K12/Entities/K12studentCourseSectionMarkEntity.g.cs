//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionMarkEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSectionMark file
/// </summary>
[Table("K12studentCourseSectionMark", Schema = "K12")]
public partial class K12studentCourseSectionMarkEntity : EntityBase, IK12studentCourseSectionMark
{
    #region "IK12studentCourseSectionMark Properties"
    public Boolean? FinalIndicator { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeEarned { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeValueQualifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12studentCourseSection")]
    public Guid K12studentCourseSectionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MarkingPeriodName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MidTermMark { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StudentCourseSectionGradeNarrative { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12studentCourseSectionEntity K12studentCourseSectionEntity { get; set; }

    #endregion
}
