//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ICourseSectionLevel.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionLevel file
/// </summary>
public partial interface ICourseSectionLevel
{
    #region "ICourseSectionLevel Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    Guid CourseSectionId { get; set; }

    /// <summary>
    /// Course Level Type
    /// <para>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// </summary>
    Guid RefCourseLevelTypeId { get; set; }

    #endregion
}
