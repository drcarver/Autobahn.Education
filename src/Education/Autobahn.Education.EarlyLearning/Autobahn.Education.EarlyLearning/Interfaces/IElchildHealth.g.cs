//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElchildHealth.g.cs
//***************************************************************************

/// <summary>
/// The IElchildHealth file
/// </summary>
public partial interface IElchildHealth
{
    #region "IElchildHealth Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
    /// </summary>
    Guid? RefScheduledWellChildScreeningId { get; set; }

    DateTime? WellChildScreeningReceivedDate { get; set; }

    #endregion
}
