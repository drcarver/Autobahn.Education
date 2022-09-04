//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionScheduleEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionSchedule file
/// </summary>
public partial class CourseSectionScheduleModel : AutobahnBaseModel, ICourseSectionSchedule
{
    #region "ICourseSectionSchedule Properties"
    /// <summary>
    /// Class Beginning Time
    /// <para>
    /// An indication of the time of day the class begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? ClassBeginningTime { get; set; }

    /// <summary>
    /// Class Ending Time
    /// <para>
    /// An indication of the time of day the class ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19511">Class Ending Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? ClassEndingTime { get; set; }

    /// <summary>
    /// Class Meeting Days
    /// <para>
    /// The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets "out-of-school" or "self-paced".
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19512">Class Meeting Days</a>
    /// </para>
    /// </summary>
    public System.String ClassMeetingDays { get; set; }

    /// <summary>
    /// Class Period
    /// <para>
    /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19513">Class Period</a>
    /// </para>
    /// </summary>
    public System.String ClassPeriod { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Timetable Day Identifier
    /// <para>
    /// The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be "A" and "B", or "1" and "2").
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19514">Timetable Day Identifier</a>
    /// </para>
    /// </summary>
    public System.String TimeDayIdentifier { get; set; }

    #endregion
}
