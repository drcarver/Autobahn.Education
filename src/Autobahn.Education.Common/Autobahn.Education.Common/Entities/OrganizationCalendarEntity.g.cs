//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendar file
/// </summary>
[Table("OrganizationCalendar", Schema = "Common")]
public partial class OrganizationCalendarEntity : EntityBase, IOrganizationCalendar
{
    #region "IOrganizationCalendar Properties"
    /// <summary>
    /// Calendar Code
    /// <para>
    /// A unique number assigned by a school district to a school calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number assigned by a school district to a school calendar.")]
    public System.String CalendarCode { get; set; }

    /// <summary>
    /// Calendar Description
    /// <para>
    /// A description or identification of the calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description or identification of the calendar.")]
    public System.String CalendarDescription { get; set; }

    /// <summary>
    /// School Year
    /// <para>
    /// The year for a reported school session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year for a reported school session.")]
    public System.String CalendarYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
