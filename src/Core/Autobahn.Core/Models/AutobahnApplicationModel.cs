//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AutobahnApplication.cs
//***************************************************************************

/// <summary>
/// Information used by an application or service that authenticates 
/// the identity of a person or authorizes a person’s access to 
/// information or services.
/// </summary>
public partial class AutobahnApplicationModel : AutobahnBaseModel, IAutobahnApplication
{
    #region "IAutobahnApplication Properties"
    /// <summary>
    /// Authorization Application Name
    /// <para>
    /// The name of a data system or application which an authenticated 
    /// person may access.
    /// </para>
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Authorization Application URI
    /// <para>
    /// The Uniform Resource Identifier (URI) of a data system or application which an authenticated person may access.
    /// </para>
    /// </summary>
    public Uri Uri { get; set; }
    #endregion
}
