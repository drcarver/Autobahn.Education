//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramMeetingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeeting file
/// </summary>
[Table("IndividualizedProgramMeeting", Schema = "Invalid")]
public partial class IndividualizedProgramMeetingEntity : EntityBase, IIndividualizedProgramMeeting
{
    #region "IIndividualizedProgramMeeting Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Meeting Date
    /// <para>
    /// The date on which a child's service plan meeting is held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which a child's service plan meeting is held.")]
    public DateTime? MeetingDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
