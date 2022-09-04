//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationIndicator.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIndicator file
/// </summary>
public partial interface IOrganizationIndicator
{
    #region "IOrganizationIndicator Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String IndicatorValue { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Ability Grouping Status
    /// <para>
    /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
    /// </para>
    /// </summary>
    Guid RefOrganizationIndicatorId { get; set; }

    #endregion
}
