//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationPopulationServed.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPopulationServed file
/// </summary>
public partial interface IOrganizationPopulationServed
{
    #region "IOrganizationPopulationServed Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String AgeUnit { get; set; }

    /// <summary>
    /// Early Learning Oldest Age Authorized to Serve
    /// <para>
    /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    Int32? OldestAgeServed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Special Circumstances Population Served
    /// <para>
    /// Program provides services to meet the needs of children in special circumstances.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19852">Special Circumstances Population Served</a>
    /// </para>
    /// </summary>
    Guid? RefPopulationServedId { get; set; }

    /// <summary>
    /// Early Learning Youngest Age Authorized to Serve
    /// <para>
    /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    Int32? YoungestAgeServed { get; set; }

    #endregion
}
