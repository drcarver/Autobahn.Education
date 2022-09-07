//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ServiceStaffEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServiceStaff file
/// </summary>
public partial class ServiceStaffModel : AutobahnBaseModel, IServiceStaff
{
    #region "IServiceStaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Special Education Support Services Category
    /// <para>
    /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
    /// </para>
    /// </summary>
    public Guid RefSpecialEducationStaffCategoryId { get; set; }

    #endregion
}
