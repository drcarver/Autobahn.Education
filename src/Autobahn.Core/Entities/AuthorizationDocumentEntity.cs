//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthorizationDocumentEntity.cs
//***************************************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The AuthorizationDocument Entity
/// </summary>
[Table("AuthorizationDocument", Schema = "Core")]
public partial class AuthorizationDocumentEntity : EntityBase, IAuthorizationDocument
{
    #region "IAuthorizationDocument Properties"
    /// <summary>
    /// Authorization Acceptance Indicator
    /// <para>
    /// Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
    /// </para>
    /// </summary>
    public Boolean? AcceptanceIndicator { get; set; }

    /// <summary>
    /// Authorization Date
    /// <para>
    /// The date the authorization occurred.
    /// </para>
    /// </summary>
    public DateTime? AuthorizationDate { get; set; }

    /// <summary>
    /// Authorization Decision Explanation
    /// <para>
    /// Authorizer's explanation regarding the authorization decision.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    public System.String DecisionExplanation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorizer Type
    /// <para>
    /// Type of person who authorized the decision or document.
    /// </para>
    /// </summary>
    [ForeignKey("RefAuthorizerType")]
    public Guid? RefAuthorizerTypeId { get; set; }
    #endregion

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public virtual OrganizationPersonRoleEntity OrganizationPersonRole { get; set; }

    /// <summary>
    /// Authorizer Type
    /// <para>
    /// Type of person who authorized the decision or document.
    /// </para>
    /// </summary>
    public virtual RefAuthorizerTypeEntity RefAuthorizerType { get; set; }

}
