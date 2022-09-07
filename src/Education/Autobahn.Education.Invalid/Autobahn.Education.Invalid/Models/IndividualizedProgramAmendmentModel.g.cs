//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAmendmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAmendment file
/// </summary>
public partial class IndividualizedProgramAmendmentModel : AutobahnBaseModel, IIndividualizedProgramAmendment
{
    #region "IIndividualizedProgramAmendment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Amendment Reason Description
    /// <para>
    /// Description of the reason changes were made to the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
    /// </para>
    /// </summary>
    public System.String ReasonDescription { get; set; }

    #endregion
}
