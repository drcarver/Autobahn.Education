//***************************************************************************
//* DomainName: Common Models
//* FileName:   RequiredImmunizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRequiredImmunization file
/// </summary>
public partial class RequiredImmunizationModel : AutobahnBaseModel, IRequiredImmunization
{
    #region "IRequiredImmunization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Required Immunization
    /// <para>
    /// An indication that an immunization is specifically required by an organization or governing body.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19307">Required Immunization</a>
    /// </para>
    /// </summary>
    public Guid RefImmunizationTypeId { get; set; }

    #endregion
}
