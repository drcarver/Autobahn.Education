//***************************************************************************
//* DomainName: Common Models
//* FileName:   IServiceStaff.g.cs
//***************************************************************************

/// <summary>
/// The IServiceStaff file
/// </summary>
public partial interface IServiceStaff
{
    #region "IServiceStaff Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Special Education Support Services Category
    /// <para>
    /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
    /// </para>
    /// </summary>
    Guid RefSpecialEducationStaffCategoryId { get; set; }

    #endregion
}
