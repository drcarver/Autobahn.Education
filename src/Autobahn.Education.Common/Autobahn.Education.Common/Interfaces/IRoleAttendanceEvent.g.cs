//***************************************************************************
//* DomainName: Common Models
//* FileName:   IRoleAttendanceEvent.g.cs
//***************************************************************************

/// <summary>
/// The IRoleAttendanceEvent file
/// </summary>
public partial interface IRoleAttendanceEvent
{
    #region "IRoleAttendanceEvent Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Attendance Event Date
    /// <para>
    /// The date on which an attendance event takes place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20630">Attendance Event Date</a>
    /// </para>
    /// </summary>
    System.DateTime Date { get; set; }

    /// <summary>
    /// End Time
    /// <para>
    /// The ending hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
    /// </para>
    /// </summary>
    TimeSpan? EndTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Absent Attendance Category
    /// <para>
    ///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
    /// </para>
    /// </summary>
    Guid? RefAbsentAttendanceCategoryId { get; set; }

    /// <summary>
    /// Attendance Event Type
    /// <para>
    /// The type of attendance event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
    /// </para>
    /// </summary>
    Guid? RefAttendanceEventTypeId { get; set; }

    /// <summary>
    /// Attendance Status
    /// <para>
    /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
    /// </para>
    /// </summary>
    Guid? RefAttendanceStatusId { get; set; }

    /// <summary>
    /// Leave Event Type
    /// <para>
    /// The type of the leave event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
    /// </para>
    /// </summary>
    Guid? RefLeaveEventTypeId { get; set; }

    /// <summary>
    /// Present Attendance Category
    /// <para>
    /// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
    /// </para>
    /// </summary>
    Guid? RefPresentAttendanceCategoryId { get; set; }

    /// <summary>
    /// Start Time
    /// <para>
    /// The starting hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
    /// </para>
    /// </summary>
    TimeSpan? StartTime { get; set; }

    #endregion
}
