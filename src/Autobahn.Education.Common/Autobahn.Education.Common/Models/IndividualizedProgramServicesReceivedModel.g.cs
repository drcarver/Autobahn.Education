//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServicesReceivedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramServicesReceived file
/// </summary>
public partial class IndividualizedProgramServicesReceivedModel : AutobahnBaseModel, IIndividualizedProgramServicesReceived
{
    #region "IIndividualizedProgramServicesReceived Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
    /// </summary>
    public Guid ServicesReceivedId { get; set; }

    #endregion
}
