//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServicesReceivedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramServicesReceived file
/// </summary>
[Table("IndividualizedProgramServicesReceived", Schema = "Common")]
public partial class IndividualizedProgramServicesReceivedEntity : EntityBase, IIndividualizedProgramServicesReceived
{
    #region "IIndividualizedProgramServicesReceived Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ServicesReceived")]
    public Guid ServicesReceivedId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ServicesReceivedEntity ServicesReceivedEntity { get; set; }

    #endregion
}
