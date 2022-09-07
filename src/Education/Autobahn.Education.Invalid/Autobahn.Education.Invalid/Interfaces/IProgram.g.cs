//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgram.g.cs
//***************************************************************************

/// <summary>
/// The IProgram file
/// </summary>
public partial interface IProgram
{
    #region "IProgram Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Credits Required
    /// <para>
    /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
    /// </para>
    /// </summary>
    Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    #endregion
}
