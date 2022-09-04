//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RoleEntity.cs
//***************************************************************************

/// <summary>
/// The Role Entity
/// </summary>
[Table("Role", Schema ="Core")]
public partial class RoleEntity : EntityBase, IRole
{
    #region "RoleEntity Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider serviceProvider;

    /// <summary>
    /// RoleEntity Constructor
    /// </summary>
    public RoleEntity(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRoleEntityConstruction();
    }

    /// <summary>
    /// RoleEntity Constructor partial method
    /// <para>
    /// This method is called by the model constructor
    /// to allow the inclusion of custom processing in
    /// the models construction
    /// </para>
    /// </summary>
    partial void OnRoleEntityConstruction();
    #endregion"

    #region "IRole Properties"
    /// <summary>
    /// Role
    /// <para>
    /// A description of the way in which a person relates to an organization.
    /// </para>
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Role Type
    /// <para>
    /// A description of the way in which a person relates to an organization.
    /// </para>
    /// </summary>
    [ForeignKey("RefRole")]
    public Guid? RefRoleId { get; set; }
    #endregion

    /// <summary>
    /// The foreign key reference for a role reference
    /// </summary>
    public virtual RefRoleEntity RefRole { get; set; }
}
