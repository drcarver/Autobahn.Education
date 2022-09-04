//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildHealthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildHealth file
/// </summary>
public partial class ElchildHealthModel : AutobahnBaseModel, IElchildHealth
{
    #region "IElchildHealth Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
    /// </summary>
    public Guid? RefScheduledWellChildScreeningId { get; set; }

    public DateTime? WellChildScreeningReceivedDate { get; set; }

    #endregion
}
