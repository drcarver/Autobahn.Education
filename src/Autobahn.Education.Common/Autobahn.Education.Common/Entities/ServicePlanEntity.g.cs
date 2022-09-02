//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServicePlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServicePlan file
/// </summary>
[Table("ServicePlan", Schema = "Common")]
public partial class ServicePlanEntity : EntityBase, IServicePlan
{
    #region "IServicePlan Properties"
    /// <summary>
    /// Declined Services Date
    /// <para>
    /// The date recommended services were declined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20693">Declined Services Date</a>
    /// </para>
    /// </summary>
    [Comment("The date recommended services were declined.")]
    public DateTime? DeclinedServicesDate { get; set; }

    /// <summary>
    /// Service Extends Outside School Year
    /// <para>
    /// Determination if this service continues outside school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20698">Service Extends Outside School Year</a>
    /// </para>
    /// </summary>
    [Comment("Determination if this service continues outside school year.")]
    public Boolean? ExtendsOutsideSchoolYear { get; set; }

    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that services are provided to the child in a place where children of all abilities learn together.")]
    public Boolean? InclusiveSettingIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reason for Declined Services
    /// <para>
    /// The reason given for declining the recommended services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20460">Reason for Declined Services</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The reason given for declining the recommended services.")]
    public System.String ReasonForDeclinedServices { get; set; }

    /// <summary>
    /// Service Setting Description
    /// <para>
    /// Description of the setting in which the services are delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20699">Service Setting Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Description of the setting in which the services are delivered.")]
    public System.String SettingDescription { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
