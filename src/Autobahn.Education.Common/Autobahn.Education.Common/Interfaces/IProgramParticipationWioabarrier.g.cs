//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationWioabarrier.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioabarrier file
/// </summary>
public partial interface IProgramParticipationWioabarrier
{
    #region "IProgramParticipationWioabarrier Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationWioabarriers"/> model
    /// </summary>
    Guid ProgramParticipationWioabarriersId { get; set; }

    System.Int32 ProgramParticipationWioaid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWioabarrierstoEmployment"/> model
    /// </summary>
    Guid? RefWioabarrierstoEmploymentId { get; set; }

    #endregion
}
