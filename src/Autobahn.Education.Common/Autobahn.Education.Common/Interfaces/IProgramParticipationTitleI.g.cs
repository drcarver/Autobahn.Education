//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationTitleI.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleI file
/// </summary>
public partial interface IProgramParticipationTitleI
{
    #region "IProgramParticipationTitleI Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    System.Int32 ProgramParticipationTitleIid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIindicator"/> model
    /// </summary>
    Guid? RefTitleIindicatorId { get; set; }

    #endregion
}
