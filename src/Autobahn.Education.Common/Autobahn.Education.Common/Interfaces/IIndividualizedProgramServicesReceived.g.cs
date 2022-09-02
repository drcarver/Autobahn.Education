//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramServicesReceived.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramServicesReceived file
/// </summary>
public partial interface IIndividualizedProgramServicesReceived
{
    #region "IIndividualizedProgramServicesReceived Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
    /// </summary>
    Guid ServicesReceivedId { get; set; }

    #endregion
}
