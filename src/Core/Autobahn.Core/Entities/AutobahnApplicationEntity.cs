//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AutobahnApplicationEntity.cs
//***************************************************************************

/// <summary>
/// The Application View Model
/// </summary>
[Table("AutobahnApplication", Schema ="Core")]
public partial class AutobahnApplicationEntity : EntityBase, IAutobahnApplication
{
    #region "IApplication Properties"
    /// <summary>
    /// Authorization Application Name
    /// <para>
    /// The name of a data system or application which an authenticated 
    /// person may access.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(120,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Authorization Application URI
    /// <para>
    /// The Uniform Resource Identifier (URI) of a data system or 
    /// application which an authenticated person may access.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public Uri Uri { get; set; }

    #endregion
}
