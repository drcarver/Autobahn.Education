//***************************************************************************
//* DomainName: Common Models
//* FileName:   ICourseSectionSchedule.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionSchedule file
/// </summary>
public partial interface ICourseSectionSchedule
{
    #region "ICourseSectionSchedule Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Class Beginning Time
    /// <para>
    /// An indication of the time of day the class begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
    /// </para>
    /// </summary>
    TimeSpan? ClassBeginningTime { get; set; }

    /// <summary>
    /// Class Ending Time
    /// <para>
    /// An indication of the time of day the class ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19511">Class Ending Time</a>
    /// </para>
    /// </summary>
    TimeSpan? ClassEndingTime { get; set; }

    /// <summary>
    /// Class Meeting Days
    /// <para>
    /// The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets "out-of-school" or "self-paced".
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19512">Class Meeting Days</a>
    /// </para>
    /// </summary>
    System.String ClassMeetingDays { get; set; }

    /// <summary>
    /// Class Period
    /// <para>
    /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19513">Class Period</a>
    /// </para>
    /// </summary>
    System.String ClassPeriod { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    Guid CourseSectionId { get; set; }

    /// <summary>
    /// Timetable Day Identifier
    /// <para>
    /// The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be "A" and "B", or "1" and "2").
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19514">Timetable Day Identifier</a>
    /// </para>
    /// </summary>
    System.String TimeDayIdentifier { get; set; }

    #endregion
}
