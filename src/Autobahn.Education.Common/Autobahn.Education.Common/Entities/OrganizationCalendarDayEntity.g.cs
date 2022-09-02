//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarDay file
/// </summary>
[Table("OrganizationCalendarDay", Schema = "Common")]
public partial class OrganizationCalendarDayEntity : EntityBase, IOrganizationCalendarDay
{
    #region "IOrganizationCalendarDay Properties"
    /// <summary>
    /// Alternate Day Name
    /// <para>
    /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).")]
    public System.String AlternateDayName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DayName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationCalendar")]
    public Guid OrganizationCalendarId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarEntity OrganizationCalendarEntity { get; set; }

    #endregion
}
