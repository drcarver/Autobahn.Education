//***************************************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRoleAttendanceEvent file
/// </summary>
[Table("RoleAttendanceEvent", Schema = "Common")]
public partial class RoleAttendanceEventEntity : EntityBase, IRoleAttendanceEvent
{
    #region "IRoleAttendanceEvent Properties"
    /// <summary>
    /// Attendance Event Date
    /// <para>
    /// The date on which an attendance event takes place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20630">Attendance Event Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The date on which an attendance event takes place.")]
    public System.DateTime Date { get; set; }

    /// <summary>
    /// End Time
    /// <para>
    /// The ending hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
    /// </para>
    /// </summary>
    [Comment("The ending hour, minute and second.")]
    public TimeSpan? EndTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Absent Attendance Category
    /// <para>
    ///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAbsentAttendanceCategory")]
    [Comment(" The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.")]
    public Guid? RefAbsentAttendanceCategoryId { get; set; }

    /// <summary>
    /// Attendance Event Type
    /// <para>
    /// The type of attendance event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAttendanceEventType")]
    [Comment("The type of attendance event.")]
    public Guid? RefAttendanceEventTypeId { get; set; }

    /// <summary>
    /// Attendance Status
    /// <para>
    /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAttendanceStatus")]
    [Comment("The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.")]
    public Guid? RefAttendanceStatusId { get; set; }

    /// <summary>
    /// Leave Event Type
    /// <para>
    /// The type of the leave event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLeaveEventType")]
    [Comment("The type of the leave event.")]
    public Guid? RefLeaveEventTypeId { get; set; }

    /// <summary>
    /// Present Attendance Category
    /// <para>
    /// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPresentAttendanceCategory")]
    [Comment("The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.")]
    public Guid? RefPresentAttendanceCategoryId { get; set; }

    /// <summary>
    /// Start Time
    /// <para>
    /// The starting hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
    /// </para>
    /// </summary>
    [Comment("The starting hour, minute and second.")]
    public TimeSpan? StartTime { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of attendance event.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAttendanceEventTypeEntity RefAttendanceEventTypeEntity { get; set; }

    /// <summary>
    /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAttendanceStatusEntity RefAttendanceStatusEntity { get; set; }

    /// <summary>
    ///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAbsentAttendanceCategoryEntity RefAbsentAttendanceCategoryEntity { get; set; }

    /// <summary>
    /// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPresentAttendanceCategoryEntity RefPresentAttendanceCategoryEntity { get; set; }

    /// <summary>
    /// The type of the leave event.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefLeaveEventTypeEntity RefLeaveEventTypeEntity { get; set; }

    #endregion
}
