//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAttainment file
/// </summary>
public partial class ProgramParticipationAttainmentModel : AutobahnBaseModel, IProgramParticipationAttainment
{
    #region "IProgramParticipationAttainment Properties"
    public Boolean? AecredentialAttainmentEmployedIndicator { get; set; }

    public Boolean? AecredentialAttainmentPscredentialIndicator { get; set; }

    public Boolean? AecredentialAttainmentPsenrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Exit Type
    /// <para>
    /// The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20927">EDFacts Academic or Career and Technical Outcome Exit Type</a>
    /// </para>
    /// </summary>
    public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

    /// <summary>
    /// EDFacts Academic or Career and Technical Outcome Type
    /// <para>
    /// The type of academic or career and technical outcome attained while enrolled in the program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20928">EDFacts Academic or Career and Technical Outcome Type</a>
    /// </para>
    /// </summary>
    public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

    #endregion
}
