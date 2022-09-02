//***************************************************************************
//* DomainName: Common Models
//* FileName:   IFinancialAidApplication.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAidApplication file
/// </summary>
public partial interface IFinancialAidApplication
{
    #region "IFinancialAidApplication Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Financial Aid Year Designator
    /// <para>
    /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
    /// </para>
    /// </summary>
    System.String FinancialAidYearDesignator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Financial Aid Application Type
    /// <para>
    /// The type of financial application completed by an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
    /// </para>
    /// </summary>
    Guid RefFinancialAidApplicationTypeId { get; set; }

    #endregion
}
