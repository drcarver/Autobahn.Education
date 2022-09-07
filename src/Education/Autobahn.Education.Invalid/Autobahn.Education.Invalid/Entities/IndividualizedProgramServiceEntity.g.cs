//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramService file
/// </summary>
[Table("IndividualizedProgramService", Schema = "Invalid")]
public partial class IndividualizedProgramServiceEntity : EntityBase, IIndividualizedProgramService
{
    #region "IIndividualizedProgramService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
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
    [Comment("The length, in hours, that delivery of the service is planned.")]
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
    [Comment("The date the service is planned to begin.")]
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
    [ForeignKey("RefIndividualizedProgramPlannedServiceType")]
    [Comment("The types of service that adapts the curriculum, materials, or instruction for students identified as needing special education because of a delay or disability.")]
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
    [ForeignKey("RefMethodOfServiceDelivery")]
    [Comment("The method by which the services will be provided.")]
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
    [ForeignKey("RefServiceFrequency")]
    [Comment("The frequency that a service is planned to be provided.")]
    public Guid? RefServiceFrequencyId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing special education because of a delay or disability.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20352">Individualized Program Planned Service Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefIndividualizedProgramPlannedServiceTypeEntity? RefIndividualizedProgramPlannedServiceTypeEntity { get; set; }

    /// <summary>
    /// The method by which the services will be provided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20482">Method of Service Delivery</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefMethodOfServiceDeliveryEntity? RefMethodOfServiceDeliveryEntity { get; set; }

    /// <summary>
    /// The frequency that a service is planned to be provided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20492">Individualized Program Planned Service Frequency</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefServiceFrequencyEntity? RefServiceFrequencyEntity { get; set; }

    #endregion
}
