//***************************************************************************
//* DomainName: Common Models
//* FileName:   IRequiredImmunization.g.cs
//***************************************************************************

/// <summary>
/// The IRequiredImmunization file
/// </summary>
public partial interface IRequiredImmunization
{
    #region "IRequiredImmunization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Required Immunization
    /// <para>
    /// An indication that an immunization is specifically required by an organization or governing body.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
    /// </para>
    /// </summary>
    Guid RefImmunizationTypeId { get; set; }

    #endregion
}
