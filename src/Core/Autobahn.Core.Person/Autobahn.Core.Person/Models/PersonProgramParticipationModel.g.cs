//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonProgramParticipationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonProgramParticipation file
/// </summary>
public partial class PersonProgramParticipationModel : AutobahnBaseModel, IPersonProgramParticipation
{
    #region "IPersonProgramParticipation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public Guid? RefProgramExitReasonId { get; set; }

    #endregion
}
