//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionMarkEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSectionMark file
/// </summary>
public partial class K12studentCourseSectionMarkModel : AutobahnBaseModel, IK12studentCourseSectionMark
{
    #region "IK12studentCourseSectionMark Properties"
    public Boolean? FinalIndicator { get; set; }

    public System.String GradeEarned { get; set; }

    public System.String GradeValueQualifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
    /// </summary>
    public Guid K12studentCourseSectionId { get; set; }

    public System.String MarkingPeriodName { get; set; }

    public System.String MidTermMark { get; set; }

    public System.String StudentCourseSectionGradeNarrative { get; set; }

    #endregion
}
