//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonProgramParticipation file
/// </summary>
[Table("PersonProgramParticipation", Schema = "Common")]
public partial class PersonProgramParticipationEntity : EntityBase, IPersonProgramParticipation
{
    #region "IPersonProgramParticipation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Gifted and Talented Indicator
    /// <para>
    /// An indication that the student is participating in and served by a Gifted/Talented program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19122">Gifted and Talented Indicator</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An indication that the student is participating in and served by a Gifted/Talented program.")]
    public System.String ParticipationStatus { get; set; }

    /// <summary>
    /// GED Preparation Program Participation Status
    /// <para>
    /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefParticipationType")]
    [Comment("An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.")]
    public Guid? RefParticipationTypeId { get; set; }

    /// <summary>
    /// Program Entry Reason
    /// <para>
    /// The documented or assumed reason a person is being served by a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProgramEntryReason")]
    [Comment("The documented or assumed reason a person is being served by a program.")]
    public Guid? RefProgramEntryReasonId { get; set; }

    /// <summary>
    /// Exit Reason
    /// <para>
    /// The documented or assumed reason a student is no longer being served by a special program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProgramExitReason")]
    [Comment("The documented or assumed reason a student is no longer being served by a special program.")]
    public Guid? RefProgramExitReasonId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefParticipationTypeEntity RefParticipationTypeEntity { get; set; }

    /// <summary>
    /// The documented or assumed reason a student is no longer being served by a special program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramExitReasonEntity RefProgramExitReasonEntity { get; set; }

    /// <summary>
    /// The documented or assumed reason a person is being served by a program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramEntryReasonEntity RefProgramEntryReasonEntity { get; set; }

    #endregion
}
