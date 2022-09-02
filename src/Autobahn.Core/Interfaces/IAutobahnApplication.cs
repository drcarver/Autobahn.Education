//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IAUtobahnApplication.cs
//***************************************************************************

/// <summary>
/// Information used by an application or service that authenticates 
/// the identity of a person or authorizes a person’s access to 
/// information or services.
/// </summary>
public partial interface IAutobahnApplication
{
    #region "IAutobahnApplication Properties"
    /// <summary>
    /// The primary key of the model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Authorization Application Name
    /// <para>
    /// The name of a data system or application which an authenticated 
    /// person may access.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Authorization Application URI
    /// <para>
    /// The Uniform Resource Identifier (URI) of a data system or 
    /// application which an authenticated person may access.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20128">Authorization Application URI</a>
    /// </para>
    /// </summary>
    public Uri Uri { get; set; }

    #endregion
}
