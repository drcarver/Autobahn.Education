//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgram file
/// </summary>
public partial class ProgramModel : AutobahnBaseModel, IProgram
{
    #region "IProgram Properties"
    /// <summary>
    /// Credits Required
    /// <para>
    /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
    /// </para>
    /// </summary>
    public Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion
}
