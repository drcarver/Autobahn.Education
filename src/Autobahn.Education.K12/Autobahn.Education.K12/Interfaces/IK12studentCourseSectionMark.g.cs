//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentCourseSectionMark.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSectionMark file
/// </summary>
public partial interface IK12studentCourseSectionMark
{
    #region "IK12studentCourseSectionMark Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? FinalIndicator { get; set; }

    System.String GradeEarned { get; set; }

    System.String GradeValueQualifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
    /// </summary>
    Guid K12studentCourseSectionId { get; set; }

    System.String MarkingPeriodName { get; set; }

    System.String MidTermMark { get; set; }

    System.String StudentCourseSectionGradeNarrative { get; set; }

    #endregion
}
