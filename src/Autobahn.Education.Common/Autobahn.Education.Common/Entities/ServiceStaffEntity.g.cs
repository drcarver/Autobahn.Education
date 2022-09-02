//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServiceStaffEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServiceStaff file
/// </summary>
[Table("ServiceStaff", Schema = "Common")]
public partial class ServiceStaffEntity : EntityBase, IServiceStaff
{
    #region "IServiceStaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
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
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefSpecialEducationStaffCategory")]
    [Comment("Titles of personnel employed and contracted to provide special education and related services for children with disabilities.")]
    public Guid RefSpecialEducationStaffCategoryId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefSpecialEducationStaffCategoryEntity RefSpecialEducationStaffCategoryEntity { get; set; }

    #endregion
}
