//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   CourseSectionLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionLevel file
/// </summary>
public partial class CourseSectionLevelModel : AutobahnBaseModel, ICourseSectionLevel
{
    #region "ICourseSectionLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
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
    public Guid RefCourseLevelTypeId { get; set; }

    #endregion
}
