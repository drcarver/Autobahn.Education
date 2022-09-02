//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationWioa.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioa file
/// </summary>
public partial interface IProgramParticipationWioa
{
    #region "IProgramParticipationWioa Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    System.Int32 ProgramParticipationWioaid { get; set; }

    Boolean? WioacareerServices { get; set; }

    Boolean? WioatrainingServices { get; set; }

    #endregion
}
