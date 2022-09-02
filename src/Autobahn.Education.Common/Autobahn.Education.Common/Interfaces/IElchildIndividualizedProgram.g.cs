//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildIndividualizedProgram.g.cs
//***************************************************************************

/// <summary>
/// The IElchildIndividualizedProgram file
/// </summary>
public partial interface IElchildIndividualizedProgram
{
    #region "IElchildIndividualizedProgram Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid? IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Refeaiepstatus"/> model
    /// </summary>
    Guid? RefIdeaiepstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeapartCeligibilityCategory"/> model
    /// </summary>
    Guid? RefIdeapartCeligibilityCategoryId { get; set; }

    #endregion
}
