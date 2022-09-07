//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   IAeProvider.g.cs
//***************************************************************************

/// <summary>
/// The IAeProvider file
/// </summary>
public partial interface IAeProvider
{
    #region "IAeProvider Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Level of Institution
    /// <para>
    /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
    /// </para>
    /// </summary>
    Guid RefLevelOfInstitutionId { get; set; }

    #endregion
}
