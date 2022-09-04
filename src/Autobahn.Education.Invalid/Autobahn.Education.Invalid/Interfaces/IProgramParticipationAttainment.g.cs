//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgramParticipationAttainment.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAttainment file
/// </summary>
public partial interface IProgramParticipationAttainment
{
    #region "IProgramParticipationAttainment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? AecredentialAttainmentEmployedIndicator { get; set; }

    Boolean? AecredentialAttainmentPscredentialIndicator { get; set; }

    Boolean? AecredentialAttainmentPsenrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Exit Type
    /// <para>
    /// The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20927">EDFacts Academic or Career and Technical Outcome Exit Type</a>
    /// </para>
    /// </summary>
    Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Type
    /// <para>
    /// The type of academic or career and technical outcome attained while enrolled in the program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20928">EDFacts Academic or Career and Technical Outcome Type</a>
    /// </para>
    /// </summary>
    Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    #endregion
}
