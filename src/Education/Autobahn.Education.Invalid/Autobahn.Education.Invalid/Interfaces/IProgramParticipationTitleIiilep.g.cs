//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgramParticipationTitleIiilep.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleIiilep file
/// </summary>
public partial interface IProgramParticipationTitleIiilep
{
    #region "IProgramParticipationTitleIiilep Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTitleIiiLep"/> model
    /// </summary>
    Guid ProgramParticipationTitleIiiLepId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiaccountability"/> model
    /// </summary>
    Guid? RefTitleIiiaccountabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    Guid? RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion
}
