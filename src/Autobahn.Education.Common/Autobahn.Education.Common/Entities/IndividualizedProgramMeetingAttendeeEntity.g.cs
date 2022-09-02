//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingAttendeeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeetingAttendee file
/// </summary>
[Table("IndividualizedProgramMeetingAttendee", Schema = "Common")]
public partial class IndividualizedProgramMeetingAttendeeEntity : EntityBase, IIndividualizedProgramMeetingAttendee
{
    #region "IIndividualizedProgramMeetingAttendee Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramMeeting"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramMeeting")]
    public Guid IndividualizedProgramMeetingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramMeeting"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramMeetingEntity IndividualizedProgramMeetingEntity { get; set; }

    #endregion
}
