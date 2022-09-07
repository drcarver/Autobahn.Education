//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgramParticipationNeglected.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationNeglected file
/// </summary>
public partial interface IProgramParticipationNeglected
{
    #region "IProgramParticipationNeglected Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Neglected or Delinquent Academic Achievement Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Achievement Indicator</a>
    /// </para>
    /// </summary>
    Boolean? AchievementIndicator { get; set; }

    /// <summary>
    /// Neglected or Delinquent Obtained Employment
    /// <para>
    /// An indication that a Neglected or Delinquent student obtained employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19475">Neglected or Delinquent Obtained Employment</a>
    /// </para>
    /// </summary>
    Boolean? ObtainedEmployment { get; set; }

    /// <summary>
    /// Neglected or Delinquent Academic Outcome Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Outcome Indicator</a>
    /// </para>
    /// </summary>
    Boolean? OutcomeIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Neglected or Delinquent Program Type
    /// <para>
    /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
    /// </para>
    /// </summary>
    Guid? RefNeglectedProgramTypeId { get; set; }

    #endregion
}
