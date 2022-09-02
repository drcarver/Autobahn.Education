//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationNeglectedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationNeglected file
/// </summary>
[Table("ProgramParticipationNeglected", Schema = "Common")]
public partial class ProgramParticipationNeglectedEntity : EntityBase, IProgramParticipationNeglected
{
    #region "IProgramParticipationNeglected Properties"
    /// <summary>
    /// Neglected or Delinquent Academic Achievement Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Achievement Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.")]
    public Boolean? AchievementIndicator { get; set; }

    /// <summary>
    /// Neglected or Delinquent Obtained Employment
    /// <para>
    /// An indication that a Neglected or Delinquent student obtained employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19475">Neglected or Delinquent Obtained Employment</a>
    /// </para>
    /// </summary>
    [Comment("An indication that a Neglected or Delinquent student obtained employment.")]
    public Boolean? ObtainedEmployment { get; set; }

    /// <summary>
    /// Neglected or Delinquent Academic Outcome Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Outcome Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.")]
    public Boolean? OutcomeIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Neglected or Delinquent Program Type
    /// <para>
    /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefNeglectedProgramType")]
    [Comment("The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).")]
    public Guid? RefNeglectedProgramTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefNeglectedProgramTypeEntity RefNeglectedProgramTypeEntity { get; set; }

    #endregion
}
