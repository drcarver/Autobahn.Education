//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentFinancialAid file
/// </summary>
public partial class PsStudentFinancialAidModel : AutobahnBaseModel, IPsStudentFinancialAid
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
    public Decimal? FinancialNeed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public Guid? RefNeedDeterminationMethodId { get; set; }

    public Boolean? TitleIvparticipantAndRecipient { get; set; }

    #endregion
}
