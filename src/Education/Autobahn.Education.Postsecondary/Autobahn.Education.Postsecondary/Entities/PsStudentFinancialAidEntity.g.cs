//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentFinancialAid file
/// </summary>
[Table("PsStudentFinancialAid", Schema = "Postsecondary")]
public partial class PsStudentFinancialAidEntity : EntityBase, IPsStudentFinancialAid
{
    #region "IPsStudentFinancialAid Properties"
    /// <summary>
    /// Financial Aid Applicant
    /// <para>
    /// Any applicant who submits any one of the institutionally required financial aid applications/forms, such as the  Free Application for Federal Student Aid (FAFSA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19745">Financial Aid Applicant</a>
    /// </para>
    /// </summary>
    [Comment("Any applicant who submits any one of the institutionally required financial aid applications/forms, such as the  Free Application for Federal Student Aid (FAFSA).")]
    public Boolean? FinancialAidApplicant { get; set; }

    /// <summary>
    /// Financial Aid Income Level
    /// <para>
    /// The income level of an individual that is used by an institution's financial aid office to determine an individual's Expected Family Contribution (EFC).  For dependent students this will include the parents' adjusted gross income and the student's adjusted gross income.  For independent students this will include the student's adjusted gross income.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20319">Financial Aid Income Level</a>
    /// </para>
    /// </summary>
    [Comment("The income level of an individual that is used by an institution's financial aid office to determine an individual's Expected Family Contribution (EFC).  For dependent students this will include the parents' adjusted gross income and the student's adjusted gross income.  For independent students this will include the student's adjusted gross income.")]
    public Decimal? FinancialAidIncomeLevel { get; set; }

    /// <summary>
    /// Financial Need
    /// <para>
    /// The amount of financial need as determined by an institution using the federal methodology and/or your institution's own standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19747">Financial Need</a>
    /// </para>
    /// </summary>
    [Comment("The amount of financial need as determined by an institution using the federal methodology and/or your institution's own standards.")]
    public Decimal? FinancialNeed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Veteran's Benefit Status
    /// <para>
    /// An indication of whether a person is receiving Veteran's benefits.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20588">Financial Aid Veteran's Benefit Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFinancialAidVeteransBenefitStatus")]
    [Comment("An indication of whether a person is receiving Veteran's benefits.")]
    public Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

    /// <summary>
    /// Financial Aid Veteran's Benefit Type
    /// <para>
    /// The type of Veteran's benefits a person is receiving.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20589">Financial Aid Veteran's Benefit Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFinancialAidVeteransBenefitType")]
    [Comment("The type of Veteran's benefits a person is receiving.")]
    public Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

    /// <summary>
    /// Financial Need Determination Methodology
    /// <para>
    /// The methodology used to determine an individual's financial need.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20188">Financial Need Determination Methodology</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefNeedDeterminationMethod")]
    [Comment("The methodology used to determine an individual's financial need.")]
    public Guid? RefNeedDeterminationMethodId { get; set; }

    public Boolean? TitleIvparticipantAndRecipient { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The methodology used to determine an individual's financial need.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20188">Financial Need Determination Methodology</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefNeedDeterminationMethodEntity? RefNeedDeterminationMethodEntity { get; set; }

    /// <summary>
    /// An indication of whether a person is receiving Veteran's benefits.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20588">Financial Aid Veteran's Benefit Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAidVeteransBenefitStatusEntity? RefFinancialAidVeteransBenefitStatusEntity { get; set; }

    /// <summary>
    /// The type of Veteran's benefits a person is receiving.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20589">Financial Aid Veteran's Benefit Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAidVeteransBenefitTypeEntity? RefFinancialAidVeteransBenefitTypeEntity { get; set; }

    #endregion
}
