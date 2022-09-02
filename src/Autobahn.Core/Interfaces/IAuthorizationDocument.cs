//**********************************************************
//* DomainName: Autbahn.Core
//* FileName:   IAuthorizationDocument.cs
//***************************************************************************

 /// <summary>
 /// The Authorization Document Interface
 /// </summary>
public partial interface IAuthorizationDocument
{
    #region "IAuthorizationDocument Properties"
    /// <summary>
    /// The primary key
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Authorization Acceptance Indicator
    /// <para>
    /// Indicates authorizer agreement to a document or plan, such as plan 
    /// for delivery of student services, program, or improvement plan.
    /// </para>
    /// </summary>
    Boolean? AcceptanceIndicator { get; set; }

    /// <summary>
    /// Authorization Date
    /// <para>
    /// The date the authorization occurred.
    /// </para>
    /// </summary>
    DateTime? AuthorizationDate { get; set; }

    /// <summary>
    /// Authorization Decision Explanation
    /// <para>
    /// Authorizer's explanation regarding the authorization decision.
    /// </para>
    /// </summary>
    string DecisionExplanation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorizer Type
    /// <para>
    /// Type of person who authorized the decision or document.
    /// </para>
    /// </summary>
    Guid? RefAuthorizerTypeId { get; set; }
    #endregion
}
