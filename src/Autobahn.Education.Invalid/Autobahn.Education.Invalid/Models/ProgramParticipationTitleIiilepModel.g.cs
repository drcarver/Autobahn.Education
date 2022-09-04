//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationTitleIiilepEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleIiilep file
/// </summary>
public partial class ProgramParticipationTitleIiilepModel : AutobahnBaseModel, IProgramParticipationTitleIiilep
{
    #region "IProgramParticipationTitleIiilep Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTitleIiiLep"/> model
    /// </summary>
    public Guid ProgramParticipationTitleIiiLepId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiaccountability"/> model
    /// </summary>
    public Guid? RefTitleIiiaccountabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    public Guid? RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion
}
