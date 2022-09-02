//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServicesReceivedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServicesReceived file
/// </summary>
[Table("ServicesReceived", Schema = "Common")]
public partial class ServicesReceivedEntity : EntityBase, IServicesReceived
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
    [Comment("Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.")]
    public Decimal? FullTimeEquivalency { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ServicePlan")]
    public Guid ServicePlanId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ServicePlanEntity ServicePlanEntity { get; set; }

    #endregion
}
