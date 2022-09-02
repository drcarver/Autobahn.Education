//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAttainment file
/// </summary>
[Table("ProgramParticipationAttainment", Schema = "Common")]
public partial class ProgramParticipationAttainmentEntity : EntityBase, IProgramParticipationAttainment
{
    #region "IProgramParticipationAttainment Properties"
    public Boolean? AecredentialAttainmentEmployedIndicator { get; set; }

    public Boolean? AecredentialAttainmentPscredentialIndicator { get; set; }

    public Boolean? AecredentialAttainmentPsenrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
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
    [ForeignKey("RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType")]
    [Comment("The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.")]
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
    [ForeignKey("RefEdFactsAcademicOrCareerAndTechnicalOutcomeType")]
    [Comment("The type of academic or career and technical outcome attained while enrolled in the program.")]
    public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

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
    /// The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20927">EDFacts Academic or Career and Technical Outcome Exit Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeEntity RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeEntity { get; set; }

    /// <summary>
    /// The type of academic or career and technical outcome attained while enrolled in the program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20928">EDFacts Academic or Career and Technical Outcome Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeEntity RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeEntity { get; set; }

    #endregion
}
