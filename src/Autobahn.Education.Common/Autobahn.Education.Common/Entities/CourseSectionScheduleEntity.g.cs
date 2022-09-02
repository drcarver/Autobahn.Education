//***************************************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionScheduleEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionSchedule file
/// </summary>
[Table("CourseSectionSchedule", Schema = "Common")]
public partial class CourseSectionScheduleEntity : EntityBase, ICourseSectionSchedule
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
    [Comment("An indication of the time of day the class begins.")]
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
    [Comment("An indication of the time of day the class ends.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets \u0022out-of-school\u0022 or \u0022self-paced\u0022.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).")]
    public System.String ClassPeriod { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CourseSection")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be \u0022A\u0022 and \u0022B\u0022, or \u00221\u0022 and \u00222\u0022).")]
    public System.String TimeDayIdentifier { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity CourseSectionEntity { get; set; }

    #endregion
}
