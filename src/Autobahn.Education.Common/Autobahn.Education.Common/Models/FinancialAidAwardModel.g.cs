//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidAwardEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAidAward file
/// </summary>
public partial class FinancialAidAwardModel : AutobahnBaseModel, IFinancialAidAward
{
    #region "IFinancialAidAward Properties"
    /// <summary>
    /// Financial Aid Award Amount
    /// <para>
    /// The amount of financial aid awarded to a person for the term/year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19112">Financial Aid Award Amount</a>
    /// </para>
    /// </summary>
    public Decimal? FinancialAidAwardAmount { get; set; }

    /// <summary>
    /// Financial Aid Year Designator
    /// <para>
    /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
    /// </para>
    /// </summary>
    public System.String FinancialAidYearDesignator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Award Type
    /// <para>
    /// The classification of financial aid awarded to a person for the academic term/year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19113">Financial Aid Award Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFinancialAidAwardTypeId { get; set; }

    /// <summary>
    /// Financial Aid Award Status
    /// <para>
    /// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19362">Financial Aid Award Status</a>
    /// </para>
    /// </summary>
    public Guid? RefFinancialAidStatusId { get; set; }

    #endregion
}
