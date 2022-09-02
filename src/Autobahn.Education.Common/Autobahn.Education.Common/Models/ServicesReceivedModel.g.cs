//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServicesReceivedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServicesReceived file
/// </summary>
public partial class ServicesReceivedModel : AutobahnBaseModel, IServicesReceived
{
    #region "IServicesReceived Properties"
    /// <summary>
    /// Special Education Full Time Equivalency
    /// <para>
    /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
    /// </para>
    /// </summary>
    public Decimal? FullTimeEquivalency { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    public Guid ServicePlanId { get; set; }

    #endregion
}
