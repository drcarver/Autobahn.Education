//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonEmailAddress.g.cs
//***************************************************************************

/// <summary>
/// The IPersonEmailAddress file
/// </summary>
public partial interface IPersonEmailAddress
{
    #region "IPersonEmailAddress Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Electronic Mail Address
    /// <para>
    /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
    /// </para>
    /// </summary>
    System.String EmailAddress { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Electronic Mail Address Type
    /// <para>
    /// The type of electronic mail (e-mail) address listed for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19089">Electronic Mail Address Type</a>
    /// </para>
    /// </summary>
    Guid? RefEmailTypeId { get; set; }

    #endregion
}
