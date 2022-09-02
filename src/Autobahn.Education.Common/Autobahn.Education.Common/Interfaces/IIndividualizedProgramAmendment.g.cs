//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramAmendment.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAmendment file
/// </summary>
public partial interface IIndividualizedProgramAmendment
{
    #region "IIndividualizedProgramAmendment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Amendment Reason Description
    /// <para>
    /// Description of the reason changes were made to the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
    /// </para>
    /// </summary>
    System.String ReasonDescription { get; set; }

    #endregion
}
