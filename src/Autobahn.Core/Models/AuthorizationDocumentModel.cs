//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthorizationDocumentModel.cs
//***************************************************************************

/// <summary>
/// The AuthorizationDocument Model
/// </summary>
public partial class AuthorizationDocumentModel : AutobahnBaseModel, IAuthorizationDocument
{
    #region "IAuthorizationDocument Properties"
    /// <summary>
    /// Authorization Acceptance Indicator
    /// <para>
    /// Indicates authorizer agreement to a document or plan, such as 
    /// plan for delivery of student services, program, or improvement 
    /// plan.
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
    public System.String DecisionExplanation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorizer Type
    /// <para>
    /// Type of person who authorized the decision or document.
    /// </para>
    /// </summary>
    public Guid? RefAuthorizerTypeId { get; set; }
    #endregion
}
