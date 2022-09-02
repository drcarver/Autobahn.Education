//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationCte file
/// </summary>
[Table("ProgramParticipationCte", Schema = "CTE")]
public partial class ProgramParticipationCteEntity : EntityBase, IProgramParticipationCte
{
    #region "IProgramParticipationCte Properties"
    /// <summary>
    /// Career Pathways Program Participation Exit Date
    /// <para>
    /// The year, month and day on which the person ceased to participate in a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20562">Career Pathways Program Participation Exit Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the person ceased to participate in a program.")]
    public DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

    /// <summary>
    /// Career Pathways Program Participation Start Date
    /// <para>
    /// The year, month and day on which the person began to participate in a career pathway program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20563">Career Pathways Program Participation Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which the person began to participate in a career pathway program.")]
    public DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

    /// <summary>
    /// Career and Technical Education Completer
    /// <para>
    /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19036">Career and Technical Education Completer</a>
    /// </para>
    /// </summary>
    [Comment("An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.")]
    public Boolean? CteCompleter { get; set; }

    /// <summary>
    /// Career and Technical Education Concentrator
    /// <para>
    /// An indication of a student who has met the state-defined threshold of career and technical education concentrators, as defined in the State's approved Perkins IV State Plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19037">Career and Technical Education Concentrator</a>
    /// </para>
    /// </summary>
    [Comment("An indication of a student who has met the state-defined threshold of career and technical education concentrators, as defined in the State's approved Perkins IV State Plan.")]
    public Boolean? CteConcentrator { get; set; }

    /// <summary>
    /// Career and Technical Education Nontraditional Completion
    /// <para>
    /// An indication that the CTE student has completed a CTE program in a nontraditional field (where one gender comprises less than 25 percent of the persons employed in those occupations or fields of work).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19586">Career and Technical Education Nontraditional Completion</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the CTE student has completed a CTE program in a nontraditional field (where one gender comprises less than 25 percent of the persons employed in those occupations or fields of work).")]
    public Boolean? CteNonTraditionalCompletion { get; set; }

    /// <summary>
    /// Career and Technical Education Participant
    /// <para>
    /// An indication a student has met the state-defined threshold of Career and Technical Education participation as defined in the State's approved Perkins IV State Plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19585">Career and Technical Education Participant</a>
    /// </para>
    /// </summary>
    [Comment("An indication a student has met the state-defined threshold of Career and Technical Education participation as defined in the State's approved Perkins IV State Plan.")]
    public Boolean? CteParticipant { get; set; }

    /// <summary>
    /// Career-Technical-Adult Education Displaced Homemaker Indicator
    /// <para>
    /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19084">Career-Technical-Adult Education Displaced Homemaker Indicator</a>
    /// </para>
    /// </summary>
    [Comment("A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.")]
    public Boolean? DisplacedHomemakerIndicator { get; set; }

    /// <summary>
    /// Out of Workforce Indicator
    /// <para>
    /// An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20908">Out of Workforce Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An individual: (A) who is a displaced homemaker, as defined in section 3 of the Workforce Innovation and Opportunity Act (29 U.S.C. 3102); or (B) who (i)(I) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills; or (II) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (ii) is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.")]
    public Boolean? OutOfWorkforceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Career Technical Education Nontraditional Gender Status
    /// <para>
    /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefNonTraditionalGenderStatus")]
    [Comment("An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).")]
    public Guid? RefNonTraditionalGenderStatusId { get; set; }

    /// <summary>
    /// Work-based Learning Opportunity Type
    /// <para>
    /// The type of work-based learning opportunity a student participated in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefWorkbasedLearningOpportunityType")]
    [Comment("The type of work-based learning opportunity a student participated in.")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    /// <summary>
    /// Single Parent or Single Pregnant Woman Status
    /// <para>
    /// A student who, at some time during the school year, is either a pregnant female student who is unmarried; or a male or female student who is unmarried or legally separated from a spouse and has a minor child or children.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19573">Single Parent or Single Pregnant Woman Status</a>
    /// </para>
    /// </summary>
    [Comment("A student who, at some time during the school year, is either a pregnant female student who is unmarried; or a male or female student who is unmarried or legally separated from a spouse and has a minor child or children.")]
    public Boolean? SingleParentOrSinglePregnantWoman { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the CTE domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the CTE domain
    /// </remarks>
    /// </summary>
    public virtual RefNonTraditionalGenderStatusEntity RefNonTraditionalGenderStatusEntity { get; set; }

    /// <summary>
    /// The type of work-based learning opportunity a student participated in.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the CTE domain
    /// </remarks>
    /// </summary>
    public virtual RefWorkbasedLearningOpportunityTypeEntity RefWorkbasedLearningOpportunityTypeEntity { get; set; }

    #endregion
}
