//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramService file
/// </summary>
public partial class IndividualizedProgramServiceModel : AutobahnBaseModel, IIndividualizedProgramService
{
    #region "IIndividualizedProgramService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Duration
    /// <para>
    /// The length, in hours, that delivery of the service is planned.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20493">Individualized Program Planned Service Duration</a>
    /// </para>
    /// </summary>
    public Decimal? PlannedServiceDuration { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Start Date
    /// <para>
    /// The date the service is planned to begin.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
    /// </para>
    /// </summary>
    public DateTime? PlannedServiceStartDate { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Type
    /// <para>
    /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing special education because of a delay or disability.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20352">Individualized Program Planned Service Type</a>
    /// </para>
    /// </summary>
    public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

    /// <summary>
    /// Method of Service Delivery
    /// <para>
    /// The method by which the services will be provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20482">Method of Service Delivery</a>
    /// </para>
    /// </summary>
    public Guid? RefMethodOfServiceDeliveryId { get; set; }

    /// <summary>
    /// Individualized Program Planned Service Frequency
    /// <para>
    /// The frequency that a service is planned to be provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20492">Individualized Program Planned Service Frequency</a>
    /// </para>
    /// </summary>
    public Guid? RefServiceFrequencyId { get; set; }

    #endregion
}
