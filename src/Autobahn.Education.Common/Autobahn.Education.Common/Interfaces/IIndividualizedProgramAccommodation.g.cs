//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramAccommodation.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodation file
/// </summary>
public partial interface IIndividualizedProgramAccommodation
{
    #region "IIndividualizedProgramAccommodation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Individualized Program Accommodation Applicability
    /// <para>
    /// Circumstances in which the accommodation or change to standards or practices will be applied.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
    /// </para>
    /// </summary>
    System.String Applicability { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    Guid? RefAccommodationTypeId { get; set; }

    #endregion
}
