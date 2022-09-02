//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonBirthplace file
/// </summary>
public partial class PersonBirthplaceModel : AutobahnBaseModel, IPersonBirthplace
{
    #region "IPersonBirthplace Properties"
    /// <summary>
    /// City of Birth
    /// <para>
    ///  The name of the city in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
    /// </para>
    /// </summary>
    public System.String City { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Country of Birth Code
    /// <para>
    /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
    /// </para>
    /// </summary>
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// State of Birth Abbreviation
    /// <para>
    /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
    /// </para>
    /// </summary>
    public Guid? RefStateId { get; set; }

    #endregion
}
